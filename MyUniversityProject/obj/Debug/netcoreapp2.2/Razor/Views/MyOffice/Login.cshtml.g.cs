#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0d0c46477df816f423c75bf7716bf97da7a01c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyOffice_Login), @"mvc.1.0.view", @"/Views/MyOffice/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyOffice/Login.cshtml", typeof(AspNetCore.Views_MyOffice_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0d0c46477df816f423c75bf7716bf97da7a01c", @"/Views/MyOffice/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOffice_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.AuthenticationModel.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(109, 185, true);
            WriteLiteral("<h2>Sign in</h2>\r\n<hr/>\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                 <br>\r\n");
            EndContext();
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                     using (Html.BeginForm("Login", "MyOffice", new { htmlAttributes = new { @class = "mb-4" } }))
                    {
                        

#line default
#line hidden
            BeginContext(458, 23, false);
#line 15 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(481, 56, true);
            WriteLiteral(" <div class=\"form-horizontal\">\r\n                        ");
            EndContext();
            BeginContext(538, 64, false);
#line 16 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(602, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(683, 106, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.LabelFor(model => model.Email, "Email ", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(789, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(820, 118, false);
#line 19 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @placeholder = "Email" } }));

#line default
#line hidden
            EndContext();
            BeginContext(938, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(969, 83, false);
#line 20 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1165, 112, false);
#line 23 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.LabelFor(model => model.Password, "Password ", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1308, 124, false);
#line 24 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", @placeholder = "Password" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1463, 86, false);
#line 25 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 254, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Sign in\" class=\"btn btn-success btn-lg btn-block\" />\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 31 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Login.cshtml"
                    }

#line default
#line hidden
            BeginContext(1826, 70, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.AuthenticationModel.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
