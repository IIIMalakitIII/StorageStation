#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10cdafa8c1fbae9c2c6437ae02b6dba391d7ed7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__OfficeForAdmin), @"mvc.1.0.view", @"/Views/Admin/_OfficeForAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/_OfficeForAdmin.cshtml", typeof(AspNetCore.Views_Admin__OfficeForAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10cdafa8c1fbae9c2c6437ae02b6dba391d7ed7c", @"/Views/Admin/_OfficeForAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__OfficeForAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 256, true);
            WriteLiteral(@"
<div class=""wrapper"">
    <div class=""wrapped-div"">
        <div class=""tab-header"">
            <div class=""col-md-10 offset-md-1"">
                <div class=""form-horizontal"">
                    <div class=""form-group"">
                        ");
            EndContext();
            BeginContext(301, 89, false);
#line 9 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.Label("", "Last Name", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(390, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(417, 121, false);
#line 10 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(538, 100, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(639, 90, false);
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.Label("", "First Name", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(729, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(756, 122, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(878, 100, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(979, 85, false);
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.Label("", "Email", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1091, 118, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 100, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(1310, 84, false);
#line 21 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.Label("", "Role", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1421, 117, false);
#line 22 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_OfficeForAdmin.cshtml"
                   Write(Html.EditorFor(model => model.Role, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 108, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
