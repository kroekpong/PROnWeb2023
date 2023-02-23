using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;

namespace PrOnWeb.Services
{
    using CsvHelper.Configuration;
    using Microsoft.AspNetCore.Components;
    using System.Globalization;
    using System.IO;

    public class ImportCSV : IImportCSV
    {
        [Inject]
        PrwaConfiguration PrConfiguration { get; set; }

        public string PathRawIn = "/CoStorage/";
        public string PathRawArchive = "/RawDataArchive/";
        private readonly IWebHostEnvironment _env;

        #region Import Log
        Import_Log importLog;
        private DateTime ImportDateTime;
        private int RawRecordCount;
        private int GoodRecordCount;
        private int BadRecordCount;
        private int PrHeadIdStart;
        private int PrHeadCount;
        private int PrItemIdStart;
        private int PrItemCount;
        #endregion

        #region Attributes
        private List<CsvLine> lines = new List<CsvLine>();
        private int BadCount;
        #endregion

        ApplicationDbContext _context;
        public ImportCSV(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        private void DeletePR(int PrId)
        {
            //// ยกเลิกการลบข้อมูลทิ้ง เปลี่ยนเป็น
            /// 1. แก้ Status เป็น DEL
            /// 2. แก้ เลขที่ PR โดยใส่ตัว L ต่อท้าย *** Approval Flow ไม่ต้องทำอะไร
            PRHeader pRHeader = _context.PRHeaders.Where(x => x.Id == PrId).First();
            string prNo = "L-" + pRHeader.Pr_No;
            pRHeader.Status = "DEL"; // delete
            pRHeader.Pr_No = prNo;
            _context.PRHeaders.Update(pRHeader);
            _context.SaveChanges();

            List<PRItem> prItems = _context.PRItems.Where(x => x.PrHeaders.Id == PrId).ToList();
            foreach (var item in prItems)
            {
                item.PrHeaders.Pr_No = prNo;
                _context.PRItems.Update(item);
                _context.SaveChanges();
            }

            /// ส่วนนี้ยกเลิก
            //// ลบข้อมูลเก่า
            //List<PRItem> prItems = _context.PRItems.Where(x => x.PrHeaders.Id == PrId).ToList();
            //foreach (var item in prItems)
            //{
            //    _context.PRItems.Remove(item);
            //    _context.SaveChanges();
            //}
            //PRHeader pRHeader = _context.PRHeaders.Where(x => x.Id == PrId).First();
            //_context.PRHeaders.Remove(pRHeader);
            //_context.SaveChanges();
            //// จะต้องลบ Approval_flow ออกไปด้วย ถ้ามี
            //List<Approval_flow> approval_Flows = _context.Approval_Flows.Where(x => x.Pr_id == PrId).ToList();
            //foreach (var item in approval_Flows)
            //{
            //    _context.Approval_Flows.Remove(item);
            //    _context.SaveChanges();
            //}
        }


        // Import ได้หรือไม่ ? : Return : Yes, No, Override, Merge (PO)
        //  ตรวจ PrNo
        //      ยังไม่มี : Import ได้เลย
        //      มีอยู่แล้ว :
        //          Status : New => ทับได้เลย
        //              ลบของเก่าทิ้ง และ Import ได้เลย
        //          Status : WAJ => Merge
        //              PrHeader ทับ Record เดิม
        //              PrItem ทับ Record เดิม (ตาม Item No)
        //          Status : อื่น => Merge PO
        private string GetImportMode(string prNo)
        {
            string ImportMode = "Y"; // default คือ Yes
            var prHExist = _context.PRHeaders.Where(x => x.Pr_No == prNo).FirstOrDefault();
            if (prHExist != null) // มีอยู่แล้ว
            {
                if (prHExist.Status == "NEW" || prHExist.Status == null)
                {
                    DeletePR(prHExist.Id);
                    // Import ได้เลย
                    ImportMode = "Y";
                }
                else if (prHExist.Status == "WAJ" || prHExist.Status == "REJ") // เป็น การ REJ โดย user หรือ Adjust Budget จาก RN
                {
                    // ทับ ข้อมูลเก่า ที่ Id เดียวกัน
                    ImportMode = "O";
                }
                else // Submit แล้ว (ไม่ NEW) = ห้าม Import
                {
                    //var af = _context.Approval_Flows.Where(x => x.Pr_id == prHExist.Id && x.Status == "A").ToList();
                    //if (af.Count == 0)
                    //{
                    //    // ลบข้อมูลเก่า
                    //    DeletePR(prHExist.Id);
                    //    // ต้องลบ Approval_Flow ออกไปด้วย

                    //    // import ได้เลย
                    //    isImportable = true;
                    //}
                    //else
                    //{
                    // Merge Import เนื่องจากมีรายการอยู่แล้วและ กำลัง approve
                    ImportMode = "M";
                    //}
                }
            }
            return ImportMode;
        }

        // =========
        private void PrShaper()
        {
            //Console.WriteLine(" - Import done:  {0} lines imported!\r\n", lines.Count);
            //Console.WriteLine(" -               {0} lines bad!\r\n", BadCount);
            GoodRecordCount = lines.Count;
            if (lines[0] != null)
            {
                BadRecordCount = BadCount;
                var prH = _context.PRHeaders.OrderByDescending(x => x.Id).FirstOrDefault();
                PrHeadIdStart = 1;
                if (prH != null)
                {
                    PrHeadIdStart = prH.Id + 1;
                }
                var prI = _context.PRItems.OrderByDescending(x => x.Id).FirstOrDefault();
                PrItemIdStart = 1;
                if (prI != null)
                {
                    PrItemIdStart = prI.Id + 1;
                }
                PrHeadCount = 0;
                PrItemCount = 0;

                string LastPrNo = ""; // เริ่มต้นเป็น Blank
                int PrCount = 0;
                string ImportMode = "";

                // Start Shape PR
                PRHeader newPRHeader = new PRHeader(); // New PR Header
                PRItem newPRItem = new PRItem();
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] != null)
                    {
                        if (lines[i].PR_No != LastPrNo) // header หนเดียว
                        { //เป็น PR ใบใหม่ และ สามารถ import ได้ (Pr_No != "")
                            if (LastPrNo != "" && newPRHeader.Pr_No != "")
                            {
                                //newPRHeader = new PRHeader() { Pr_No = lines[i].PR_No };
                                //_context.PRHeaders.Add(newPRHeader); // Save New Header
                                //_context.SaveChanges();
                                PrHeadCount += 1; // นับ
                            }

                            PrCount++; // นับจำนวน PR
                            LastPrNo = lines[i].PR_No; // PR_NO ใบใหม่
                                                       // Check dup
                            ImportMode = GetImportMode(LastPrNo); // Yes, No, Override, Merge
                            if (ImportMode == "Y")
                            {
                                newPRHeader = new PRHeader() { Pr_No = lines[i].PR_No };
                                _context.PRHeaders.Add(newPRHeader);
                                _context.SaveChanges();  // สร้าง record ใหม่
                            }else if (ImportMode == "O") // มีอยู่แล้ว ทับลงใน record เดิม
                            {
                                newPRHeader = _context.PRHeaders.Where(x => x.Pr_No == LastPrNo).FirstOrDefault();
                            }

                            if (ImportMode == "Y" || ImportMode == "O")
                            {
                                // สร้าง New Header
                                newPRHeader.Company = lines[i].Company;
                                newPRHeader.Pr_No = lines[i].PR_No;
                                newPRHeader.Purchasing_Group = lines[i].Purchasing_Group;
                                newPRHeader.Pr_Date = ToDateTime(lines[i].Date);
                                //Pr_Date = DateTime.ParseExact( lines[i].Date; "yyyyMMdd";
                                //                            System.Globalization.CultureInfo.InvariantCulture);
                                newPRHeader.Requester = lines[i].Requester;
                                newPRHeader.Plant = lines[i].Plant;
                                newPRHeader.Tracking_No = lines[i].Tracking_No;
                                newPRHeader.Purchasing_Org = lines[i].Purchasing_Org;
                                newPRHeader.Department = lines[i].Department;
                                newPRHeader.Release_Date = ToDateTime(lines[i].Release_Date);
                                newPRHeader.Section = lines[i].Section;
                                newPRHeader.Objective = lines[i].Objective;
                                newPRHeader.Status = "NEW";
                                newPRHeader.Comment = lines[i].Comment;
                                _context.PRHeaders.Update(newPRHeader);
                                _context.SaveChanges();
                            }
                        }
                        // add Item =======================
                        if (ImportMode == "Y") // สร้าง Items ใหม่
                        {
                            newPRItem = new PRItem() { PrHeaders = newPRHeader };
                            _context.PRItems.Add(newPRItem);
                            _context.SaveChanges();

                        }else if (ImportMode == "O") // Override
                        {
                            newPRItem = _context.PRItems
                                .Where(x => x.PrHeaders.Pr_No == lines[i].PR_No && x.Item_No == lines[i].Item_No)
                                .FirstOrDefault();
                            if (newPRItem == null) // this is new item
                            {
                                newPRItem = new PRItem() { PrHeaders = newPRHeader };
                                _context.PRItems.Add(newPRItem);
                                _context.SaveChanges();
                            }

                        }else if (ImportMode == "M") // Merge PO Field
                        {
                            newPRItem = _context.PRItems
                                .Where(x => x.PrHeaders.Pr_No == lines[i].PR_No && x.Item_No == lines[i].Item_No)
                                .FirstOrDefault();
                            if (newPRItem != null)
                            {
                                newPRItem.PO_No = lines[i].PO_No;
                                newPRItem.PO_ITEM_NO = lines[i].PO_ITEM_NO;
                                newPRItem.PO_DATE = ToDateTime(lines[i].PO_DATE);
                                _context.PRItems.Update(newPRItem);
                                _context.SaveChanges();
                            }
                        }


                        if (ImportMode == "Y" || ImportMode == "O")
                        {
                            newPRItem.PrHeaders = newPRHeader;
                            newPRItem.Item_No = lines[i].Item_No;
                            newPRItem.Delete_Status = lines[i].Delete_Status;
                            newPRItem.Item_Description = lines[i].Item_Descriptiom;
                            newPRItem.Item_Code = lines[i].Item_Code;
                            newPRItem.Material_Group = lines[i].Material_Group;
                            newPRItem.Material_Group_Des = lines[i].Material_Group_Des;
                            newPRItem.Quantity = float.Parse(lines[i].Quantity);
                            newPRItem.UOM = lines[i].Unit;
                            newPRItem.Requistion_date = DateTime.ParseExact(lines[i].Requisition_Date, "yyyyMMdd",
                                                            System.Globalization.CultureInfo.InvariantCulture);
                            newPRItem.Delivery_date = DateTime.ParseExact(lines[i].Delivery_Date, "yyyyMMdd",
                                                            System.Globalization.CultureInfo.InvariantCulture);
                            newPRItem.Price_PR = float.Parse(lines[i].Price_PR);
                            newPRItem.Price_Unit = Int32.Parse(lines[i].Price_Unit);
                            newPRItem.Desired_Vendor = lines[i].Desired_Vendor_Name;
                            newPRItem.Fixed_Vendor = lines[i].Fixed_Vendor_Name;
                            newPRItem.Currency = lines[i].Currency;
                            newPRItem.Account_Ass_Cat = lines[i].Account_Ass_Cat;
                            newPRItem.GL_Account = lines[i].GL_Account;
                            newPRItem.Cost_Center = lines[i].Cost_Center;
                            newPRItem.WBS_Code = lines[i].WBS_Code;
                            newPRItem.PR_Closed = (lines[i].PR_Closed == "TRUE");
                            newPRItem.PR_Fixed = (lines[i].PR_Fixed == "TRUE");
                            newPRItem.PO_No = lines[i].PO_No;
                            newPRItem.PO_ITEM_NO = lines[i].PO_ITEM_NO;
                            newPRItem.PO_DATE = ToDateTime(lines[i].PO_DATE);
                            newPRItem.ExRate = float.Parse(lines[i].ExRate);
                            //Console.WriteLine(lines[i].PR_No);
                            PrItemCount += 1;
                            _context.PRItems.Update(newPRItem);
                            _context.SaveChanges();
                        }
                    }
                }
            }
        }

        // =========
        public void Import1File(string filename)
        {
            // check if "filename" aready imported
            string fileNameOnly = Path.GetFileName(filename);
            var il = _context.ImportLogs.Where(x => x.Import_File_Name == fileNameOnly).FirstOrDefault();
            if (il == null)
            {
                //try
                var bad = new List<string>();
                var isRecordBad = false;
                lines.Clear();

                var config = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    Delimiter = "|",
                    MissingFieldFound = null,
                    ShouldQuote = args=>true,
                    Mode = CsvHelper.CsvMode.NoEscape,
                    BadDataFound = context =>
                    {
                        isRecordBad = true;
                        bad.Add(context.RawRecord);
                    }
                };

                using (var fs = new StreamReader(filename))
                using (var csv = new CsvHelper.CsvReader(fs, config))
                {
                    //csv.Configuration.Delimiter = "|";
                    //csv.Configuration.BadDataFound = context =>
                    //{
                    //    isRecordBad = true;
                    //    bad.Add(context.RawRecord);
                    //};
                    //csv.Configuration.MissingFieldFound = null;
                    while (csv.Read())
                    {
                        var record = csv.GetRecord<CsvLine>();
                        if (!isRecordBad)
                        {
                            lines.Add(record);
                        }
                        isRecordBad = false;
                    }
                    BadCount = bad.Count;
                    PrShaper();
                    fs.Close();
                }

                importLog = new Import_Log()
                {
                    Import_DateTime = DateTime.Now,
                    Raw_Record_Count = RawRecordCount,
                    Import_File_Name = fileNameOnly,
                    Good_Record_Count = GoodRecordCount,
                    Bad_Record_Count = BadRecordCount,
                    Pr_Header_Id_Start = PrHeadIdStart,
                    Pr_Header_Count = PrHeadCount,
                    Pr_Item_Id_Start = PrItemIdStart,
                    Pr_Item_Count = PrItemCount
                };
                _context.ImportLogs.Add(importLog);
                _context.SaveChanges();
            }
        }

        public List<SystemConfiguration> configs;

        // =============================================Start=========================
        public void ImportPR()
        {
            if (PrConfiguration == null) // try read if null
            {
                configs = _context.systemConfigurations.ToList();
                var ImportPath = configs.Where(x => x.ConfigName == "CSVImportPath").First().ConfigValue;
                var ArchivePath = configs.Where(x => x.ConfigName == "CSVArchivePath").First().ConfigValue;
                PrConfiguration = new PrwaConfiguration();
                PrConfiguration.SetConfiguration(ImportPath, ArchivePath);
            }
            if (PrConfiguration != null)
            {
                PathRawIn = "/" + PrConfiguration.CSVImportPath;
                PathRawArchive = "/" + PrConfiguration.CSVArchivePath;
            }
            var filePath = _env.WebRootPath + PathRawIn;
            string[] RawFiles = Directory.GetFiles(filePath, "*.CSV");
            string FileName;
            string NewFileName;
            if (RawFiles.Count() > 0)
            {
                // …
                RawRecordCount = RawFiles.Count();
                foreach (var rawFile in RawFiles)
                {
                    importLog = new Import_Log();

                    Import1File(rawFile);

                    FileName = Path.GetFileName(rawFile);
                    NewFileName = DateTime.Now.ToString("yMMdd") + "-" + FileName;
                    // move this raw to Raw Archive
                    File.Move(rawFile, _env.WebRootPath + PathRawArchive + "//" + NewFileName, true);
                }
            }
            else
            {
                importLog = new Import_Log()
                {
                    Import_DateTime = DateTime.Now,
                    Raw_Record_Count = 0,
                    Import_File_Name = "No raw file.",
                    Good_Record_Count = 0,
                    Bad_Record_Count = 0,
                    Pr_Header_Id_Start = 0,
                    Pr_Header_Count = 0,
                    Pr_Item_Id_Start = 0,
                    Pr_Item_Count = 0
                };
                _context.ImportLogs.Add(importLog);
                _context.SaveChanges();
            }
        }

        private DateTime? ToDateTime(string DateIn)
        {
            DateTime? d = null;
            DateTime d2;
            bool success = DateTime.TryParseExact(DateIn, "yyyyMMdd",
                System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out d2);
            if (success)
            {
                d = d2;
            }
            return d;
        }


    }
}
