#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c644d1ad5ac3b3009d18529d99309a3297531fe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateAdmin), @"mvc.1.0.view", @"/Views/Admin/CreateAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CreateAdmin.cshtml", typeof(AspNetCore.Views_Admin_CreateAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c644d1ad5ac3b3009d18529d99309a3297531fe0", @"/Views/Admin/CreateAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 161, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <br>\r\n");
            EndContext();
#line 8 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                 using (Html.BeginForm("CreateAdmin", "Admin", new { htmlAttributes = new { @class = "mb-4" } }))
                {
                    

#line default
#line hidden
            BeginContext(360, 23, false);
#line 10 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(385, 63, true);
            WriteLiteral("                <div class=\"form-horizontal\">\r\n                ");
            EndContext();
            BeginContext(449, 64, false);
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(513, 159, true);
            WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-5\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(673, 114, false);
#line 16 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.FirstName, "FirstName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(787, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(818, 126, false);
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @placeholder = "FirstName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(944, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(975, 87, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1175, 112, false);
#line 21 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.Position, "Position", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1318, 124, false);
#line 22 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.Position, new { htmlAttributes = new { @class = "form-control", @placeholder = "Position" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1473, 86, false);
#line 23 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Position, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1672, 116, false);
#line 26 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.PassportId, "PassportId", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1819, 130, false);
#line 27 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.PassportId, new { htmlAttributes = new { @class = "form-control", @placeholder = "Pasport Code" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1980, 88, false);
#line 28 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PassportId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2181, 104, false);
#line 31 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.Role, "Role", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2316, 92, false);
#line 32 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.Role, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2439, 82, false);
#line 33 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Role, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2521, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-7\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2706, 112, false);
#line 38 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.LastName, "LastName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2818, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2849, 128, false);
#line 39 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control hio", @placeholder = "LastName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3008, 86, false);
#line 40 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3207, 106, false);
#line 43 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.Email, "Email", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3313, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3344, 94, false);
#line 44 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3438, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3469, 83, false);
#line 45 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3552, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3665, 118, false);
#line 48 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.PhoneNumber, "PhoneNumber", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3783, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3814, 124, false);
#line 49 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3938, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3969, 89, false);
#line 50 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4058, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4171, 108, false);
#line 53 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.Salary, "Salary", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4279, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4310, 120, false);
#line 54 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.Salary, new { htmlAttributes = new { @class = "form-control", @placeholder = "Salary" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4430, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4461, 84, false);
#line 55 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Salary, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4545, 243, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-7\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4789, 124, false);
#line 62 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.DataWorkStart, "Data Work Start", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4913, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4944, 101, false);
#line 63 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.DataWorkStart, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(5045, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5076, 91, false);
#line 64 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DataWorkStart, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5167, 112, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(5280, 112, false);
#line 67 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.LabelFor(model => model.Password, "Password", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(5392, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5423, 96, false);
#line 68 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(5519, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5550, 86, false);
#line 69 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5636, 305, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Create"" class=""btn btn-success btn-lg btn-block"" />
                        </div>
                    </div>
");
            EndContext();
#line 77 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\CreateAdmin.cshtml"
                    }

#line default
#line hidden
            BeginContext(5964, 58, true);
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
