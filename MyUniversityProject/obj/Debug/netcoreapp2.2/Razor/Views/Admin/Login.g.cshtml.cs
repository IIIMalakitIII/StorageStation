#pragma checksum "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a19d1ce2491e9e8b6729bb5bb98f034a7ce78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Login.cshtml", typeof(AspNetCore.Views_Admin_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a19d1ce2491e9e8b6729bb5bb98f034a7ce78f", @"/Views/Admin/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ade478114418871ab43e38a2e377a8ee271c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.AuthenticationModel.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
            BeginContext(109, 195, true);
            WriteLiteral("<h2>Sign in for Admin</h2>\r\n<hr />\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <br>\r\n");
            EndContext();
#line 13 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                 using (Html.BeginForm("Login", "Admin", new { htmlAttributes = new { @class = "mb-4" } }))
                {
                    

#line default
#line hidden
            BeginContext(453, 23, false);
#line 15 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(476, 56, true);
            WriteLiteral(" <div class=\"form-horizontal\">\r\n                        ");
            EndContext();
            BeginContext(533, 64, false);
#line 16 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(597, 80, true);
            WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(678, 106, false);
#line 18 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.LabelFor(model => model.Email, "Email ", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(784, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(815, 118, false);
#line 19 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @placeholder = "Email" } }));

#line default
#line hidden
            EndContext();
            BeginContext(933, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(964, 83, false);
#line 20 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1160, 112, false);
#line 23 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.LabelFor(model => model.Password, "Password ", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1303, 124, false);
#line 24 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", @placeholder = "Password" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1458, 86, false);
#line 25 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 254, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" value=\"Sign in\" class=\"btn btn-success btn-lg btn-block\" />\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\Admin\Login.cshtml"
                }

#line default
#line hidden
            BeginContext(1817, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
