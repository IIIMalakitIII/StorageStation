#pragma checksum "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1e7ba249c8190bad2d7536ef0cc372561086d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storage_GetStandart), @"mvc.1.0.view", @"/Views/Storage/GetStandart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Storage/GetStandart.cshtml", typeof(AspNetCore.Views_Storage_GetStandart))]
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
#line 1 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject;

#line default
#line hidden
#line 2 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models.ErrorViewModel;

#line default
#line hidden
#line 4 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 5 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
using MyUniversityProject.Models.StorageViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1e7ba249c8190bad2d7536ef0cc372561086d4", @"/Views/Storage/GetStandart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Storage_GetStandart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Standard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 202, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-5 d-flex justify-content-center\">\r\n        <div class=\"wrapper\">\r\n            <div class=\"wrapped-div-1\">\r\n                <div class=\"col-md-10 offset-md-1\">\r\n");
            EndContext();
#line 8 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                     using (Html.BeginForm("GetStandart", "Storage", FormMethod.Post))
                    {
                        

#line default
#line hidden
            BeginContext(434, 23, false);
#line 10 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(484, 33, false);
#line 11 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                   Write(Html.HiddenFor(x => x.StandardId));

#line default
#line hidden
            EndContext();
            BeginContext(544, 64, false);
#line 12 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(610, 189, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(800, 115, false);
#line 16 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.LabelFor(model => model.MinVolume, "Min Volume", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(915, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(954, 154, false);
#line 17 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.EditorFor(model => model.MinVolume, new { htmlAttributes = new { @class = "form-control", @type = "number", @min = 1, @placeholder = "MinVolume" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1147, 87, false);
#line 18 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.ValidationMessageFor(model => model.MinVolume, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(1459, 115, false);
#line 23 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.LabelFor(model => model.MaxVolume, "Max Volume", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1613, 154, false);
#line 24 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.EditorFor(model => model.MaxVolume, new { htmlAttributes = new { @class = "form-control", @type = "number", @min = 1, @placeholder = "MaxVolume" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1806, 87, false);
#line 25 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.ValidationMessageFor(model => model.MaxVolume, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 299, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(2193, 106, false);
#line 32 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.LabelFor(model => model.Price, "Price", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2338, 147, false);
#line 33 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control", @placeholder = "Price", @pattern = @"^(\d+\.)?\d+$" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2485, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2524, 83, false);
#line 34 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2607, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(2832, 117, false);
#line 39 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.LabelFor(model => model.StandardId, "Standard Id", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2988, 152, false);
#line 40 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.EditorFor(model => model.StandardId, new { htmlAttributes = new { @class = "form-control", @placeholder = "StandardId", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3140, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3179, 88, false);
#line 41 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"
                               Write(Html.ValidationMessageFor(model => model.StandardId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3267, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(3379, 189, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Edit\" class=\"btn btn-success btn-lg btn-block\" />\r\n                        </div>\r\n");
            EndContext();
#line 49 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\GetStandart.cshtml"

                    }

#line default
#line hidden
            BeginContext(3593, 78, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.Standard> Html { get; private set; }
    }
}
#pragma warning restore 1591
