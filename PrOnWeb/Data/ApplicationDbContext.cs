using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrOnWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PRHeader> PRHeaders { get; set; }
        public DbSet<vPRHeader> vPRHeaders { get; set; }
        public DbSet<PRItem> PRItems { get; set; }
        public DbSet<ReturningNote> ReturningNotes { get; set; }
        public DbSet<VReturningNote> VReturningNotes { get; set; }
        public DbSet<Master_Rn_Type> Master_Rn_Types { get; set; }
        public DbSet<Master_Rn_Reason> Master_Rn_Reasons { get; set; }
        public DbSet<BudgetRange> BudgetRanges { get; set; }
        public DbSet<WorkflowAutho> WorkflowAuthos { get; set; }
        public DbSet<WorkflowApproval> WorkflowApprovals { get; set; }
        public DbSet<UserTable> UserTables { get; set; }
        public DbSet<Wf_Pr_Assignment> Wf_Pr_Assignments { get; set; }
        public DbSet<Wf_Item_Assignment> wf_Item_Assignments { get; set; }
        public DbSet<PrMemo> prMemos { get; set; }
        public DbSet<vPrMemo> vPrMemo { get; set; }
        public DbSet<UploadFile> uploadFiles { get; set; }
        public DbSet<Approval_flow> Approval_Flows { get; set; }
        public DbSet<vApproval_flow> vApproval_Flows { get; set; }
        public DbSet<StatusMapping> StatusMappings { get; set; }
        public DbSet<vWorkflowAutho> vWorkflowAutho { get; set; }
        public DbSet<vWorkflowAuthoOrder> VWorkflowAuthoOrders { get; set; }
        public DbSet<vWorkflowAuthoName> vWorkflowAuthoNames { get; set; }
        //public DbSet<Master_Role> Master_Roles { get; set; }
        public DbSet<Master_Org> Master_Orgs { get; set; }
        public DbSet<Master_Dep> Master_Deps { get; set; }
        public DbSet<Master_Sec> Master_Secs { get; set; }
        public DbSet<MasterDimension> masterDimensions { get; set; }
        public DbSet<VPrList> vPrLists { get; set; }
        public DbSet<RnPrItem> rnPrItems { get; set; }
        public DbSet<SystemConfiguration> systemConfigurations { get; set; }
        public DbSet<MatRegList> MatRegLists { get; set; }
        public DbSet<Import_Log> ImportLogs { get; set; }
        public DbSet<PrUserId> prUserIds { get; set; }
        public DbSet<ListOfString> ListOfStrings { get; set; }
        public DbSet<IdText> IdTexts { get; set; }
        public DbSet<PrListModel> PrLists { get; set; }
        public DbSet<PrReportModel> PrReportModels { get; set; }
        public DbSet<RnReportModel> RnReportModels { get; set; }
        public DbSet<EmailMessage> emailMessages { get; set; }
        public DbSet<Master_Unit> Master_Unit { get; set; }
        public DbSet<Master_Currency> Master_Currency { get; set; }
        public DbSet<Master_PurGroup> Master_PurGroup { get; set; }
        public DbSet<Master_CostCenter> Master_CostCenter { get; set; }
        public DbSet<MatGroupList> MatGroupList { get; set; }

        public DbSet<PasswordHistory> PasswordHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RnPrItem>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<VReturningNote>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("VReturningNotes");
            });

            modelBuilder.Entity<UserTable>(eb =>
            {
                eb.HasNoKey();
            });

            modelBuilder.Entity<MatGroupList>(eb =>
            {
                eb.HasNoKey();
            });

            modelBuilder.Entity<VPrList>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("VPrList");
            });

            modelBuilder.Entity<PrUserId>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("PrUserId");
            });

            //modelBuilder.Entity<Master_Role>()
            //  .HasIndex(x => x.Role)
            //    .IsUnique();

            modelBuilder.Entity<Master_Org>()
              .HasIndex(x => x.Org)
                .IsUnique();

            modelBuilder.Entity<Master_Dep>()
              .HasIndex(x => x.Dep)
                .IsUnique();

            modelBuilder.Entity<Master_Sec>()
              .HasIndex(x => x.Sec)
                .IsUnique();

            modelBuilder.Entity<Master_Unit>().HasIndex(x => x.Code) .IsUnique();

            modelBuilder.Entity<Master_Currency>().HasIndex(x => x.Id).IsUnique();

            modelBuilder.Entity<Master_PurGroup>().HasIndex(x => x.Id).IsUnique();

            modelBuilder.Entity<Master_CostCenter>().HasIndex(x => x.Id).IsUnique();

            modelBuilder.Entity<ListOfString>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<IdText>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<PrListModel>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<vWorkflowAuthoOrder>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<PrReportModel>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<RnReportModel>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });
            modelBuilder.Entity<EmailMessage>(eb =>
            {
                eb.HasNoKey();
                eb.ToView(null);
            });

        }
    }
}
