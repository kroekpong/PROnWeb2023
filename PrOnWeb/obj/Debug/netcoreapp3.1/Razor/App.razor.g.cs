#pragma checksum "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7253ab185e89762f68dd61f1cdb9c2cfe65baf68"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb
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
#line 1 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
using PrOnWeb.Pages.Utilities;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n");
#nullable restore
#line 8 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                      
                        var returnUrl =
                        navigationManager.ToBaseRelativePath(navigationManager.Uri);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(12, "                        ");
                        __builder4.OpenComponent<global::PrOnWeb.Pages.Utilities.RedirectToLogin>(13);
                        __builder4.AddAttribute(14, "ReturnUrl", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                                                     returnUrl

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n");
                        __builder4.AddContent(16, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(18, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(20);
                    __builder3.AddAttribute(21, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 17 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n                ");
                        __builder4.AddMarkupContent(24, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
