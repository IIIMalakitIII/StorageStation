#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d59d41907f277b05ffeec1925c4960c7f6eaad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyOffice_Index), @"mvc.1.0.view", @"/Views/MyOffice/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyOffice/Index.cshtml", typeof(AspNetCore.Views_MyOffice_Index))]
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
#line 1 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Index.cshtml"
using MyUniversityProject.Models.AuthenticationModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d59d41907f277b05ffeec1925c4960c7f6eaad6", @"/Views/MyOffice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOffice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Index.cshtml"
  
    ViewData["Title"] = "MyOffice";

#line default
#line hidden
            BeginContext(145, 110, true);
            WriteLiteral("<h2 class=\"text-center\"> User Information </h2>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        ");
            EndContext();
            BeginContext(256, 48, false);
#line 11 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Index.cshtml"
   Write(await Html.PartialAsync("_OfficeForUser", Model));

#line default
#line hidden
            EndContext();
            BeginContext(304, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-5\">\r\n        ");
            EndContext();
            BeginContext(355, 64, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\Index.cshtml"
   Write(await Html.PartialAsync("_ChangePassword", new ChangePassword()));

#line default
#line hidden
            EndContext();
            BeginContext(419, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
