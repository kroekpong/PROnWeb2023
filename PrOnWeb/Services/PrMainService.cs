using Microsoft.EntityFrameworkCore;
using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace PrOnWeb.Services
{
    public class PrMainService
    {
        ApplicationDbContext _context;

        public PrMainService(ApplicationDbContext context)
        {
            _context = context;
        }



        // ===== PR =====
        public async Task<List<PRHeader>> GetPrHeadersAsync()
        {
            return await _context.PRHeaders.ToListAsync();
        }
        public async Task<List<vPRHeader>> GetPrHeaderForStatusAsync(string status)
        {
            return await _context.vPRHeaders.Where(
                x => x.Status == status).ToListAsync();
        }

        public async Task<List<vPRHeader>> GetPrHeaderNotCloseAsync(string org, string dep, string sec)
        {
            return await _context.vPRHeaders.Where(
                  x => x.Company == org &&
                  x.Department == dep &&
                  x.Section == sec).ToListAsync();
        }
        public async Task<PRHeader> GetPrHeaderAsync(int Id)
        {
            return await _context.PRHeaders.FindAsync(Id);
        }
        public async Task UpdatePrHeaderAsync(PRHeader prHeader)
        {
            _context.PRHeaders.Update(prHeader);
            await _context.SaveChangesAsync();
        }

        // ===== PR view =====
        public async Task<List<WorkflowAutho>> GetWorkflowAuthosAsync(int UserId)
        {
            return await _context.WorkflowAuthos.Where(x => x.User_Id == UserId).ToListAsync();
        }

        private PrListModel MapPrHeaderToPrlist(vPRHeader prh, int ListLevel)
        {
            PrListModel prl = new PrListModel()
            {
                Approver_role = "",
                Approver_id = 0,
                Appr_Status = "",
                Is_Disabled = false,
                Af_Version = 0,
                Id = prh.Id,
                Company = prh.Company,
                Purchasing_Group = prh.Purchasing_Group,
                Pr_Date = prh.Pr_Date,
                Requester = prh.Requester,
                Plant = prh.Plant,
                Tracking_No = prh.Tracking_No,
                Purchasing_Org = prh.Purchasing_Org,
                Department = prh.Department,
                Pr_No = prh.Pr_No,
                Create_Date = prh.Create_Date,
                Print_Status = prh.Print_Status,
                Status = prh.Status,
                PrStatus = prh.PrStatus,
                NumberOfItem= prh.NumberOfItem,
                PrAmt = prh.PrAmt,
                sPrAmt = prh.sPrAmt,
                PO_DATE = prh.PO_DATE,
                PO_ITEM_NO = prh.PO_ITEM_NO,
                PO_No = prh.PO_No,
                Release_Date = prh.Release_Date,
                Objective = prh.Objective,
                Section = prh.Section,
                Need_CG_Concerning = prh.Need_CG_Concerning,
                Need_ISO = prh.Need_ISO,
                Need_SCA_Concerning = prh.Need_SCA_Concerning,
                List_Level = ListLevel
            };
            return prl;
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase0(string myRole, string ODSs)
        {
            // CASE 1 Requester
            // ค้น approval_flow ชือ userId, (ver 0) > ได้ List ของ PrList
            // 1. ที่ยังเป็น disable = f == Active,
            // 2. ที่ Approve Status = N  == ยังไม่ approve
            // 3. อื่นๆ คือ ยังคงดำเนินการอยู่
            // 9. PR Status = DEL, PCOMP = จบแล้ว
            List<PrListModel> prListModelsTmp;
            //List<PrListModel> prListModels;
            string Sql;
            Sql = "SELECT * FROM vPRHeaders ";
            //Sql += $" WHERE Isnull(Status,'NEW') IN ( 'NEW', 'REJ') AND Company+'-'+Department+'-'+Section IN ( {ODSs}) ";
            if (myRole.StartsWith("DM"))
            {
                Sql += $" WHERE Isnull(Status,'NEW') NOT IN ( 'DEL') AND Company+'-'+Department IN ( {ODSs}) ";
            }
            else
            {
                Sql += $" WHERE Isnull(Status,'NEW') NOT IN ( 'DEL') AND Company+'-'+Department+'-'+Section IN ( {ODSs}) ";
            }
            List<vPRHeader> prhs = await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
            prListModelsTmp = new List<PrListModel>();
            foreach (var prh in prhs)
            {
                prListModelsTmp.Add(MapPrHeaderToPrlist(prh, 1)); // List Level เป็น 1 เสมอ
            }
            //prListModels.AddRange(prListModelsTmp);
            return prListModelsTmp;
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase1(int userId, string ODSs)
        {
            // CASE 1 Requester
            // ค้น approval_flow ชือ userId, (ver 0) > ได้ List ของ PrList
            // 1. ที่ยังเป็น disable = f == Active,
            // 2. ที่ Approve Status = N  == ยังไม่ approve
            // 3. อื่นๆ คือ ยังคงดำเนินการอยู่
            // 9. PR Status = DEL, PCOMP = จบแล้ว
            //List<PrListModel> prListModelsTmp;
            List<PrListModel> prListModels;
            string Sql;
            //Sql = "SELECT * FROM vPRHeaders ";
            //Sql += $" WHERE Isnull(Status,'NEW') IN ( 'NEW', 'REJ') AND Company+'-'+Department+'-'+Section IN ( {ODSs}) ";
            //Sql += $" WHERE Isnull(Status,'NEW') NOT IN ( 'DEL') AND Company+'-'+Department+'-'+Section IN ( {ODSs}) ";
            //List<vPRHeader> prhs = await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
            //prListModelsTmp = new List<PrListModel>();
            //foreach (var prh in prhs)
            //{
                //prListModelsTmp.Add(MapPrHeaderToPrlist(prh, 1)); // List Level เป็น 1 เสมอ
            //}
            //Sql += " UNION ALL ";
            Sql = "SELECT b.Approver_role, b.Approver_id, b.Status AS Appr_Status, b.Is_disabled, b.Af_Version, ";
            Sql += "a.Id, a.Company, a.Purchasing_Group, a.Pr_Date, a.Requester, a.Plant, a.Tracking_No, ";
            Sql += "a.Purchasing_Org, a.Department, a.Pr_No, a.Create_Date, a.Print_Status, a.Status, a.PO_DATE, ";
            Sql += "a.PO_ITEM_NO, a.PO_No, a.Release_Date, a.Objective, a.Section, a.Need_CG_Concerning, ";
            Sql += "a.Need_ISO, a.Need_SCA_Concerning, a.PrStatus, a.NumberOfItem, a.PrAmt, a.sPrAmt, ";
            Sql += "Case When a.Status = 'RN' Then 2 ";
            Sql += "    When b.Status = 'REJ' OR a.Status = 'WAJ' Then 2 ";
            Sql += "     When a.Status = 'DEL' OR a.Status = 'PCOMP' Then 9 ";
            Sql += "     Else 3 End AS List_Level ";
            Sql += "FROM Approval_Flows AS b INNER JOIN VPRHeaders AS a ON b.Pr_id = a.Id ";
            Sql += $" WHERE b.Af_Version= 0 AND b.Approver_id = {userId}  AND Approver_role = 'CREATOR' ";
            Sql += " Order by List_Level DESC";
            prListModels = await _context.PrLists.FromSqlRaw(Sql).ToListAsync();
            //prListModels.AddRange(prListModelsTmp);
            return prListModels;
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase2(int userId)
        {
            // CASE 2
            // ค้น approval_flow ชือ userId, (ver 0) > ได้ List ของ PrList
            // 1. ที่ยังเป็น disable = f == Active,
            // 2. ที่ Approve Status = N  == ยังไม่ approve
            // 3. อื่นๆ คือ ยังคงดำเนินการอยู่
            // 9. PR Status = DEL, PCOMP = จบแล้ว
            string Sql;
            Sql = "SELECT b.Approver_role, b.Approver_id, b.Status AS Appr_Status, b.Is_disabled, b.Af_Version, ";
            Sql += "a.Id, a.Company, a.Purchasing_Group, a.Pr_Date, a.Requester, a.Plant, a.Tracking_No, ";
            Sql += "a.Purchasing_Org, a.Department, a.Pr_No, a.Create_Date, a.Print_Status, a.Status, a.PO_DATE, ";
            Sql += "a.PO_ITEM_NO, a.PO_No, a.Release_Date, a.Objective, a.Section, a.Need_CG_Concerning, ";
            Sql += "a.Need_ISO, a.Need_SCA_Concerning,  a.PrStatus, a.NumberOfItem, a.PrAmt, a.sPrAmt, ";
            Sql += "Case when b.Is_disabled = 0 Then 1 ";
            Sql += "     When b.Status = 'N' Then 2 ";
            Sql += "     When a.Status = 'DEL' OR a.Status = 'PCOMP' Then 9 ";
            Sql += "     Else 3 End AS List_Level ";
            Sql += "FROM Approval_Flows AS b INNER JOIN VPRHeaders AS a ON b.Pr_id = a.Id ";
            Sql += $" WHERE b.Af_Version= 0 AND b.Approver_id = {userId}  AND Approver_role <> 'CREATOR' ";
            Sql += " Order by List_Level ";
            return await _context.PrLists.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase3_1(string myRole, string myODSs)
        {
            // CASE 3.1
            // SMs, DMs // myODs จะเป็นแบบ "'TPAC-AD-AD','TPCC-AD-AD'"
            string prStatus;
            string rnStatus;
            string ods;
            if (myRole.StartsWith("SM"))
            {
                prStatus = "PASM";
                rnStatus = "RNPASM";
                ods = $" Company+'-'+Department+'-'+Section IN ( {myODSs} ) ";
            }
            else // DM
            {
                prStatus = "PADM";
                rnStatus = "RNPADM";
                ods = $" Company+'-'+Department IN ( {myODSs} ) ";
            }
            List<PrListModel> prListModelsTmp;
            List<PrListModel> prListModels;
            string Sql;
            Sql = "SELECT * FROM VPRHeaders ";
            Sql += $" WHERE Status LIKE '{prStatus}' AND {ods} ";
            List<vPRHeader> prhs = await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
            prListModels = new List<PrListModel>();
            foreach (var prh in prhs)
            {
                prListModels.Add(MapPrHeaderToPrlist(prh, 1)); // List Level เป็น 1 เสมอ
            }
            Sql = " SELECT * FROM VPRHeaders ";
            Sql += " WHERE Id IN ( ";
            Sql += $" SELECT Pr_Id FROM ReturningNotes WHERE Rn_Status LIKE '{rnStatus}') AND {ods} ";
            prhs = await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
            prListModelsTmp = new List<PrListModel>();
            foreach (var prh in prhs)
            {
                prListModelsTmp.Add(MapPrHeaderToPrlist(prh, 1)); // List Level เป็น 2 เสมอ
            }
            prListModels.AddRange(prListModelsTmp);
            return prListModels;
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase3_2(string myRolePendingStatus, string myCompanies)
        {
            // CASE 3.2
            // PAAC, CSxx
            string Sql;
            Sql = "SELECT '' AS Approver_role, 0 AS Approver_id, '' AS Appr_Status, CAST(0 AS BIT) AS Is_disabled, 0 AS Af_Version, ";
            Sql += " Id, Company, Purchasing_Group, Pr_Date, Requester, Plant, Tracking_No, ";
            Sql += " Purchasing_Org, Department, Pr_No, Create_Date, Print_Status, Status, PO_DATE, ";
            Sql += " PO_ITEM_NO, PO_No, Release_Date, Objective, Section, Need_CG_Concerning, PrStatus,NumberOfItem, PrAmt, sPrAmt, ";
            Sql += " Need_ISO, Need_SCA_Concerning, 1 AS List_Level ";
            Sql += $" FROM VPRHeaders WHERE Status = '{myRolePendingStatus}' ";
            Sql += $" AND Company IN ({myCompanies}) ";
            return await _context.PrLists.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase4(string myPD)
        {
            // CASE 4 for PS Mananger
            string Sql;
            Sql = "SELECT b.Approver_role, b.Approver_id, b.Status AS Appr_Status, b.Is_disabled, b.Af_Version, ";
            Sql += "a.Id, a.Company, a.Purchasing_Group, a.Pr_Date, a.Requester, a.Plant, a.Tracking_No, ";
            Sql += "a.Purchasing_Org, a.Department, a.Pr_No, a.Create_Date, a.Print_Status, a.Status, a.PO_DATE, ";
            Sql += "a.PO_ITEM_NO, a.PO_No, a.Release_Date, a.Objective, a.Section, a.Need_CG_Concerning, ";
            Sql += "a.Need_ISO, a.Need_SCA_Concerning,  a.PrStatus, a.NumberOfItem, a.PrAmt, a.sPrAmt, ";
            Sql += $"Case when a.Status = '{myPD}' Then 1 ";
            Sql += "     When a.Status = 'RN' Then 2 ";
            Sql += "     When a.Status = 'DEL' OR a.Status = 'PCOMP' Then 9 ";
            Sql += "     Else 8 End AS List_Level ";
            Sql += "FROM Approval_Flows AS b INNER JOIN VPRHeaders AS a ON b.Pr_id = a.Id ";
            Sql += $" WHERE b.Af_Version= 0 AND b.Approver_id = 0  AND Approver_role = '{myPD}' ";
            Sql += " Order by List_Level ";
            return await _context.PrLists.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<PrListModel>> GetPrListApprovalNameAsyncCase5(int userId)
        {
            // CASE 5 for Purchaser
            string Sql;
            //Sql = "SELECT '' AS Approver_role, 0 AS Approver_id, '' AS Appr_Status, ISNUMERIC('A') AS Is_disabled, 0 AS Af_Version, ";
            //Sql += " Id, Company, Purchasing_Group, Pr_Date, Requester, Plant, Tracking_No, ";
            //Sql += " Purchasing_Org, Department, Pr_No, Create_Date, Print_Status, Status, PO_DATE, ";
            //Sql += " PO_ITEM_NO, PO_No, Release_Date, Objective, Section, Need_CG_Concerning, ";
            //Sql += " Need_ISO, Need_SCA_Concerning, ";
            //Sql += " Case When Status LIKE 'PD%' Then 1 ";
            //Sql += "      When Status = 'RN' Then 2 ";
            //Sql += "      When Status = 'DEL' OR Status = 'PCOMP' Then 9 ";
            //Sql += "      Else 8 End AS List_Level ";
            //Sql += " 0 AS List_Level";
            //Sql += " FROM PRHeaders ";
            //Sql += $" WHERE Id IN (SELECT DISTINCT PrHeadersId FROM dbo.PRItems WHERE (Purchasing_Staff_Id = {userId})) ";
            //Sql += " Order by List_Level ";
            //var x = await _context.PrLists.FromSqlRaw(Sql).ToListAsync();

            Sql = "SELECT *  FROM VPRHeaders ";
            Sql += $" WHERE Id IN (SELECT DISTINCT PrHeadersId FROM dbo.PRItems WHERE (Purchasing_Staff_Id = {userId})) ";
            var prhs = await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
            List<PrListModel> prls = new List<PrListModel>();
            int ListLevel;
            foreach (var prh in prhs)
            {
                ListLevel = 8;
                if (prh.Status.StartsWith("PD"))
                {
                    ListLevel = 1;
                }
                else
                {
                    switch (prh.Status)
                    {
                        case "RN":
                            ListLevel = 2;
                            break;
                        case "DEL":
                        case "PCOMP":
                            ListLevel = 9;
                            break;
                        default:
                            break;
                    }
                }
                prls.Add(MapPrHeaderToPrlist(prh,ListLevel));
            }
            return prls;
        }

        public async Task<List<VPrList>> GetVPrListAsync(int UserId)
        {
            // สำหรับ แต่ละ user อาจอยู่หลายบริษัท หลาย dep, sec
            var wfa = await GetWorkflowAuthosAsync(UserId);
            var wfadis = wfa
                       .Select(o => new { o.Org, o.Dep, o.Sec })
                       .Distinct();

            // เลือก prlist เฉพาะที่ ตัวเองเกี่ยวข้อง
            List<VPrList> returnList = new List<VPrList>();
            foreach (var item in wfadis)
            {
                var thisList = await _context.vPrLists.Where(x => x.Company == item.Org
                && x.Department == item.Dep && x.Section == item.Sec).ToListAsync();
                returnList.AddRange(thisList);
            }
            return returnList;
        }

        public async Task<List<VPrList>> GetVPrListsPurchasingStaffAsync(int UserId,string myPD)
        {
            return await _context.vPrLists.Where(x => x.Purchasing_Staff_Id == UserId && x.Status == myPD).ToListAsync();
        }
        public async Task<List<VPrList>> GetVPrListsStatusAsync(string status)
        {
            return await _context.vPrLists.Where(x => x.Status == status).ToListAsync();
        }
        public async Task<List<vPRHeader>> GetVPrHeadersPurchasingStaffAsync(int UserId)
        {
            var prLists = await _context.vPrLists.Where(x => x.Purchasing_Staff_Id == UserId).Select(x => x.Id).ToListAsync();
            return await _context.vPRHeaders.Where(x => prLists.Contains(x.Id)).ToListAsync();
        }

        public async Task<vPRHeader> GetvPrHeaderAsync(int Id)
        {
            var y = await _context.vPRHeaders.Where(x => x.Id == Id).FirstOrDefaultAsync();
            //await _context.Entry(y).ReloadAsync();
            return y;
        }

        public async Task<List<vPRHeader>> GetvPrHeaderAsync(string Requester, string FilterStatus)
        {
            if (FilterStatus == "ALL")
            {
                return await _context.vPRHeaders.Where(x => x.Requester == Requester).ToListAsync();
            }
            else
            {
                return await _context.vPRHeaders.Where(x => x.Requester == Requester).Where(x => x.PrStatus == FilterStatus).ToListAsync();
            }
        }
        public async Task<List<vPRHeader>> GetvPrHeadersAsync(string FilterStatus)
        {
            if (FilterStatus == "ALL")
            {
                return await _context.vPRHeaders.ToListAsync();
            }
            else
            {
                return await _context.vPRHeaders.Where(x => x.PrStatus == FilterStatus).ToListAsync();
            }
        }
        public async Task<List<vPRHeader>> GetvPrHeadersPMAsync(string[] purGroup)
        {
            string x = "";
            // Purchasing_Group LIKE ('CH%')
            foreach (var item in purGroup)
            {
                if (x.Length > 1)
                {
                    x += " OR ";
                }
                x += " Purchasing_Group LIKE ('" + item + "%') ";
            }
            string Sql = "SELECT * FROM VPRHeaders WHERE " + x;
            return await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<PRItem>> GetPrItemsAsync(int HeaderId)
        {
            //return await _context.PRItems.Where(x => x.PrHeaders.Id == HeaderId).OrderBy(s => s.Item_No).ToListAsync();
            string Sql = "SELECT * FROM PrItems WHERE PrHeadersId = " + HeaderId + " order by convert(int,Item_No) ";
            return await _context.PRItems.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<PRItem>> GetPrItemsForRnAsync(int rnId)
        {
            string Sql = "SELECT * FROM PrItems WHERE Id in (SELECT Pr_Item_Id FROM rnPrItems WHERE ";
            Sql += " Rn_Id = " + rnId + ") order by Item_no ";
            return await _context.PRItems.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<PRItem>> GetPrItemsPurchaserIdAsync(int userId)
        {
            return await _context.PRItems.Where(x => x.Purchasing_Staff_Id == userId).ToListAsync();
        }

        public async Task<PRItem> GetPrItemAsync(int PrItemId)
        {
            return await _context.PRItems.Where(x => x.Id == PrItemId).FirstOrDefaultAsync();
        }

        public async Task UpdatePRItemAsync(PRItem prItem)
        {
            _context.PRItems.Update(prItem);
            await _context.SaveChangesAsync();
        }

        //===== PR =====
        public async Task SetPrStatus(vPRHeader vprHeader, string Status)
        {
            PRHeader prHeader;
            prHeader = await GetPrHeaderAsync(vprHeader.Id);
            prHeader.Status = Status;
            await UpdatePrHeaderAsync(prHeader);
        }
        public async Task SetPrStatus(PRHeader prHeader, string Status)
        {
            prHeader.Status = Status;
            await UpdatePrHeaderAsync(prHeader);
        }

        public async Task SetPrStatus(int prHeaderId, string Status)
        {
            PRHeader pRHeader = await GetPrHeaderAsync(prHeaderId);
            await SetPrStatus(pRHeader, Status);
        }

        public async Task ReAssingStaff(int prHeaderId)
        {
            PRHeader pRHeader = await GetPrHeaderAsync(prHeaderId);

            string oldPG = pRHeader.Status;

            if (pRHeader.Location == "HO")
            {
                pRHeader.Location = "PLANT";
                pRHeader.Status = "PDRY";
            }
            else
            {
                pRHeader.Location = "HO";
                pRHeader.Status = "PDHO";
            }

            var prGroup = await _context.Master_PurGroup.Where(x => x.Plant == pRHeader.Plant && x.Location == pRHeader.Location).FirstOrDefaultAsync();
            pRHeader.Purchasing_Group = prGroup.PurGroup;
            _context.PRHeaders.Update(pRHeader);

            var appRole = await _context.Approval_Flows.Where(x => x.Pr_id == prHeaderId && x.Approver_role == oldPG).FirstOrDefaultAsync();
            if (null != appRole)
            {
                appRole.Approver_role = (oldPG == "PDHO") ? "PDRY" : "PDHO";
                appRole.Status = "N";
                _context.Approval_Flows.Update(appRole);
            }

            await _context.SaveChangesAsync();
        }
    }
}
