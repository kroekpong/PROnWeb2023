#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c048fc6c1dc14cc9b2d5f986d56496e18fef9492"
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
#line 1 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TestUpload/{DocumentType:int}/{DocumentId:int}")]
    public partial class TestUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                  uploadFile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(10);
                __builder2.AddAttribute(11, "Placeholder", "Description");
                __builder2.AddComponentReferenceCapture(12, (__value) => {
#nullable restore
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                          description = (Syncfusion.Blazor.Inputs.SfTextBox)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(18);
                __builder2.AddAttribute(19, "ID", "UploadFiles");
                __builder2.AddAttribute(20, "MaxFileSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                                                                    MaxUploadFileSize

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "AutoUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(24);
                    __builder3.AddAttribute(25, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>(this, 
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                                         OnChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                }
                ));
                __builder2.AddComponentReferenceCapture(27, (__value) => {
#nullable restore
#line 16 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
                          UploadObj = (Syncfusion.Blazor.Inputs.SfUploader)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.AddContent(31, 
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
 UploadFileName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, " <br>\r\n");
            __builder.AddContent(33, 
#nullable restore
#line 23 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
 UPloadComplete

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, " <br> \r\n");
            __builder.AddContent(35, 
#nullable restore
#line 24 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
 SaveRecord

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, " <br> \r\n");
            __builder.AddContent(37, 
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
 Rename

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\TestUpload.razor"
       
    [Parameter] public int DocumentType { get; set; }
    [Parameter] public int DocumentId { get; set; }
    public int MaxUploadFileSize = 10000000;
    public string UploadPath = "/images/";

    SfUploader UploadObj;
    SfTextBox description;
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    string UploadFileName = "";
    string UPloadComplete = "";
    string SaveRecord = "";
    string Rename = "";

    public async Task OnChange(UploadChangeEventArgs args)
    {
        UploadFileName = "";
        UPloadComplete = "";
        foreach (var file in args.Files)
        {
            var path = env.WebRootPath +  UploadPath + file.FileInfo.Name;
            UploadFileName = path;
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
            file.Stream.WriteTo(filestream);
            filestream.Close();
            file.Stream.Close();
            UPloadComplete = "Upload Complete";
            await SaveUploadDetail(file.FileInfo.Name);
        }
    }

    public UploadFile uploadFile = new UploadFile();

    public async Task HandleValidSubmit()
    {
        await this.UploadObj.Upload(); // Upload the selected file manually
    }

    public async Task SaveUploadDetail(string UploadFileName)
    {
        //must be authenticated
        CurrentUser = (await _authState).User;
        int UserId = Int32.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);

        // Insert new upload record
        // 1= Pr Item Attachment
        // 2= Rn Attachment
        var NewUpload = new UploadFile
        {
            Upload_Type = DocumentType,
            Document_id = DocumentId,
            Filename = UploadFileName,
            Description = description.Value,
            Who = UserId,
            When = DateTime.Now,
            Status = "NEW"
        };
        int NewId = await prDataService.InsertUploadFileAsync(NewUpload);
        SaveRecord = "Save record complete";
        string NewFileName = NewId.ToString() + "_" + UploadFileName;
        File.Move(env.WebRootPath +  UploadPath +  UploadFileName, env.WebRootPath + UploadPath + NewFileName);
        Rename = "Rename file complete ->" + env.WebRootPath + UploadPath + NewFileName;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591
