using Hangfire;
using Hangfire.Dashboard;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrOnWeb.Areas.Identity;
using PrOnWeb.Data;
using PrOnWeb.Services;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using PrOnWeb.EmailServices;

namespace PrOnWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), 
                opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)), 
                ServiceLifetime.Transient);
            services.AddHangfire(x => x.UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection")));
            services.AddHangfireServer();
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true; 
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddTransient<IUserClaimsPrincipalFactory<ApplicationUser>, ClaimService>();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<ApplicationUser>>();
            //services.AddScoped<AuthenticationStateProvider, WinAuthStateProvider>();
            services.AddScoped<PrDataService>();
            services.AddScoped<PrMainService>();
            services.AddScoped<ImportCSV>();
            services.AddScoped<PrwaConfiguration>();
            services.AddScoped<AuthenService>();

            services.AddSyncfusionBlazor();
            services.AddScoped<IClaimsTransformation, UserInfoClaims>();
            services.AddHttpContextAccessor();
            //services.AddAuthentication(IISDefaults.AuthenticationScheme);
            //services.AddAuthorization();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                // define the list of cultures your app will support
                var supportedCultures = new List<CultureInfo>()
                {
                    new CultureInfo("de")
                };
                // set the default culture
                options.DefaultRequestCulture = new RequestCulture("en-Us");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders = new List<IRequestCultureProvider>() {
                    new QueryStringRequestCultureProvider() // Here, You can also use other localization provider
                };

            });
            services.AddSingleton(Configuration.GetSection("EmailSettings").Get<EmailSettings>());
            services.AddSingleton(Configuration.GetSection("MailKitSettings").Get<MailKitSettings>());
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IMailKitEmailService, MailKitService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IRecurringJobManager recurringJobManager)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzU3MTA2QDMxMzgyZTMzMmUzMFZRMnhicHJ6elVSWTNiVjNVV2JjNXRObFhCOVpwKzN5M083YXBETWRtVU09");
            app.UseRequestLocalization();
            app.UseHangfireDashboard("/ImportMonitor", new DashboardOptions
            {
                Authorization = new[] { new HangfireAuthorizationFilter() }
            });
            this.SeedHangfireJobs(recurringJobManager);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private void SeedHangfireJobs(IRecurringJobManager recurringJobManager)
        {
            // Edit recommended friend list for each user
            if (Configuration.GetValue<string>("ProjectSettings:Environment")!="Test")
            {
                recurringJobManager.AddOrUpdate<ImportCSV>("ImportCSV", x => x.ImportPR(), "*/20 * * * *");
            }
            
        }

        public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
        {
            public bool Authorize(DashboardContext context)
            {
                var httpContext = context.GetHttpContext();
                return httpContext.User.Identity.IsAuthenticated;
                //return httpContext.User.IsInRole(GlobalConstants.AdministratorRole);
            }
        }
    }
}
