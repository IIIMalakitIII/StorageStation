#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc8f1a7601b4ea8bba0bd10f341e4c030524b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin__MyOfficeForSuperUser), @"mvc.1.0.view", @"/Views/Admin/_MyOfficeForSuperUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/_MyOfficeForSuperUser.cshtml", typeof(AspNetCore.Views_Admin__MyOfficeForSuperUser))]
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
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc8f1a7601b4ea8bba0bd10f341e4c030524b55", @"/Views/Admin/_MyOfficeForSuperUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ade478114418871ab43e38a2e377a8ee271c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin__MyOfficeForSuperUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 161, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <br>\r\n");
            EndContext();
#line 8 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                 using (Html.BeginForm("UpdateSuperUser", "Admin", new { htmlAttributes = new { @class = "mb-4" } }))
                {
                    

#line default
#line hidden
            BeginContext(364, 23, false);
#line 10 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(389, 67, true);
            WriteLiteral("                <div class=\"form-horizontal\">\r\n                    ");
            EndContext();
            BeginContext(457, 64, false);
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(521, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(544, 41, false);
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
               Write(Html.HiddenFor(model => model.EmployeeId));

#line default
#line hidden
            EndContext();
            BeginContext(585, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(608, 39, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
               Write(Html.HiddenFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(647, 175, true);
            WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-5\">\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(823, 114, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.FirstName, "FirstName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(937, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(972, 126, false);
#line 19 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @placeholder = "FirstName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1133, 87, false);
#line 20 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(1345, 112, false);
#line 23 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.Position, "Position", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1492, 124, false);
#line 24 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.Position, new { htmlAttributes = new { @class = "form-control", @placeholder = "Position" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1651, 86, false);
#line 25 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Position, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(1862, 116, false);
#line 28 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.PassportId, "PassportId", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2013, 130, false);
#line 29 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.PassportId, new { htmlAttributes = new { @class = "form-control", @placeholder = "Pasport Code" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2178, 88, false);
#line 30 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.PassportId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2266, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(2391, 104, false);
#line 33 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.Role, "Role", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2530, 117, false);
#line 34 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.Role, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2647, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2682, 82, false);
#line 35 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Role, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2764, 204, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-7\">\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(2969, 112, false);
#line 40 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.LastName, "LastName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3081, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3116, 128, false);
#line 41 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control hio", @placeholder = "LastName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3244, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3279, 86, false);
#line 42 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3365, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(3490, 106, false);
#line 45 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.Email, "Email", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3631, 118, false);
#line 46 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3749, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(3784, 83, false);
#line 47 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3867, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(3992, 118, false);
#line 50 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.PhoneNumber, "PhoneNumber", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4110, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4145, 124, false);
#line 51 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4269, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4304, 89, false);
#line 52 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4393, 124, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                ");
            EndContext();
            BeginContext(4518, 108, false);
#line 55 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.LabelFor(model => model.Salary, "Salary", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4626, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4661, 120, false);
#line 56 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.EditorFor(model => model.Salary, new { htmlAttributes = new { @class = "form-control", @placeholder = "Salary" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4781, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4816, 84, false);
#line 57 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Salary, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4900, 168, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(5069, 124, false);
#line 62 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                   Write(Html.LabelFor(model => model.DataWorkStart, "Data Work Start", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(5193, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(5220, 126, false);
#line 63 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                   Write(Html.EditorFor(model => model.DataWorkStart, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5346, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(5373, 91, false);
#line 64 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                   Write(Html.ValidationMessageFor(model => model.DataWorkStart, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5464, 231, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\" value=\"Edit\" class=\"btn btn-success btn-lg btn-block\" />\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 70 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\_MyOfficeForSuperUser.cshtml"
                }

#line default
#line hidden
            BeginContext(5714, 58, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591