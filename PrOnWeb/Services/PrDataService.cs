using Microsoft.EntityFrameworkCore;
using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Threading.Tasks;

namespace PrOnWeb.Services
{
    public class PrDataService
    {
        ApplicationDbContext _context;
        public PrDataService(ApplicationDbContext context)
        {
            _context = context;
        }

        // filter workflow autho of a user
        public async Task<List<WorkflowAutho>> GetWorkflowAuthosAsync(int userId)
        {
            return await _context.WorkflowAuthos.Where(x => x.User_Id == userId).ToListAsync();
        }
        public async Task<List<ListOfString>> GetOListFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT Org AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            return await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<ListOfString>> GetODSListFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT Org +'-' + Dep + '-' + Sec  AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            return await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<string>> GetAllODSsAsync()
        {
            string Sql = $"SELECT Org + '-' + Dep + '-' + Sec AS StringValue FROM WorkflowAuthos where [Dep] is not null and [Sec] is not null and [Org] is not null ";
            var los = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            return los.Select(x => x.StringValue).Distinct().OrderBy(y => y).ToList();
        }
        public async Task<List<WorkflowAutho>> GetAllODSsAsync(string oDS)
        {
            string Sql = "SELECT cast(ROW_NUMBER() over(order by (AspnetUsers.UserName)) AS int) AS Id, 0 AS User_Id, AspNetUsers.UserName AS Org, AspNetRoles.Name AS Dep, '' AS Sec, ";
            Sql += " Wf_Order, WorkflowAuthos.BudgetRange1, WorkflowAuthos.BudgetRange2, WorkflowAuthos.BudgetRange3, ";
            Sql += " WorkflowAuthos.BudgetRange4, WorkflowAuthos.BudgetRange5, CAST(0 AS BIT) AS IsSm, CAST(0 AS BIT) AS IsDm, CAST(0 AS BIT) AS IsAccount, ";
            Sql += " CAST(0 AS BIT) AS IsCoSign, CAST(0 AS BIT) AS IsPsMember, CAST(0 AS BIT) AS IsPhMember, CAST(0 AS BIT) AS IsRequester, CAST(0 AS BIT) AS IsPM ";
            Sql += " FROM AspNetRoles INNER JOIN ";
            Sql += "                      AspNetUserRoles ON AspNetRoles.Id = AspNetUserRoles.RoleId INNER JOIN ";
            Sql += "                      AspNetUsers ON AspNetUserRoles.UserId = AspNetUsers.Id INNER JOIN ";
            Sql += "                      WorkflowAuthos ON AspNetUsers.PrUserId = WorkflowAuthos.User_Id ";
            Sql += $"WHERE(WorkflowAuthos.Org + '-' + WorkflowAuthos.Dep + '-' + WorkflowAuthos.Sec = '{oDS}') ";
            var x = await _context.WorkflowAuthos.FromSqlRaw(Sql).ToListAsync();
            foreach (var item in x)
            {
                _context.Entry(item).State = EntityState.Detached;
            }
            return await _context.WorkflowAuthos.FromSqlRaw(Sql).ToListAsync();

        }
        public async Task<string> GetODSsFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT '''' + Org +'-' + Dep + '-' + Sec + '''' AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            var odss = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            string returnResult = "";
            foreach (var item in odss)
            {
                returnResult += (returnResult.Length == 0 ? "" : ",") + item.StringValue;
            }
            return returnResult;
        }
        public async Task<List<ListOfString>> GetODListFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT Org +'-' + Dep  AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            return await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<string> GetODsFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT '''' + Org +'-' + Dep + '''' AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            var odss = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            string returnResult = "";
            foreach (var item in odss)
            {
                returnResult += (returnResult.Length == 0 ? "" : ",") + item.StringValue;
            }
            return returnResult;
        }
        public async Task<string> GetCompaniesFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT '''' + Org + '''' AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            var odss = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            string returnResult = "";
            foreach (var item in odss)
            {
                returnResult += (returnResult.Length == 0 ? "" : ",") + item.StringValue;
            }
            return returnResult;
        }

        public async Task<string> GetDepartmentFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT '''' + Dep + '''' AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            var odss = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            string returnResult = "";
            foreach (var item in odss)
            {
                returnResult += (returnResult.Length == 0 ? "" : ",") + item.StringValue;
            }
            return returnResult;
        }
        public async Task<List<ListOfString>> GetCompanyListFromUserIdAsync(int userId)
        {
            string Sql = $"SELECT DISTINCT '' + Org + '' AS StringValue FROM WorkflowAuthos where User_Id = {userId}";
            return await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();

        }

        public async Task<List<vWorkflowAuthoName>> GetUserWorkflowAuthoNameAsync(string GroupOf)
        {
            switch (GroupOf)
            {
                case "isPH":
                    return await _context.vWorkflowAuthoNames.Where(x => x.IsPhMember == true).ToListAsync();
                case "isPS":
                    return await _context.vWorkflowAuthoNames.Where(x => x.IsPsMember == true).ToListAsync();
                default:
                    break;
            }
            return await _context.vWorkflowAuthoNames.ToListAsync();
        }
        public async Task CreateWorkflowAuthoAsync(WorkflowAutho workflowAutho)
        {
            try
            {
                _context.WorkflowAuthos.Add(workflowAutho);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var x = e.Message;
            }
        }
        public async Task DeleteWorkflowAuthoAsync(WorkflowAutho workflowAutho)
        {
            _context.WorkflowAuthos.Remove(workflowAutho);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateWorkflowAsync(WorkflowAutho workflowAutho)
        {
            try
            {
                _context.WorkflowAuthos.Update(workflowAutho);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                var x = e.Message;
            }
        }
        // BUDGET RANGES
        public async Task<List<BudgetRange>> GetBudgetRangeAsync()
        {
            return await _context.BudgetRanges.ToListAsync();
        }
        public async Task UpdateBudgetRangeAsync(BudgetRange br)
        {
            try
            {
                var existBr = _context.BudgetRanges.Where(x => x.Id == br.Id).FirstOrDefault();
                existBr.Range_Amount = br.Range_Amount;
                existBr.Range_Name = br.Range_Name;
                existBr.Range_Oper = br.Range_Oper;
                _context.BudgetRanges.Update(existBr);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public async Task<List<UserTable>> GetUserTablesAsync()
        {
            List<UserTable> userTables = null;
            try
            {
                userTables = await _context.UserTables.ToListAsync();
            }
            catch (Exception e)
            {
                var x = e.Message;
            }
            return userTables;
        }
        public async Task DeleteUserTableAsync()
        {
            string Sql = "DELETE FROM UserTables";
            _ = await _context.Database.ExecuteSqlRawAsync(Sql);
        }

        public async Task<List<vWorkflowAutho>> GetVWorkflowAuthosAsync()
        {
            return await _context.vWorkflowAutho.ToListAsync();
        }
        public async Task<List<vWorkflowAuthoOrder>> GetVWorkflowAuthoOrdersAsync(string oDS)
        {
            string Sql = "SELECT TOP 1000 WorkflowAuthos.Id ";
            Sql += "      ,[User_Id] ";
            Sql += "      , AspNetUsers.UserName AS UserName ";
            Sql += "      ,[Wf_Order] ";
            Sql += "      , case when wf_order = 1 THEN 'SM' ";
            Sql += "            when wf_order = 2 THEN 'DM' ";
            Sql += "            when wf_order = 3 THEN 'TA' ";
            Sql += "            when wf_order = 4 THEN 'GM' ";
            Sql += "            when wf_order = 5 THEN 'PM' ";
            Sql += "            when wf_order = 6 THEN 'VP' ";
            Sql += "            when wf_order = 7 THEN 'PRS' ";
            Sql += "        end AS Position ";
            Sql += "      , case when [BudgetRange1] = 1 THEN 'O' ELSE '' END AS BR1 ";
            Sql += "      , case when [BudgetRange2] = 1 THEN 'O' ELSE '' END AS BR2 ";
            Sql += "      , case when [BudgetRange3] = 1 THEN 'O' ELSE '' END AS BR3 ";
            Sql += "      , case when [BudgetRange4] = 1 THEN 'O' ELSE '' END AS BR4 ";
            Sql += "      , case when [BudgetRange5] = 1 THEN 'O' ELSE '' END AS BR5 ";
            Sql += "  FROM [WorkflowAuthos] INNER JOIN ";
            Sql += "                      AspNetUsers ON WorkflowAuthos.User_Id = AspNetUsers.PrUserId ";
            Sql += $" WHERE(WorkflowAuthos.Org + '-' + WorkflowAuthos.Dep + '-' + WorkflowAuthos.Sec = '{oDS}') ";
            Sql += "   and Wf_Order > 0 order by Wf_order ";
            return await _context.VWorkflowAuthoOrders.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<UserTable> GetOneUserAsync(int UserID)
        {
            UserTable userTable = null;
            try
            {
                userTable = await _context.UserTables.Where(x => x.Pr_User_Id == UserID).SingleOrDefaultAsync();
            }
            catch (Exception e)
            {
                var x = e.Message;

            }
            return userTable;
        }

        public async Task<UserTable> GetUserTableFromUserIdAsync(int userId)
        {
            return await _context.UserTables.Where(x => x.Pr_User_Id == userId).FirstOrDefaultAsync();
        }
        //public async Task<List<UserTable>> GetUserTablesFromRoleIdAsync(int RoleId)
        //{
        //    return await _context.UserTables.Where(x => x.Pr_User_Id == userId).SingleAsync();
        //}
        public async Task<UserTable> GetUserTableFromUseNameAsync(string UserName)
        {
            return await _context.UserTables.Where(x => x.UserName == UserName).SingleOrDefaultAsync();
        }

        //===== MEMO =====
        public async Task<List<PrMemo>> GetPrMemoAsync(int prNo)
        {
            return await _context.prMemos.Where(x => x.PrID == prNo).OrderBy(y => y.MemoWhen).ToListAsync();
        }
        public async Task<List<vPrMemo>> GetvPrMemoAsync(int prNo)
        {
            return await _context.vPrMemo.Where(x => x.PrID == prNo).OrderBy(x=>x.MemoWhen).ToListAsync();
        }
        public async Task InsertPrMemoAsync(PrMemo prMemo)
        {
            _context.prMemos.Add(prMemo);
            await _context.SaveChangesAsync();
        }
        public async Task InsertvPrMemoAsync(vPrMemo prMemo)
        {
            PrMemo _prMemo = new PrMemo();
            _prMemo.Id = prMemo.Id;
            _prMemo.PrID = prMemo.PrID;
            _prMemo.MemoMsg = prMemo.MemoMsg;
            _prMemo.MemoWhen = prMemo.MemoWhen;
            _prMemo.MemoWhoID = prMemo.MemoWhoID;

            _context.prMemos.Add(_prMemo);
            await _context.SaveChangesAsync();
        }

        //===== UPLOAD =====
        public async Task<int> InsertUploadFileAsync(UploadFile uploadFile)
        {
            _context.uploadFiles.Add(uploadFile);
            await _context.SaveChangesAsync();
            return uploadFile.Id;
        }

        public async Task<string> DeleteUploadAttachAsync(int attachId)
        {
            var thisAttach = await _context.uploadFiles.Where(x => x.Id == attachId).FirstAsync();
            if (thisAttach != null)
            {
                string AttachFilename = thisAttach.Id.ToString() + "_" + thisAttach.Filename;
                _context.Remove(thisAttach);
                await _context.SaveChangesAsync();
                return AttachFilename;
            }
            else
                return "";
        }



        //===== APPROVAL FLOW =====
        public async Task<Approval_flow> GetApprovalFlowFromIdAsync(int Id)
        {
            return await _context.Approval_Flows.Where(x => x.Id == Id).FirstAsync();
        }
        public async Task<List<Approval_flow>> GetApprovalFlowsFromPrIdAsync(int prId)
        {
            return await _context.Approval_Flows.Where(x => x.Pr_id == prId).ToListAsync();
        }
        public async Task<int> GetApprovalFlowPrOwnerAsync(int prId)
        {
            var af = await _context.Approval_Flows.Where(x => x.Pr_id == prId && x.Wf_order == 0).FirstOrDefaultAsync();
            if (af == null)
            {
                return 0;
            }
            else
                return af.Approver_id;
        }
        public async Task<List<Approval_flow>> GetApprovalFlowAsync(int PrItemId)
        {
            return await _context.Approval_Flows.Where(x => x.Pr_item_id == PrItemId && x.Af_Version == 0).ToListAsync();
        }
        public async Task<List<Approval_flow>> GetApprovalFlowUserIdAsync(int UserId, string Status)
        {
            return await _context.Approval_Flows.Where(x => x.Approver_id == UserId && x.Status == Status).ToListAsync();
        }
        public async Task<List<vApproval_flow>> GetvApprovalFlowForUserIdAsync(int UserId, string Status)
        {
            return await _context.vApproval_Flows.Where(x => x.Approver_id == UserId
                    && x.Status == Status
                    && x.Af_Version == 0).ToListAsync();
        }
        public async Task<List<vApproval_flow>> GetvApprovalFlowForUserIdAsync(int UserId)
        {
            return await _context.vApproval_Flows.Where(x => x.Approver_id == UserId && x.Af_Version == 0 && !x.Is_disabled).ToListAsync();
        }
        public async Task<Approval_flow> GetApprovalFlowForUserIdFirstAsync(int UserId)
        {
            return await _context.Approval_Flows.Where(x => x.Approver_id == UserId && x.Af_Version == 0).FirstOrDefaultAsync();
        }

        public async Task<List<Approval_flow>> GetApprovalFlowPrHeadAsync(int PrId, int afVersion = 0)
        {
            return await _context.Approval_Flows.Where(x => x.Pr_id == PrId && x.Af_Version == afVersion).ToListAsync();
        }
        public async Task<List<vApproval_flow>> GetvApprovalFlowPrHeadAsync(int PrId, int afVersion = 0)
        {
            var x = await _context.vApproval_Flows.Where(x => x.Pr_id == PrId && x.Af_Version == afVersion)
                .OrderBy(x => x.Wf_order).ToListAsync();
            foreach (var item in x)
            {
                _context.Entry(item).State = EntityState.Detached;
            }
            return await _context.vApproval_Flows.Where(x => x.Pr_id == PrId && x.Af_Version == afVersion)
                .OrderBy(x => x.Wf_order).ToListAsync();
        }
        public async Task<List<vApproval_flow>> GetvApprovalFlowForStatusAsync(string role, string prStatus)
        {
            return await _context.vApproval_Flows.Where(x => x.Approver_role == role
                    && x.Status == prStatus && x.Af_Version == 0).ToListAsync();
        }
        public async Task<List<vApproval_flow>> GetvApprovalFlowForStatusActiveAsync(string role, string prStatus)
        {
            return await _context.vApproval_Flows.Where(x => x.Approver_role == role
                    && x.Status == prStatus && x.Is_disabled == false && x.Af_Version == 0).ToListAsync();
        }

        public async Task<List<Approval_flow>> GetApprovalFlowForRoleAsync(string Role)
        {
            return await _context.Approval_Flows.Where(x => x.Approver_role == Role &&
                x.Status == "N" && x.Is_disabled == false && x.Af_Version == 0)
                .ToListAsync();
        }
        // 
        public async Task UpdateApprovalFlowAsync(Approval_flow approval_Flow)
        {
            _context.Approval_Flows.Update(approval_Flow);
            await _context.SaveChangesAsync();
        }
        // Disable Approval_Flow โดยการเปลี่ยน af_version ให้ > 0
        public async Task UpdateDisableApprovalFlowAsync(int prId, int afVersion = 0)
        {
            var maxAf = await _context.Approval_Flows.Where(x => x.Pr_id == prId).OrderByDescending(x => x.Af_Version).FirstOrDefaultAsync();
            int? newVer = 1;
            if (maxAf != null)
            {
                newVer = maxAf.Af_Version + 1;
            }
            // Af ล่าสุด
            var curAfs = await _context.Approval_Flows.Where(x => x.Pr_id == prId && x.Af_Version == afVersion).ToListAsync();
            foreach (var item in curAfs)
            {
                item.Af_Version = newVer;
                _context.Approval_Flows.Update(item);
                await _context.SaveChangesAsync();
            }
        }
        // 
        public async Task<int> UpdateApprovalFlowEnableNext(Approval_flow approval_Flow, int afVersion = 0)
        {
            // รายการนี้ Approve แล้ว
            approval_Flow.Is_disabled = true;
            _context.Approval_Flows.Update(approval_Flow);
            await _context.SaveChangesAsync();

            // ไปรายการต่อ
            var PrID = approval_Flow.Pr_id;
            var WfStep = approval_Flow.Wf_order; // + 1;
            Approval_flow nextApproval_flow;
            string nextApproverRole;
            int ApprovalFlowId;

            nextApproval_flow = await _context.Approval_Flows
                .Where(x => x.Pr_id == PrID && x.Wf_order > WfStep && x.Af_Version == afVersion)
                .OrderBy(x => x.Wf_order)
                .FirstOrDefaultAsync();
            if (nextApproval_flow != null)
            {
                nextApproval_flow.When_init = DateTime.Now;
                nextApproval_flow.Is_disabled = false;
                _context.Approval_Flows.Update(nextApproval_flow);
                await _context.SaveChangesAsync();
                nextApproverRole = nextApproval_flow.Approver_role;
                ApprovalFlowId = nextApproval_flow.Id;
            }
            else // approve ครบแล้ว กลับไป caller เพื่อหา PD
            {
                nextApproverRole = "END";
                ApprovalFlowId = 0;
            }
            return ApprovalFlowId;
        }
        public async Task GenerateApprovalFlowHeadx(vPRHeader prHeader,
            string ApproverRole,
            int UserId,
            int UserGrpId,
            string Status,
            int WfOrder,
            Boolean isDisable)
        {
            // PrHead/ PrItem
            // 1.Role C, AppGrpID, Status = N(ยังไม่ Appr), When = Now(เวลาที่ assign)
            // 2.Role A, AppGrpID, Status = N(ยังไม่ Appr), When = Now(เวลาที่ assign)
            var NewApprovalFlow = new Approval_flow
            {
                Pr_id = prHeader.Id,
                Pr_item_id = 0,
                Approver_role = ApproverRole,
                Approver_id = UserId,
                Approver_group_id = UserGrpId,
                When_init = DateTime.Now,
                When_end = DateTime.Now,
                Status = Status,
                Is_disabled = isDisable,
                Wf_order = WfOrder,
                Af_Version = 0
            };
            _context.Approval_Flows.Add(NewApprovalFlow);
            await _context.SaveChangesAsync();
        }
        public async Task GenerateApprovalFlow(int PrId, int PrItemId,
            string ApproverRole,
            int UserId,
            int UserGrpId,
            string Status,
            int WfOrder,
            Boolean isDisable,
            int afVersion = 0)
        {
            // PrHead/ PrItem
            // 1.Role C, AppGrpID, Status = N(ยังไม่ Appr), When = Now(เวลาที่ assign)
            // 2.Role A, AppGrpID, Status = N(ยังไม่ Appr), When = Now(เวลาที่ assign)
            var NewApprovalFlow = new Approval_flow
            {
                Pr_id = PrId,
                Pr_item_id = PrItemId,
                Approver_role = ApproverRole,
                Approver_id = UserId,
                Approver_group_id = UserGrpId,
                When_init = DateTime.Now,
                When_end = DateTime.Now,
                Status = Status,
                Is_disabled = isDisable,
                Wf_order = WfOrder,
                Af_Version = afVersion
            };
            _context.Approval_Flows.Add(NewApprovalFlow);
            await _context.SaveChangesAsync();
        }
        public async Task<int> GetNextPrUserId()
        {
            string Sql = "SELECT max(Cast(PrUserId as Int)) as UserId FROM AspNetUsers ";
            var userIds = await _context.prUserIds.FromSqlRaw(Sql).FirstOrDefaultAsync();
            return userIds.UserId + 1;
        }
        //public async Task<int> GetSmDmUserId(int PrId, Boolean isSM)
        //{
        //    PRHeader prHeader = await GetPrHeaderAsync(PrId);
        //    return await GetSmDmUserId(prHeader, isSM);
        //}
        public async Task<int> GetSmDmUserId(PRHeader prHeader, Boolean isSM)
        {
            WorkflowAutho workflowAutho;
            if (isSM)
            {
                workflowAutho = await _context.WorkflowAuthos.Where(x => x.Org == prHeader.Company
                    && x.Dep == prHeader.Department
                    && x.IsSm).SingleAsync();
            }
            else
            {
                workflowAutho = await _context.WorkflowAuthos.Where(x => x.Org == prHeader.Company
                    && x.Dep == prHeader.Department
                    && x.IsDm).SingleAsync();
            }
            return workflowAutho.User_Id;
        }

        public async Task<List<vWorkflowAutho>> GetvWorkflowAuthoAsync(vPRHeader vPRHeader, string BGRange)
        {
            //string Sql = "SELECT a.Id, a.User_Id, b.UserName, '' AS Position, a.Org, a.Dep, a.Sec, a.Wf_Order, b.Email ";
            //Sql += "FROM WorkflowAuthos AS a INNER JOIN AspNetUsers AS b ON a.User_Id = b.PrUserId ";
            //Sql += "WHERE (a.Org = '" + vPRHeader.Company + "') AND (a.Dep = '" + vPRHeader.Department + "') AND (a.Sec = '" + vPRHeader.Section + "') ";
            //Sql += " AND (a." + BGRange + " = 1) ";
            //Sql += " ORDER BY a.Wf_Order";

            //string Sql = "";
            //Sql += " SELECT a.Id, a.User_Id, b.UserName, '' AS Position, a.Org, a.Dep, a.Sec, ";
            //Sql += " 5 - ((((BudgetRange1 * 1 + BudgetRange2 * 1) + BudgetRange3 * 1) +";
            //Sql += " BudgetRange4 * 1) + BudgetRange5 * 1) AS Wf_Order, b.Email";
            //Sql += " FROM WorkflowAuthos AS a INNER JOIN AspNetUsers AS b ON a.User_Id = b.PrUserId";
            //Sql += " WHERE(a.Org = '" + vPRHeader.Company + "') AND(a.Dep = '" + vPRHeader.Department + "') AND(a.Sec = '" + vPRHeader.Section + "') ";
            //Sql += " AND(a." + BGRange + " = 1)";
            //Sql += " ORDER BY(((BudgetRange1* 1 + BudgetRange2 * 1) +BudgetRange3 * 1) + BudgetRange4 * 1) +BudgetRange5 * 1 DESC";

            string Sql = "";
            Sql += " SELECT a.Id, a.User_Id, b.UserName, '' AS Position, a.Org, a.Dep, a.Sec, Wf_Order, b.Email ";
            Sql += " FROM WorkflowAuthos AS a INNER JOIN AspNetUsers AS b ON a.User_Id = b.PrUserId";
            Sql += " WHERE(a.Org = '" + vPRHeader.Company + "') AND(a.Dep = '" + vPRHeader.Department + "') AND(a.Sec = '" + vPRHeader.Section + "') ";
            Sql += " AND(a." + BGRange + " = 1)";
            Sql += " ORDER BY(((BudgetRange1* 1 + BudgetRange2 * 1) +BudgetRange3 * 1) + BudgetRange4 * 1) +BudgetRange5 * 1 DESC";

            return await _context.vWorkflowAutho.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<vPRHeader>> GetPrHeadersPendingForUserIdAsync(int userId)
        {
            string Sql = "SELECT * FROM vPrHeaders WHERE (Id IN (SELECT Pr_id FROM Approval_Flows WHERE ";
            Sql += "(Approver_id = " + userId + ") AND(Status = 'N' OR Status = 'M')))";
            return await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<vPRHeader>> GetPrHeadersFromStatusAsync(int userID, string status)
        {
            string Sql;
            Sql = " SELECT * FROM dbo.VPRHeaders WHERE(Id IN ";
            Sql += "  (SELECT Id FROM dbo.PRHeaders AS PRHeaders_1 ";
            Sql += "     WHERE((Company + '-' + Department + '-' + Section) IN ";
            Sql += "      (SELECT Org + '-' + Dep + '-' + Sec AS ODS FROM dbo.WorkflowAuthos ";
            Sql += "        WHERE(User_Id = " + userID + "))) AND(ISNULL(Status, N'NEW') IN ";
            Sql += "             (" + status + "))))";
            return await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<vPRHeader>> GetVPRHeaderForReqRNAsync(int userID, string status)
        {
            string Sql;
            Sql = " SELECT b.Rn_Status_Name, a.Id, a.Company, a.Purchasing_Group, a.Pr_Date, a.Requester, ";
            Sql += " a.Plant, a.Tracking_No, a.Purchasing_Org, a.Department, a.Pr_No, a.Create_Date, ";
            Sql += " a.Print_Status, a.Status, a.PO_DATE, a.PO_ITEM_NO, a.PO_No, a.Release_Date, ";
            Sql += " a.NumberOfItem, a.PrAmt, b.Rn_Status_Name AS PrStatus, a.sPrAmt, a.Section, a.Objective, ";
            Sql += " a.Need_CG_Concerning, a.Need_ISO, a.Need_SCA_Concerning , a.Comment , a.CoSign_Group, a.Pr_Urgent ";
            //Sql = " SELECT a.*, b.Rn_Status_Name, b.Rn_Status_Name AS PrStatus a.Id, a.Company, a.Purchasing_Group, a.Pr_Date, a.Requester, ";
            Sql += " FROM vPrHeaders AS a INNER JOIN VReturningNotes AS b ON a.Id = b.Pr_Id ";
            Sql += $" WHERE (a.Status = N'RN')  AND b.Rn_Status IN ( {status} ) AND (a.Id IN ";
            Sql += "	(SELECT c.Id  ";
            Sql += "	 FROM Approval_Flows INNER JOIN vPrHeaders AS c ";
            Sql += "		ON Approval_Flows.Pr_id = c.Id ";
            Sql += $"		WHERE (Approval_Flows.Approver_role = N'CREATOR') AND (Approval_Flows.Approver_id = {userID})))";
            return await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
        }
        // 
        public async Task<List<vPRHeader>> GetVPrHeadersMyStatusAsync(int userId, string status)
        {
            string Sql;
            Sql = " SELECT a.* FROM Approval_Flows INNER JOIN vPrHeaders AS a ON Approval_Flows.Pr_id = a.Id ";
            Sql += $" WHERE (Approval_Flows.Approver_role = N'CREATOR') AND (Approval_Flows.Approver_id = {userId}) ";
            Sql += $" AND (ISNULL(a.Status, N'NEW') IN ({status}))";
            return await _context.vPRHeaders.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<UploadFile>> GetUploadFileItemListAsync(int docType, int PrItemId)
        {
            return await _context.uploadFiles.Where(x => x.Upload_Type == docType
                && x.Document_id == PrItemId).ToListAsync();
        }
        public async Task<List<UploadFile>> GetUploadFileListAsync(int docType, int prId)
        {
            return await _context.uploadFiles.Where(x => x.Upload_Type == docType
                && x.Document_id == prId).ToListAsync();
        }
        //Returning Note
        public async Task<List<ReturningNote>> GetRnListAsync()
        {
            return await _context.ReturningNotes.ToListAsync();
        }
        public async Task<List<VReturningNote>> GetVRnListFromUserIdAsync(int userId)
        {
            return await _context.VReturningNotes.Where(x => x.Rn_By_Id == userId).ToListAsync();
        }
        public async Task<List<VReturningNote>> GetVRnListForManagerAsync(string pd)
        {
            string Sql;
            Sql = "SELECT * FROM VReturningNotes WHERE Pr_Id in ( ";
            Sql += $" SELECT DISTINCT Pr_id FROM vApproval_Flows WHERE Approver_role LIKE '{pd}' AND Af_Version = 0)";
            return await _context.VReturningNotes.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<VReturningNote>> GetVRnListFromUserIdStatusAsync(int userId, string statuses)
        {
            string Sql;
            Sql = $" SELECT* FROM VReturningNotes WHERE Rn_Status in ({statuses}) and Rn_By_Id LIKE '{userId}' ";
            return await _context.VReturningNotes.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<ReturningNote>> GetRnListFromPrIdAsync(int prId)
        {
            return await _context.ReturningNotes.Where(x => x.Pr_Id == prId).ToListAsync();
        }
        public async Task<ReturningNote> GetReturningNoteAsync(int RnId)
        {
            return await _context.ReturningNotes.Where(x => x.Id == RnId).FirstOrDefaultAsync();
        }
        public async Task<ReturningNote> GetReturningNoteFromPRAsync(int prId)
        {
            return await _context.ReturningNotes.Where(x => x.Pr_Id == prId && x.Rn_Status == "WAIT").FirstOrDefaultAsync();
        }
        public async Task<ReturningNote> GetReturningNoteFromItemAsync(int ItemId)
        {
            var y = await _context.rnPrItems.Where(x => x.Pr_Item_Id == ItemId).FirstOrDefaultAsync();
            if (y != null)
            {
                return await _context.ReturningNotes.Where(x => x.Id == y.Rn_Id).FirstOrDefaultAsync();
            }
            else
                return null;
        }
        public async Task UpdateRnAsync(ReturningNote rnUpdate)
        {
            _context.ReturningNotes.Update(rnUpdate);
            await _context.SaveChangesAsync();
        }
        public async Task CreateRnPrItemIdBridgeAync(int rnId, int prItemId)
        {
            string Sql = "INSERT INTO rnPrItems VALUES (" + rnId + ", " + prItemId + ")";
            _ = await _context.Database.ExecuteSqlRawAsync(Sql);
        }
        public async Task DeleteRnPrItemIdBridgeAync(int rnId)
        {
            string Sql = "DELETE FROM rnPrItems WHERE Rn_Id = " + rnId;
            _ = await _context.Database.ExecuteSqlRawAsync(Sql);
            //await _context.Database.ExecuteSqlRawAsync("DELETE FROM rnPrItems WHERE Rn_Id = {0}",rnId);
        }

        public async Task<int> CreateRnAsync(ReturningNote rnNew)
        {
            // Gen Rn Id : RNYY-rrrrr
            var Y = "RN" + (rnNew.Rn_When ?? DateTime.Now).ToString("yy");
            string Sql = "Select Top 1 * from ReturningNotes WHERE left(Rn_Id,4)= '" + Y;
            Sql += "' order by RIGHT(Rn_Id, 5) Desc";
            string NewId = Y + "-00001"; // ใบแรกของปีใหม่
            var X = await _context.ReturningNotes.FromSqlRaw(Sql).FirstOrDefaultAsync();
            if (X != null)
            {
                var Z = Int16.Parse(X.Rn_Id.Substring(X.Rn_Id.Length - 5, 5)) + 1;
                NewId = Y + "-" + Z.ToString("00000");
            }

            rnNew.Rn_Id = NewId;
            _context.ReturningNotes.Add(rnNew);
            await _context.SaveChangesAsync();
            return rnNew.Id;
        }
        public async Task<List<Master_Rn_Reason>> GetRnReason()
        {
            return await _context.Master_Rn_Reasons.ToListAsync();
        }
        public async Task<List<Master_Rn_Type>> GetRnType()
        {
            return await _context.Master_Rn_Types.ToListAsync();
        }
        //public async Task<List<Master_Role>> GetMasterRolesAsync()
        //{
        //    return await _context.Master_Roles.ToListAsync();
        //}
        //public async Task AddRoleToUserAsync(UserTable ThisUser, int RoleId)
        //{
        //    string Sql = "INSERT INTO UsersRoles VALUES (" + ThisUser.Pr_User_Id + "," + RoleId + ")";
        //    await _context.Database.ExecuteSqlCommandAsync(Sql);
        //}
        //public async Task RemoveRoleFromUserAsync(UserTable ThisUser, int RoleId)
        //{
        //    string Sql = "DELETE FROM UsersRoles WHERE (User_Id = " + ThisUser.Pr_User_Id + ") AND (Role_Id = " + RoleId + ")";
        //    await _context.Database.ExecuteSqlCommandAsync(Sql);
        //}
        //public async Task<List<Master_Role>> GetRolesFromUserAsync(int PrUserId)
        //{
        //    string Sql = "Select * From Master_Roles WHERE Id in ";
        //    Sql += " (SELECT Role_Id FROM UsersRoles Where User_Id=" + PrUserId + ")";
        //    return await _context.Master_Roles.FromSqlRaw(Sql).ToListAsync();
        //}
        //public async Task<List<UserTable>> GetUsersFromRoleAsync(int RoleId)
        //{
        //    string Sql = "Select * From UserTables WHERE Id in ";
        //    Sql += " (SELECT User_Id FROM UsersRoles Where Role_Id=" + RoleId + ")";
        //    return await _context.UserTables.FromSqlRaw(Sql).ToListAsync();
        //}

        //public async Task<string> CreateMasterRolesAsync(Master_Role master_Role)
        //{
        //    string result = "";
        //    try
        //    {
        //        _context.Master_Roles.Add(master_Role);
        //        var y = await _context.SaveChangesAsync();
        //        if (y == 1)
        //        {
        //            result = "OK";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        _context.Master_Roles.Remove(master_Role);
        //        result = "ERROR";
        //    }
        //    return result;
        //}
        //public async Task<string> UpdateMasterRolesAsync(Master_Role master_Role)
        //{
        //    string result = "";
        //    try
        //    {
        //        Master_Role thisRole = await _context.Master_Roles.Where(x => x.Id == master_Role.Id).FirstAsync();
        //        if (thisRole != null)
        //        {
        //            thisRole.Role = master_Role.Role;
        //        }
        //        _context.Master_Roles.Update(thisRole);
        //        var x = await _context.SaveChangesAsync();
        //        if (x == 1)
        //        {
        //            result = "OK";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        var x = e.Message;
        //        result = "ERROR";
        //    }
        //    return result;
        //}
        //public async Task<string> DeleteMasterRolesAsync(Master_Role master_Role)
        //{
        //    string result = "";
        //    try
        //    {
        //        Master_Role thisRole = await _context.Master_Roles.Where(x => x.Id == master_Role.Id).FirstAsync();
        //        if (thisRole != null)
        //        {
        //            _context.Master_Roles.Remove(thisRole);
        //            var x = await _context.SaveChangesAsync();
        //            result = "OK";
        //        }
        //        else result = "ERROR";
        //    }
        //    catch (Exception e)
        //    {
        //        var x = e.Message;
        //        result = "ERROR";
        //    }
        //    return result;
        //}

        public async Task<List<Master_Org>> GetMasterOrgsAsync()
        {
            return await _context.Master_Orgs.ToListAsync();
        }
        public async Task UpdateMasterOrgsAsync(Master_Org master_Org)
        {
            try
            {
                Master_Org thisOrg = await _context.Master_Orgs.Where(x => x.Id == master_Org.Id).FirstAsync();
                if (thisOrg != null)
                {
                    thisOrg.Org = master_Org.Org;
                    thisOrg.Org_Name = master_Org.Org_Name;
                    _context.Master_Orgs.Update(thisOrg);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.Master_Orgs.Update(master_Org);
                    await _context.SaveChangesAsync();
                }

            }
            catch (Exception e)
            {
                var x = e.Message;

            }
        }
        public async Task UpdateMasterDepsAsync(Master_Dep master_Dep)
        {
            Master_Dep thisDep = await _context.Master_Deps.Where(x => x.Id == master_Dep.Id).FirstOrDefaultAsync();
            if (thisDep != null)
            {
                thisDep.Dep = master_Dep.Dep;
                thisDep.Dep_Name = master_Dep.Dep_Name;
                _context.Master_Deps.Update(thisDep);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Master_Deps.Update(master_Dep);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateMasterSecsAsync(Master_Sec master_Sec)
        {
            Master_Sec thisSec = await _context.Master_Secs.Where(x => x.Id == master_Sec.Id).FirstOrDefaultAsync();
            if (thisSec != null)
            {
                thisSec.Sec = master_Sec.Sec;
                thisSec.Sec_Name = master_Sec.Sec_Name;
                _context.Master_Secs.Update(thisSec);
                await _context.SaveChangesAsync();
            }
            else
            {
                _context.Master_Secs.Update(master_Sec);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Master_Dep>> GetMasterDepsAsync()
        {
            return await _context.Master_Deps.ToListAsync();
        }
        public async Task<List<Master_Sec>> GetMasterSecsAsync()
        {
            return await _context.Master_Secs.ToListAsync();
        }

        public async Task<List<Master_Unit>> GetUnitAsync()
        {
            return await _context.Master_Unit.ToListAsync();
        }
        public async Task<List<Master_Currency>> GetCurrencyAsync()
        {
            return await _context.Master_Currency.ToListAsync();
        }

        public async Task<List<MasterDimension>> GetMasterDimensionsAsync()
        {
            return await _context.masterDimensions.ToListAsync();
        }
        public async Task<List<MatRegList>> GetMatRegListsAsync()
        {
            return await _context.MatRegLists.ToListAsync();
        }
        public async Task<bool> IsItemCodeInMatListAsync(string itemCode)
        {
            itemCode = itemCode.TrimStart('0');
            var ml = await _context.MatRegLists.Where(x => x.Mat_Code == itemCode).ToListAsync();
            if (ml?.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        public async Task<List<SystemConfiguration>> GetSystemConfigurationsAsync()
        {
            return await _context.systemConfigurations.ToListAsync();
        }
        public async Task<SystemConfiguration> GetSystemConfigurationAsync(string startWith)
        {
            return await _context.systemConfigurations.Where(x => x.ConfigName.StartsWith(startWith)).FirstOrDefaultAsync();
        }
        public async Task<List<SystemConfiguration>> GetSystemConfigurationsAsync(string startstWith)
        {
            return await _context.systemConfigurations.Where(x => x.ConfigName.StartsWith(startstWith)).ToListAsync();
        }

        public async Task UpdateSystemConfigurationsAsync(string name, string value)
        {
            SystemConfiguration systemConfig = await _context.systemConfigurations.Where(x => x.ConfigName == name).FirstOrDefaultAsync();
            _context.systemConfigurations.Remove(systemConfig);
            _context.SaveChanges();

            SystemConfiguration systemConfiguration;
            systemConfiguration = new SystemConfiguration()
            {
                ConfigName = name,
                ConfigValue = value
            };
            _context.systemConfigurations.Add(systemConfiguration);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSystemConfigurationsAsync(string name, List<string> values)
        {
            List<SystemConfiguration> systemConfigs = await _context.systemConfigurations.Where(x => x.ConfigName == name).ToListAsync();
            _context.systemConfigurations.RemoveRange(systemConfigs);
            _context.SaveChanges();
            SystemConfiguration systemConfiguration;
            foreach (var item in values)
            {
                systemConfiguration = new SystemConfiguration()
                {
                    ConfigName = name,
                    ConfigValue = item
                };
                _context.systemConfigurations.AddRange(systemConfiguration);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateSystemConfigurationsAsync(SystemConfiguration systemConfiguration)
        {
            _context.systemConfigurations.Update(systemConfiguration);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Import_Log>> GetImportLogsAsync()
        {
            return await _context.ImportLogs.OrderByDescending(x => x.Id).ToListAsync();
        }

        public async Task<string> GetStatusNameAsync(string statusId)
        {
            var statusRec = await _context.StatusMappings.Where(x => x.Status == statusId).FirstOrDefaultAsync();
            if (statusRec == null)
            {
                return "--";
            }
            else
                return statusRec.Pr_status;
        }

        public async Task<List<PrReportModel>> GetPrReportDeptAsync(string filter, string myCompanies, string myDepartment,string startDate = "", string endDate = "")
        {
            List<PrReportModel> prr = new List<PrReportModel>();
            if (String.IsNullOrEmpty(myCompanies))
            {
                return prr;
            }
            string Sql;
            Sql = "SELECT * FROM VPrReport WHERE 1=1 AND Pr_No NOT LIKE 'L-%'";
            if (!string.IsNullOrEmpty(filter))
            {
                Sql += $" AND Status IN ({filter}) ";
            }

            if (myCompanies != "")
            {
                Sql += $"  AND Company IN ({myCompanies}) ";
            }

            if (myDepartment != "")
            {
                Sql += $"  AND Department IN ({myDepartment}) ";
            }

            if (startDate != "" && endDate != "")
            {
                Sql += $" AND Date_Need between CONVERT(DATETIME,'{startDate}',103) AND CONVERT(DateTime, '{endDate}', 103)";
            }

            //else
            //{
            //    Sql += $" AND Status IN ({filter}) AND Company IN ({myCompanies})";
            //}
            return await _context.PrReportModels.FromSqlRaw(Sql).ToListAsync();
        }

        public async Task<List<PrReportModel>> GetPrReportAsync(string filter, string myCompanies, string startDate = "", string endDate = "")
        {
            List<PrReportModel> prr = new List<PrReportModel>();
            if (String.IsNullOrEmpty(myCompanies))
            {
                return prr;
            }
            string Sql;
            Sql = "SELECT * FROM VPrReport WHERE 1=1 AND Pr_No NOT LIKE 'L-%'";
            if (!string.IsNullOrEmpty(filter))
            {
                Sql += $" AND Status IN ({filter}) ";
            }

            if (myCompanies != "")
            {
                Sql += $"  AND Company IN ({myCompanies}) ";
            }
 
            if (startDate != "" && endDate != "")
            {
                Sql += $" AND Date_Need between CONVERT(DATETIME,'{startDate}',103) AND CONVERT(DateTime, '{endDate}', 103)";
            }

            //else
            //{
            //    Sql += $" AND Status IN ({filter}) AND Company IN ({myCompanies})";
            //}
            return await _context.PrReportModels.FromSqlRaw(Sql).ToListAsync();
        }
        public async Task<List<RnReportModel>> GetRnReportAsync(string filter, string myCompanies,
            string startDate = "", string endDate = "")
        {
            List<RnReportModel> prr = new List<RnReportModel>();
            if (String.IsNullOrEmpty(myCompanies))
            {
                return prr;
            }

            string Sql;
            Sql = "SELECT * FROM VRnReport ";
            if (filter != "")
            {
                Sql += $" WHERE Rn_Status IN ({filter}) AND Company IN ({myCompanies})";
                if (startDate != "" && endDate != "")
                {
                    Sql += $" AND Date_Need between CONVERT(DATETIME,'{startDate}',103) AND CONVERT(DateTime, '{endDate}', 103)";
                }
            }
            return await _context.RnReportModels.FromSqlRaw(Sql).ToListAsync();
        }


        public string GetGetPRGroup(string proj,string loc)
        {
            var ml =   _context.Master_PurGroup.Where(x => x.Plant == proj && x.Location == loc).FirstOrDefault();
            return ml != null ? ml.PurGroup : "";
        }

        public string GetGetCostCenter(string plant, string dept, string sec)
        {
            var ml =   _context.Master_CostCenter.Where(x => x.Plant == plant && x.Dept == dept && x.Sec == sec).FirstOrDefault();
            return ml != null ? ml.CostCenter : "";
        }

        public async Task<List<MatGroupList>> GetMatCodeItem(PRHeader prHeader)
        {
       
            List<MatGroupList> prsr = new List<MatGroupList>();
            if (prHeader != null)
            {
                string Sql =  $" SELECT * FROM [dbo].[vw_cost_center] WHERE Company = '{prHeader.Company}' and Department = '{prHeader.Department}' and Section = '{prHeader.Section}' ";
                prsr = await  _context.MatGroupList.FromSqlRaw(Sql).ToListAsync();
            }

            return   prsr;

        }

        public  MatGroupList GetMatGroup(string mat)
        {

            MatGroupList bdg = new MatGroupList();
            if (String.IsNullOrEmpty(mat))
            {
                return bdg;
            }

            string Sql = $" SELECT* FROM  [vw_master_budget] WHERE Item_Code = '{mat}' ";
            bdg =    _context.MatGroupList.FromSqlRaw(Sql).FirstOrDefault();

            return bdg;

        }


        public string CreatePRData(PRHeader prHeader, List<PRItem> prDetails)
        {
            string result = "";
            try
            {
                prHeader.Purchasing_Org = "CP01";
                prHeader.Pr_Date = DateTime.Now;
                prHeader.Pr_No =   GenPRNoAsync();
                prHeader.Create_Date = DateTime.Now;
                prHeader.Release_Date = DateTime.Now;
                prHeader.Status = "NEW";
                prHeader.Comment = prHeader.Comment == null ? "" : prHeader.Comment;
                prHeader.Objective = prHeader.Objective == null ? "" : prHeader.Objective;
                _context.PRHeaders.Add(prHeader);
                var y = _context.SaveChanges();
                if (y == 1)
                {
                    foreach(var prd in prDetails)
                    {
                        prd.PrHeadersId = prHeader.Id;
                        prd.Price_Unit = 1;
                        prd.Delete_Status = "";
                        prd.Desired_Vendor = "";
                        prd.Requistion_date = DateTime.Now;
                        prd.Item_Code = prd.Item_Code == null ? "" : prd.Item_Code;
                        _context.PRItems.Add(prd);
                    }

                    _context.SaveChanges();

                    result = prHeader.Id.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //_context.Master_Roles.Remove(master_Role);
                result = "ERROR";
            }
            return result;
        }

        public string GenPRNoAsync()
        {
            string Sql = $" WITH RUN_NO as ( " +
           $" SELECT TOP (1)(CAST(SUBSTRING(Pr_No, 8, 4) as int) + 1) as Pr_No from[PRHeaders] where Pr_No like  'PRW' + FORMAT(getdate(), 'yyMM') + '%' " +
           $"   order by Create_Date desc " +
           $"   )  select  'PRW' + FORMAT(getdate(), 'yyMM') + RIGHT(CONCAT('0000', (select ISNULL((select Pr_No from RUN_NO), 1)) ), 4) AS StringValue";

           var odss =  _context.ListOfStrings.FromSqlRaw(Sql).ToList();
            string returnResult = "";
            foreach (var item in odss)
            {
                returnResult = item.StringValue;
                break;
            }
            return returnResult;
        }

        public string UpdatePRData(PRHeader _prHeader, List<PRItem> prDetails)
        {
            string result = "";
            try
            {
                // Save Header 
                var prHeader =  _context.PRHeaders.Where(o => o.Id == _prHeader.Id).FirstOrDefault();
                prHeader.Company = _prHeader.Company ;
                prHeader.Department = _prHeader.Department;
                prHeader.Section = _prHeader.Section;
                prHeader.Plant = _prHeader.Plant;
                prHeader.Location = _prHeader.Location;
                prHeader.Purchasing_Group = _prHeader.Purchasing_Group;
                prHeader.Tracking_No = _prHeader.Tracking_No;
                //prHeader.Pr_Date = _prHeader.Pr_Date;
                prHeader.Pr_Urgent = _prHeader.Pr_Urgent;
                prHeader.Extension = _prHeader.Extension;
                prHeader.Objective = prHeader.Objective == null ? "" : prHeader.Objective;
                //prHeader.Comment = _prHeader.Comment;
                prHeader.Comment = prHeader.Comment == null ? "" : prHeader.Comment;
                prHeader.Update_Date = DateTime.Now;


                _context.SaveChanges();


                var itemIds = prDetails.Select(x => x.Id).ToArray();
                // Save PRItems 
                var deleteitm = _context.PRItems.Where(o => o.PrHeadersId == prHeader.Id &&  !itemIds.Contains(o.Id)).ToList();
                _context.PRItems.RemoveRange(deleteitm);
                _context.SaveChanges();

                var itmno = 1;
                foreach (var prd in prDetails)
                {
                    if (prd.Id > 0)// Update
                    {
                        var delitm = _context.PRItems.Where(o => o.Id == prd.Id).FirstOrDefault();
                        delitm.Item_No = itmno.ToString();
                        delitm.Item_Description = prd.Item_Description;
                        delitm.Item_Code = prd.Item_Code;
                        delitm.Material_Group = prd.Material_Group;
                        delitm.Material_Group_Des = prd.Material_Group_Des;
                        delitm.Quantity = prd.Quantity;
                        delitm.UOM = prd.UOM;
                        delitm.Requistion_date = prd.Requistion_date;
                        delitm.Delivery_date = prd.Delivery_date;
                        delitm.Price_PR = prd.Price_PR;
                        delitm.Price_Unit = prd.Price_Unit;
                        delitm.Currency = prd.Currency;
                        delitm.Desired_Vendor = prd.Desired_Vendor;
                        delitm.Account_Ass_Cat = prd.Account_Ass_Cat;
                        delitm.GL_Account = prd.GL_Account;
                        delitm.Cost_Center = prd.Cost_Center;
                        delitm.WBS_Code = prd.WBS_Code;
                        delitm.ExRate = prd.ExRate;
                        delitm.Amount = prd.Amount;
                        delitm.AmountTHB = prd.AmountTHB;
                        delitm.UpdateDate = DateTime.Now; // Update

                        _context.SaveChanges();
                        //_context.PRItems.Update();
                    }
                    else // New
                    {
                        prd.PrHeaders = null;
                        prd.Id = 0;
                        prd.Item_No = itmno.ToString();
                        prd.PrHeadersId = prHeader.Id;
                        prd.Price_Unit = 1;
                        prd.Delete_Status = "";
                        prd.Desired_Vendor = "";
                        prd.Requistion_date = DateTime.Now;
                        prd.Item_Code = prd.Item_Code == null ? "" : prd.Item_Code;
                        _context.PRItems.Add(prd);
                    }

                    itmno++;
                }

                _context.SaveChanges();

                result = prHeader.Id.ToString();
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //_context.Master_Roles.Remove(master_Role);
                result = "ERROR";
            }
            return result;
        }

        public async Task<List<Master_Org>> GetMasterOrgsAsync(string UserId)
        {
            var data = await _context.WorkflowAuthos.Where(o => o.User_Id.ToString() == UserId).ToListAsync();
            List<Master_Org> orgList = new List<Master_Org>();
            List<String> cmp = new List<string>();
            foreach (var item in data)
            {
                Master_Org org = new Master_Org();
                org.Org  = item.Org;
                if (!cmp.Contains(item.Org))
                {
                    cmp.Add(item.Org);
                    orgList.Add(org);
                }
            }

            return orgList;
        }

        public async Task<List<Master_Dep>> GetMasterDepsAsync(string UserId)
        {
            var data = await _context.WorkflowAuthos.Where(o => o.User_Id.ToString() == UserId).ToListAsync();
            List<Master_Dep> deptList = new List<Master_Dep>();
            List<String> ddd = new List<string>();
            foreach (var item in data)
            {
                Master_Dep dept = new Master_Dep();
                dept.Dep = item.Dep;
                if (!ddd.Contains(item.Dep))
                {
                    ddd.Add(item.Dep);
                    deptList.Add(dept);
                }
            }

            return  deptList;
        }


        public async Task<List<Master_Sec>> GetMasterSecsAsync(string UserId)
        {
            var data = await _context.WorkflowAuthos.Where(o => o.User_Id.ToString() == UserId).ToListAsync();
            List<Master_Sec> secList = new List<Master_Sec>();
            List<String> ddd = new List<string>();
            foreach (var item in data)
            {
                Master_Sec sec = new Master_Sec();
                sec.Sec = item.Sec;
                if (!ddd.Contains(item.Sec))
                {
                    ddd.Add(item.Sec);
                    secList.Add(sec);
                }
            }

            return secList;
        }

        public async Task ReAssingStaff(int prId)
        {
            string Sql = "DELETE FROM rnPrItems WHERE Rn_Id = " + prId;
            _ = await _context.Database.ExecuteSqlRawAsync(Sql);
        }



    }

}


