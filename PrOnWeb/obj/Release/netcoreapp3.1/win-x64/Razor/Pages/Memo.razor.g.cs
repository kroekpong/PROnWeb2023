#pragma checksum "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e52f4cbc12b01ef0338afe4fd6ca8f13aba4af"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/memo")]
    public partial class Memo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddContent(0, "Memo ");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
      prNo

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 8 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
 if (DataSource == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<textarea>loading...</textarea>");
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "memobox");
            __Blazor.PrOnWeb.Pages.Memo.TypeInference.CreateSfListView_0(__builder, 7, 8, "list", 9, 
#nullable restore
#line 17 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                     DataSource

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 18 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                    false

#line default
#line hidden
#nullable disable
            , 11, "100px", 12, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewFieldSettings<vPrMemo>>(13);
                __builder2.AddAttribute(14, "Id", "Id");
                __builder2.AddAttribute(15, "Text", "Text");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewTemplates<vPrMemo>>(17);
                __builder2.AddAttribute(18, "Template", (Microsoft.AspNetCore.Components.RenderFragment<vPrMemo>)((context) => (__builder3) => {
#nullable restore
#line 24 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                          
                            vPrMemo currentData = context as vPrMemo;


#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "flex item__container");
                    __builder3.OpenElement(21, "div");
                    __builder3.AddAttribute(22, "class", "flex content__container flex__8 vertical padding left__align");
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "mini__font");
                    __builder3.AddContent(25, 
#nullable restore
#line 29 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                                             currentData.MemoWho

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(26, " (");
                    __builder3.AddContent(27, 
#nullable restore
#line 29 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                                                                   currentData.MemoWhen

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(28, ") :");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                                    ");
                    __builder3.OpenElement(30, "div");
                    __builder3.AddAttribute(31, "class", "small__font");
                    __builder3.AddContent(32, 
#nullable restore
#line 30 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                                               currentData.MemoMsg

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "flex");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "flex__8 padding");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(38);
            __builder.AddAttribute(39, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "Placeholder", "Type your message");
            __builder.AddComponentReferenceCapture(41, (__value) => {
#nullable restore
#line 40 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                      SfTextBox = (Syncfusion.Blazor.Inputs.SfTextBox)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "flex__1");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "e-btn");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
                                                     OnSend

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<style>\r\n\r\n\r\n    #memobox {\r\n        height: 150px;\r\n        margin: 0 auto;\r\n        display: block;\r\n        max-width: 350px;\r\n    }\r\n\r\n    #list {\r\n        margin: 0 auto;\r\n        border: 1px solid #ccc;\r\n    }\r\n\r\n        #list .e-list-item {\r\n            height: auto;\r\n            cursor: pointer;\r\n            line-height: 18px;\r\n            padding: 0px;\r\n        }\r\n\r\n        #list.e-listview .e-list-header {\r\n            background-color: #0278d7;\r\n            color: white;\r\n        }\r\n\r\n        #list .e-list-item.e-active {\r\n            background-color: transparent;\r\n        }\r\n\r\n        #list .e-list-item.e-hover {\r\n            background-color: transparent;\r\n        }\r\n\r\n    .padding {\r\n        padding: 4px;\r\n    }\r\n\r\n    .right__align {\r\n        text-align: right;\r\n        margin-right: 8px;\r\n        padding-right: 8px;\r\n    }\r\n\r\n    .left__align {\r\n        margin-left: 8px;\r\n        padding-left: 8px;\r\n    }\r\n\r\n    .content__container {\r\n        background-color: transparent;\r\n    }\r\n\r\n    .flex {\r\n        display: flex;\r\n    }\r\n\r\n    .flex__center {\r\n        justify-content: center;\r\n    }\r\n\r\n    .vertical__center {\r\n        align-items: center;\r\n    }\r\n\r\n    .vertical {\r\n        flex-direction: column;\r\n    }\r\n\r\n    .flex__order__1 {\r\n        order: 1;\r\n    }\r\n\r\n    .flex__order__2 {\r\n        order: 2;\r\n    }\r\n\r\n    .flex__1 {\r\n        flex: 1;\r\n    }\r\n\r\n    .flex__2 {\r\n        flex: 2;\r\n    }\r\n\r\n    .flex__3 {\r\n        flex: 3;\r\n    }\r\n\r\n    .flex__5 {\r\n        flex: 5;\r\n    }\r\n\r\n    .flex__8 {\r\n        flex: 8;\r\n    }\r\n\r\n    .bold {\r\n        font-weight: 500;\r\n    }\r\n\r\n    .margin {\r\n        margin: 10px;\r\n        width: 350px;\r\n    }\r\n\r\n    .mini__font {\r\n        font-size: 10px;\r\n        margin: 2px 0;\r\n        color: gray;\r\n    }\r\n\r\n    .small__font {\r\n        font-size: 12px;\r\n        margin: 2px 0;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Memo.razor"
 
    [Parameter] public int prNo { get; set; }
    //[Parameter] public int userId { get; set; }

    SfTextBox SfTextBox;
    ObservableCollection<vPrMemo> DataSource = new ObservableCollection<vPrMemo>();

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();

    int myUserId=1;


    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        CurrentUser = (await _authState).User;
        if (CurrentUser.Identity.IsAuthenticated)
        {
            //myUserId = Int16.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
            var myUserName = CurrentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;
            UserTable userTable = await prDataService.GetUserTableFromUseNameAsync(myUserName);
            myUserId = userTable.Pr_User_Id;
        }


        List<vPrMemo> prMemoRead = await prDataService.GetvPrMemoAsync(prNo);
        foreach (vPrMemo memo in prMemoRead)
        {
            DataSource.Add(memo);
        }
    }

    protected async Task OnSend()
    {
        if (SfTextBox.Value != "")
        {
            vPrMemo prMemo = new vPrMemo
            {
                MemoWhoID = myUserId,
                MemoMsg = SfTextBox.Value,
                MemoWhen = DateTime.Now,
                PrID = prNo,
                Id = new Random().Next(300, 900).ToString()
            };
            DataSource.Add(prMemo);

            await prDataService.InsertvPrMemoAsync(prMemo);
        }
        SfTextBox.Value = "";

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
namespace __Blazor.PrOnWeb.Pages.Memo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfListView_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Lists.SfListView<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "ShowHeader", __arg2);
        __builder.AddAttribute(__seq3, "Height", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
