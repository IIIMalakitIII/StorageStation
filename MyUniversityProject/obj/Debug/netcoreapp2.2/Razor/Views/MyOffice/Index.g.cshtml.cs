#pragma checksum "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eceeee4438f5da50b91d1ac60fa86858233af847"
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
#line 1 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
using MyUniversityProject.Models.AuthenticationModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eceeee4438f5da50b91d1ac60fa86858233af847", @"/Views/MyOffice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ade478114418871ab43e38a2e377a8ee271c89", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOffice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(142, 165, true);
            WriteLiteral("<table class=\"table\">\r\n    <tr>\r\n        <th>Change User Information</th>\r\n        <th>Additional Information</th>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n\r\n            ");
            EndContext();
            BeginContext(308, 43, false);
#line 15 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
       Write(await Html.PartialAsync("_UserInformation"));

#line default
#line hidden
            EndContext();
            BeginContext(351, 45, true);
            WriteLiteral("\r\n\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(397, 162, false);
#line 19 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
       Write(Html.ActionLink("Check History of Reservation", "Reservation", "MyOffice", new { area = "" }, new { @class = "btn btn-danger my-2 my-sm-0 my-margin-for-button" }));

#line default
#line hidden
            EndContext();
            BeginContext(559, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(574, 148, false);
#line 20 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
       Write(Html.ActionLink("Сheck Messages", "UserMessage", "MyOffice", new { area = "" }, new { @class = "btn btn-danger my-2 my-sm-0 my-margin-for-button" }));

#line default
#line hidden
            EndContext();
            BeginContext(722, 64, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(787, 64, false);
#line 25 "C:\Users\Latif\source\repos\MyUniversityProject\MyUniversityProject\Views\MyOffice\Index.cshtml"
       Write(await Html.PartialAsync("_ChangePassword", new ChangePassword()));

#line default
#line hidden
            EndContext();
            BeginContext(851, 41, true);
            WriteLiteral(";\r\n        </td>\r\n    </tr>\r\n\r\n</table>\r\n");
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
