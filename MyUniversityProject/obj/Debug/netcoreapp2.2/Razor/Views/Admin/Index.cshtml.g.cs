#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d6385ba5ead7234e1ba05c3c13db84e372880f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d6385ba5ead7234e1ba05c3c13db84e372880f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 205, true);
            WriteLiteral("\r\n<br/>\r\n<div class=\"row d-flex justify-content-center\">\r\n    <div class=\"col-md-3\">\r\n        <ul class=\"list-group bg-dark text-center\">\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            EndContext();
            BeginContext(291, 115, false);
#line 11 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Work with Storage", "GetAllStorage", "Storage", null, new { @class = "btn btn-outline-success " }));

#line default
#line hidden
            EndContext();
            BeginContext(406, 87, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            EndContext();
            BeginContext(494, 105, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Create Cell", "CreateCell", "Storage", null, new { @class = "btn btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(599, 87, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            EndContext();
            BeginContext(687, 103, false);
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("User Information", "Users", "Admin", null, new { @class = "btn btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(790, 87, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            EndContext();
            BeginContext(878, 109, false);
#line 20 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Admin Settings", "AdminSettings", "Admin", null, new { @class = "btn btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(987, 87, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"list-group-item bg-dark\">\r\n                ");
            EndContext();
            BeginContext(1075, 118, false);
#line 23 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Admin\Index.cshtml"
           Write(Html.ActionLink("Reservation Info", "AllReservation", "Reservation", null, new { @class = "btn btn-outline-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 60, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
