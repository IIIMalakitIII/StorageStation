#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8313864736b81df2698d39a17f98a3fa21028b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storage_StorageInfo), @"mvc.1.0.view", @"/Views/Storage/StorageInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Storage/StorageInfo.cshtml", typeof(AspNetCore.Views_Storage_StorageInfo))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models;

#line default
#line hidden
#line 3 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models.ErrorViewModel;

#line default
#line hidden
#line 4 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 5 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
using MyUniversityProject.Models.FilterModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8313864736b81df2698d39a17f98a3fa21028b8", @"/Views/Storage/StorageInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Storage_StorageInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Storage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
  
    ViewData["Title"] = "StorageInfo";

#line default
#line hidden
            BeginContext(137, 210, true);
            WriteLiteral("<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-5 d-flex justify-content-center\">\r\n        <div class=\"wrapper\">\r\n            <div class=\"wrapped-div-1\">\r\n                <div class=\"col-md-10 offset-md-1\">\r\n");
            EndContext();
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                     using (Html.BeginForm("StorageInfo", "Storage", FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(483, 23, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(533, 64, false);
#line 15 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(599, 78, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(678, 112, false);
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                       Write(Html.LabelFor(model => model.Location, "Location", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(790, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(821, 124, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                       Write(Html.EditorFor(model => model.Location, new { htmlAttributes = new { @class = "form-control", @placeholder = "Location" } }));

#line default
#line hidden
            EndContext();
            BeginContext(945, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(976, 86, false);
#line 19 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 223, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(1286, 115, false);
#line 24 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                               Write(Html.LabelFor(model => model.StorageId, "Storage Id", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1440, 151, false);
#line 25 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                               Write(Html.EditorFor(model => model.StorageId, new { htmlAttributes = new { @class = "form-control", @placeholder = "Storage Id", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1630, 87, false);
#line 26 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                               Write(Html.ValidationMessageFor(model => model.StorageId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(1942, 108, false);
#line 31 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                               Write(Html.LabelFor(model => model.Status, "Status", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 85, true);
            WriteLiteral("\r\n                                    <div>\r\n                                        ");
            EndContext();
            BeginContext(2136, 813, false);
#line 33 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
                                   Write(Html.CheckBoxFor(model => model.Status,
                                            new
                                                    {
                                                    @class = "form-control",
                                                    @type = "checkbox",
                                                    @checked = @Model.Status,
                                                    @data_toggle = "toggle",
                                                    @data_on = "Active",
                                                    @data_off = "Deactive",
                                                    @data_onstyle = "success",
                                                    @data_offstyle = "danger"
                                                }));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 343, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Edit"" class=""btn btn-success btn-lg btn-block"" />
                        </div>
");
            EndContext();
#line 52 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"

                    }

#line default
#line hidden
            BeginContext(3317, 56, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(3374, 186, false);
#line 56 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageInfo.cshtml"
       Write(Html.ActionLink("Look at the list of cells", "StorageCells", "Storage", new { StorageId = Model.StorageId }, new { @class = "btn btn-primary btn-block", @style = "background:#8b00ff;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3560, 52, true);
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.Storage> Html { get; private set; }
    }
}
#pragma warning restore 1591
