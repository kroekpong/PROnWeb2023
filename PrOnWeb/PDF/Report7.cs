using System;
using System.Collections.Generic;
using System.IO;
using iText.Forms;
using iText.Kernel.Pdf;
using Microsoft.JSInterop;
using PrOnWeb.Data;
using Microsoft.AspNetCore.Hosting;

namespace PrOnWeb.PDF
{
    public class Report7
    {
        private Dictionary<string, string> _passParams;
        private int _itemCount;
        private readonly IWebHostEnvironment _env;
        public Report7(IWebHostEnvironment env)
        {
            _env = env;
        }


        //public void Generate(IJSRuntime js, int ItemCount, string filename = "report.pdf")
        //{

        //    js.InvokeVoidAsync("jsSaveAsFile",
        //                        filename,
        //                        Convert.ToBase64String(ReportPDF())
        //                        );
        //}

        //public void OpenToIframe(IJSRuntime js, string idiFrame, int ItemCount)
        //{

        //    js.InvokeVoidAsync("jsOpenToIframe",
        //                        idiFrame,
        //                        Convert.ToBase64String(ReportPDF())
        //                        );
        //}
        public void OpenNewTab(IJSRuntime js, Dictionary<string, string> passParams, int ItemCount, string filename = "report.pdf")
        {
            _passParams = passParams;
            _itemCount = ItemCount;

            js.InvokeVoidAsync("jsOpenIntoNewTab",
                                filename,
                                Convert.ToBase64String(ReportPDF())
                                );
        }

        private byte[] ReportPDF()
        {
            using MemoryStream memoryStream = new MemoryStream();
            PdfReader reader;
            if (_passParams["isMEPT"] == "X")
            {
                if (_itemCount < 9)
                {
                    reader = new PdfReader(_env.WebRootPath + "/Resources/PrFormMEPT.pdf"); //Input
                }
                else
                {
                    reader = new PdfReader(_env.WebRootPath + "/Resources/PrFormMEPT2P.pdf"); //Input
                }
            }
            else
            {
                if (_itemCount < 8)
                {
                    reader = new PdfReader(_env.WebRootPath + "/Resources/PrForm.pdf"); //Input
                }
                else
                {
                    reader = new PdfReader(_env.WebRootPath + "/Resources/PRForm2P.pdf"); //Input
                }
            }
            PdfWriter writer = new PdfWriter(memoryStream); //output
            PdfDocument pdfDoc = new PdfDocument(reader, writer);
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            var fields = form.GetFormFields();
            if (_passParams["isMEPT"] == "X") // MEPT Form
            {
                fields["PR_No"].SetValue(_passParams["PR_No_MEPT"]);
                fields["IssuingDate"].SetValue(_passParams["IssuingDate"]);
                fields["Tracking_No"].SetValue(_passParams["Tracking_No"]);
                fields["Requester"].SetValue(_passParams["Requester"]);
                fields["Department"].SetValue(_passParams["Department"]);
                fields["DesiredVendor"].SetValue(_passParams["DesiredVendor"]);

                // TODO
                fields["SMName"].SetValue(_passParams["SMName"]);
                fields["DMName"].SetValue(_passParams["DMName"]);
                fields["L3Name"].SetValue(_passParams["L3Name"]);
                fields["L4Name"].SetValue(_passParams["L4Name"]);
                fields["L5Name"].SetValue(_passParams["L5Name"]);
                fields["L6Name"].SetValue(_passParams["L6Name"]);
                fields["L7Name"].SetValue(_passParams["L7Name"]);


                fields["Comment"].SetValue(_passParams["Comment"]);
                for (int i = 0; i < _itemCount; i++)
                {

                    fields["Item." + i.ToString()].SetValue(_passParams["Item_" + i.ToString()]);
                    fields["Material_Group." + i.ToString()].SetValue(_passParams["Material_Group_" + i.ToString()]);
                    fields["Item_Description." + i.ToString()].SetValue(_passParams["Item_Description_" + i.ToString()]);
                    fields["Quantity." + i.ToString()].SetValue(_passParams["Quantity_" + i.ToString()]);
                    fields["UOM." + i.ToString()].SetValue(_passParams["UOM_" + i.ToString()]);
                    fields["Cost." + i.ToString()].SetValue(_passParams["UnitPrice_" + i.ToString()]); // สลับกัน
                    fields["AmountRow." + i.ToString()].SetValue(_passParams["Cost_" + i.ToString()]); // สลับกัน
                    fields["Currency." + i.ToString()].SetValue(_passParams["Currency_" + i.ToString()]);
                    fields["DateNeed." + i.ToString()].SetValue(_passParams["DateNeed_" + i.ToString()]);
                }
                fields["TotalAmt"].SetValue(_passParams["TotalAmt"]);
            }

            else // TPAC TPCC form
            {
                fields["PR_No"].SetValue(_passParams["PR_No"]);
                fields["Objective"].SetValue(_passParams["Objective"]);
                fields["Department"].SetValue(_passParams["Department"]);
                fields["Requester"].SetValue(_passParams["Requester"]);
                fields["Purchaser"].SetValue(_passParams["Purchaser"]);
                fields["Budget"].SetValue(_passParams["Budget"]);

                fields["SMName"].SetValue(_passParams["SMName"]);
                fields["DMName"].SetValue(_passParams["DMName"]);
                fields["L3Name"].SetValue(_passParams["L3Name"]);
                fields["L4Name"].SetValue(_passParams["L4Name"]);
                fields["L5Name"].SetValue(_passParams["L5Name"]);
                fields["L6Name"].SetValue(_passParams["L6Name"]);
                fields["L7Name"].SetValue(_passParams["L7Name"]);

                fields["isTPAC1"].SetValue(_passParams["isTPAC1"]);
                fields["isTPAC2"].SetValue(_passParams["isTPAC2"]);
                fields["isTPAC3"].SetValue(_passParams["isTPAC3"]);
                fields["isTPCC1"].SetValue(_passParams["isTPCC1"]);
                fields["isTPCC2"].SetValue(_passParams["isTPCC2"]);

                fields["isAD_Co"].SetValue(_passParams["isAD_CO"]);
                fields["isIT_Co"].SetValue(_passParams["isIT_CO"]);
                fields["isSE_Co"].SetValue(_passParams["isSE_CO"]);
                fields["isNO_Co"].SetValue(_passParams["isNO_CO"]);
                fields["isQC_Co"].SetValue(_passParams["isQC_CO"]);


                fields["isCG"].SetValue(_passParams["isCG"]);
                fields["isISO"].SetValue(_passParams["isISO"]);
                fields["isSCA"].SetValue(_passParams["isSCA"]);

                fields["IssuingDate"].SetValue(_passParams["IssuingDate"]);
                fields["DateReceive"].SetValue(_passParams["DateReceive"]);

                /* Todo Table List */
                for (int i = 0; i < _itemCount; i++)
                {

                    fields["Item." + i.ToString()].SetValue(_passParams["Item_" + i.ToString()]);
                    fields["Item_Description." + i.ToString()].SetValue(_passParams["Item_Description_" + i.ToString()]);
                    fields["Quantity." + i.ToString()].SetValue(_passParams["Quantity_" + i.ToString()]);
                    fields["Material_Group." + i.ToString()].SetValue(_passParams["Material_Group_" + i.ToString()]);
                    fields["Cost." + i.ToString()].SetValue(_passParams["Cost_" + i.ToString()]);
                    fields["WBS." + i.ToString()].SetValue(_passParams["WBS_" + i.ToString()]);
                    fields["DateNeed." + i.ToString()].SetValue(_passParams["DateNeed_" + i.ToString()]);
                }


                fields["TotalAmt"].SetValue(_passParams["TotalAmt"]);

            }

            form.FlattenFields();

            pdfDoc.Close();
            byte[] b = memoryStream.ToArray();
            return b;
        }
    }
}
