#pragma checksum "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1a6718dcd2d436ee03018dd0add51871c69006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__ChangePassword), @"mvc.1.0.view", @"/Views/Admin/_ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/_ChangePassword.cshtml", typeof(AspNetCore.Views_Admin__ChangePassword))]
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
#line 1 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject;

#line default
#line hidden
#line 2 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1a6718dcd2d436ee03018dd0add51871c69006", @"/Views/Admin/_ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ade478114418871ab43e38a2e377a8ee271c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.AuthenticationModel.ChangePassword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 163, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <br>\r\n");
            EndContext();
#line 9 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                 using (Html.BeginForm("_ChangePassword", "Admin", new { htmlAttributes = new { @class = "mb-4" } }))
                {
                

#line default
#line hidden
            BeginContext(388, 23, false);
#line 11 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(413, 67, true);
            WriteLiteral("                <div class=\"form-horizontal\">\r\n                    ");
            EndContext();
            BeginContext(481, 94, false);
#line 13 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
               Write(Html.HiddenFor(model => model.OldPassword, new { id= "natureOfVisitField", Value = "nothing"}));

#line default
#line hidden
            EndContext();
            BeginContext(575, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(668, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(689, 64, false);
#line 15 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(753, 72, true);
            WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(826, 119, false);
#line 17 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.LabelFor(model => model.NewPassword, "New Password", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(945, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(972, 131, false);
#line 18 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.EditorFor(model => model.NewPassword, new { htmlAttributes = new { @class = "form-control", @placeholder = "New Password" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1130, 89, false);
#line 19 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NewPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 100, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1320, 127, false);
#line 22 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.LabelFor(model => model.ConfirmPassword, "Confirm Password", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1474, 139, false);
#line 23 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.EditorFor(model => model.ConfirmPassword, new { htmlAttributes = new { @class = "form-control", @placeholder = "Confirm Password" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1640, 93, false);
#line 24 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                   Write(Html.ValidationMessageFor(model => model.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 231, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Edit\" class=\"btn btn-success btn-lg btn-block\" />\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 30 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\_ChangePassword.cshtml"
                }

#line default
#line hidden
            BeginContext(1983, 54, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.AuthenticationModel.ChangePassword> Html { get; private set; }
    }
}
#pragma warning restore 1591
