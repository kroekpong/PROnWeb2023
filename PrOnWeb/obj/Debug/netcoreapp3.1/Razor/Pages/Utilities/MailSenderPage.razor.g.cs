#pragma checksum "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d938122115af2c10f4f7178c803ee9e761a281"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb.Pages.Utilities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
           [Authorize(Roles = "Administrators")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MailUtil")]
    public partial class MailSenderPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Simulate Approval Mail Sender</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, "<td>\r\n            <label>Email: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "Email");
            __builder.AddAttribute(10, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                     toEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => toEmail = __value, toEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<td>\r\n            <label>PR #: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "placeholder", "PR #");
            __builder.AddAttribute(22, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                    PrNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PrNo = __value, PrNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<td>\r\n            <label>PR Header Id: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(30, "td");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "placeholder", "PR Header Id");
            __builder.AddAttribute(34, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                            PrHeaderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PrHeaderId = __value, PrHeaderId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.AddMarkupContent(41, "<td>\r\n            <label>PR Status: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(42, "td");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "placeholder", "PR Status");
            __builder.AddAttribute(46, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                         PrStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PrStatus = __value, PrStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<td>\r\n            <label>Approval Status: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(54, "td");
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "placeholder", "Approval Status");
            __builder.AddAttribute(58, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                               ApprovalStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ApprovalStatus = __value, ApprovalStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "tr");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<td>\r\n            <label>Role: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(66, "td");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "placeholder", "Role");
            __builder.AddAttribute(70, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                    Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Role = __value, Role));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.OpenElement(75, "tr");
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.AddMarkupContent(77, "<td>\r\n            <label>Type: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(78, "td");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "placeholder", "Type");
            __builder.AddAttribute(82, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                    Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Type = __value, Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.OpenElement(87, "tr");
            __builder.AddMarkupContent(88, "\r\n        <td></td>\r\n        ");
            __builder.OpenElement(89, "td");
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                              Sender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "\r\n                Send\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n<br>\r\n");
            __builder.AddMarkupContent(98, "<h3>Mail Sender</h3>\r\n");
            __builder.OpenElement(99, "table");
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.OpenElement(101, "tr");
            __builder.AddMarkupContent(102, "\r\n        ");
            __builder.AddMarkupContent(103, "<td>\r\n            <label>Email: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(104, "td");
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "placeholder", "Email");
            __builder.AddAttribute(108, "type", "text");
            __builder.AddAttribute(109, "width", "200");
            __builder.AddAttribute(110, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                     toEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => toEmail = __value, toEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.OpenElement(115, "tr");
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.AddMarkupContent(117, "<td>\r\n            <label>Subject: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(118, "td");
            __builder.AddMarkupContent(119, "\r\n            ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "placeholder", "Subject");
            __builder.AddAttribute(122, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                       sSubject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sSubject = __value, sSubject));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.OpenElement(127, "tr");
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.AddMarkupContent(129, "<td>\r\n            <label>Body: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(130, "td");
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.OpenElement(132, "textarea");
            __builder.AddAttribute(133, "placeholder", "Body");
            __builder.AddAttribute(134, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                 sBody

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sBody = __value, sBody));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.OpenElement(139, "tr");
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.AddMarkupContent(141, "<td>\r\n            <label>Type: </label>\r\n        </td>\r\n        ");
            __builder.OpenElement(142, "td");
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.OpenElement(144, "input");
            __builder.AddAttribute(145, "placeholder", "Type");
            __builder.AddAttribute(146, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                                                    Type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(147, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Type = __value, Type));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.OpenElement(151, "tr");
            __builder.AddMarkupContent(152, "\r\n        <td></td>\r\n        ");
            __builder.OpenElement(153, "td");
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.OpenElement(155, "button");
            __builder.AddAttribute(156, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
                              PlainSender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(157, "\r\n                Send\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\MailSenderPage.razor"
       
    string fromEmail = "TPP-PrOnWeb@th.tpcc-tpac.com";
    string toEmail = "Saravut.tant@th.tpcc-tpac.com";
    //string fromEmail = "no-reply@beko.com";
    //string toEmail = "kroekpong@gmail.com";
    string PrNo = "0001-0002-0003";
    string PrHeaderId = "23031";
    string PrStatus = "Pending Approval";
    string ApprovalStatus = "No";
    string Role = "Approval";
    string Type = "Approver";

    private async void Sender()
    {
        //PrNoti nextPrNoti = new PrNoti()
        //{
        //    PrSAPNo = PrNo,
        //    PrId = Int32.Parse(PrHeaderId),
        //    PrStatus = PrStatus,
        //    ApproveStatus = ApprovalStatus,
        //    AsRole = Role
        //};

        vPRHeader prh = await prMainService.GetvPrHeaderAsync(Int32.Parse(PrHeaderId));

        EmailMessage emailMessage = new EmailMessage()
        {
            PrId = prh.Id.ToString(),
            PrNo = prh.Pr_No,
            //RequesterInfo = prh.Requester + ", COMPANY: " + prh.Company + ",DEPARTMENT: " + prh.Department + ", SECTION:" + prh.Section,
            RequesterInfo = prh.Requester,
            WBS = "",
            TotalCost = prh.sPrAmt,
            RequirementDate = (prh.Release_Date ?? DateTime.Now).ToString("dd/MM/yyyy"),
            StatusName = prh.PrStatus,
            Objective = prh.Objective,

            Company = prh.Company,
            Department = prh.Department,
            Section = prh.Section,
            Memo = "",
            Comment = prh.Comment,
            RN_TYPE = ""
        };

        MailKitService.SendNoti(fromEmail, toEmail, "Workflow assigned for PR No." + prh.Pr_No, emailMessage, Type);
        //MailKitService.SendNotiTest(fromEmail, toEmail, "Workflow assigned for PR No." + prh.Pr_No, emailMessage, Type);
        //await EmailService.SendEmailAsync(toEmail, "Waiting for your approval.", nextPrNoti);
    }

    string sSubject = "ACtion Required";
    string sBody = "Test Sending Email from Web App";

    private void PlainSender()
    {
        //await EmailService.SendPlainEmailAsync(toEmail, sSubject, sBody);
        MailKitService.Send("TPP-PrOnWeb@th.tpcc-tpac.com", toEmail, sSubject, sBody);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrMainService prMainService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmailServices.IMailKitEmailService MailKitService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmailServices.IEmailService EmailService { get; set; }
    }
}
#pragma warning restore 1591