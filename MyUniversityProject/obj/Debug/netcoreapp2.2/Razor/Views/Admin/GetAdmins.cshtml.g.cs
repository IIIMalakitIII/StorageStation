#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9898af5e2c297c45852b2444d6f8c6b9f374a75c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetAdmins), @"mvc.1.0.view", @"/Views/Admin/GetAdmins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/GetAdmins.cshtml", typeof(AspNetCore.Views_Admin_GetAdmins))]
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
#line 2 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9898af5e2c297c45852b2444d6f8c6b9f374a75c", @"/Views/Admin/GetAdmins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetAdmins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyUniversityProject.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 4 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
 using (Html.BeginForm("GetAdmins", "Admin", FormMethod.Get))
{

#line default
#line hidden
            BeginContext(151, 78, true);
            WriteLiteral("    <div class=\"input-group mb-3 row d-flex justify-content-center\">\r\n        ");
            EndContext();
            BeginContext(230, 58, false);
#line 7 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
   Write(Html.TextBox("searching", ViewBag.CurrentFilter as string));

#line default
#line hidden
            EndContext();
            BeginContext(288, 144, true);
            WriteLiteral("\r\n        <div class=\"input-group-append\">\r\n            <input class=\"btn btn-primary\" type=\"submit\" value=\"Find\">\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
}

#line default
#line hidden
            BeginContext(435, 132, true);
            WriteLiteral("<br />\r\n\r\n<div class=\"table-responsive-sm bg-dark\">\r\n    <table class=\"table table-dark text-center\">\r\n        <thead>\r\n            ");
            EndContext();
            BeginContext(568, 116, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
       Write(Html.ActionLink(" Create Storage", "CreateAdmin","Admin", null, new { @class = "btn btn-primary btn-sm btn-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(684, 62, true);
            WriteLiteral("\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(747, 105, false);
#line 21 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(Html.ActionLink("Id", "GetAdmins", new { sortOrder = ViewBag.Id, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
            EndContext();
            BeginContext(852, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(920, 117, false);
#line 24 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(Html.ActionLink("LastName", "GetAdmins", new { sortOrder = ViewBag.LastName, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 145, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Information\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1183, 119, false);
#line 30 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(Html.ActionLink("FirstName", "GetAdmins", new { sortOrder = ViewBag.FirstName, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 223, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Role\r\n                </th>\r\n                <th>\r\n                    Delete\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1582, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1643, 15, false);
#line 45 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(item.EmployeeId);

#line default
#line hidden
            EndContext();
            BeginContext(1658, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1726, 13, false);
#line 48 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1739, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1807, 114, false);
#line 51 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(Html.ActionLink("Information", "GetAdmin", "Admin", new { id = item.EmployeeId }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(1921, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1989, 14, false);
#line 54 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2003, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2071, 9, false);
#line 57 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(item.Role);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2148, 114, false);
#line 60 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
               Write(Html.ActionLink("Delete", "DeleteAdmin", "Admin", new { id = item.EmployeeId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
            }

#line default
#line hidden
            BeginContext(2321, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2378, 39, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n");
                EndContext();
#line 69 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
     if (!ViewContext.ViewData.ModelState.IsValid)
    {
        var sb = new StringBuilder();
        foreach (var modelState in ViewContext.ViewData.ModelState.Values)
        {
            foreach (var error in modelState.Errors)
            {
                sb.Append(error.ErrorMessage);
            }
        }

#line default
#line hidden
                BeginContext(2745, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2755, 7, true);
                WriteLiteral("alert(\'");
                EndContext();
                BeginContext(2763, 13, false);
#line 79 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
            Write(sb.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2776, 5, true);
                WriteLiteral("\');\r\n");
                EndContext();
#line 80 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\GetAdmins.cshtml"
    }

#line default
#line hidden
                BeginContext(2788, 15, true);
                WriteLiteral("    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyUniversityProject.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
