#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af05017246da35e78db0aca8c33b92c77abda3c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyOffice__UserFilter), @"mvc.1.0.view", @"/Views/MyOffice/_UserFilter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyOffice/_UserFilter.cshtml", typeof(AspNetCore.Views_MyOffice__UserFilter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af05017246da35e78db0aca8c33b92c77abda3c0", @"/Views/MyOffice/_UserFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOffice__UserFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.FilterModel.UserFilterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 112, true);
            WriteLiteral("\r\n\r\n<div class=\"wrapper-reserv\">\r\n    <div class=\"wrapped-div-2\">\r\n        <div class=\"col-md-12 offset-md-0\">\r\n");
            EndContext();
#line 7 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
             using (Html.BeginForm("GetUsers", "MyOffice", FormMethod.Get, new { @class = "mt-4" }))
            {

#line default
#line hidden
            BeginContext(296, 266, true);
            WriteLiteral(@"                <ul class=""list-group"">
                    <li class=""list-group-item bg-dark d-flex justify-content-center"">
                        <div class=""form-group"">
                            <div class=""input-group"">
                                ");
            EndContext();
            BeginContext(563, 121, false);
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                           Write(Html.DropDownListFor(x => x.SearchValue, Model.SearchParams, new { @class = "form-control", @Value = Model.SearchValue }));

#line default
#line hidden
            EndContext();
            BeginContext(684, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(719, 118, false);
#line 14 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                           Write(Html.EditorFor(x => x.SearchFilter, new { htmlAttributes = new { @class = "form-control", @placeholder = "Search" } }));

#line default
#line hidden
            EndContext();
            BeginContext(837, 233, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"list-group-item bg-dark\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1071, 89, false);
#line 20 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                       Write(Html.Label("", "Order by:", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1191, 111, false);
#line 21 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                       Write(Html.DropDownListFor(x => x.SortItem, Model.SortList, new { @class = "form-control", @Value = Model.SortItem }));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 308, true);
            WriteLiteral(@"
                        </div>
                    </li>
                    <li class=""list-group-item bg-dark"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1611, 84, false);
#line 28 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                               Write(Html.Label("", "From:", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1734, 98, false);
#line 29 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                               Write(Html.EditorFor(x => x.MinId, new { htmlAttributes = new { @class = "form-control", @min = "0" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(2057, 82, false);
#line 34 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                               Write(Html.Label("", "To:", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2178, 98, false);
#line 35 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
                               Write(Html.EditorFor(x => x.MaxId, new { htmlAttributes = new { @class = "form-control", @min = "0" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 348, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </li>
                    <li class=""list-group-item bg-dark"">
                        <input type=""submit"" class=""btn btn-primary btn-lg btn-block"" value=""Find"" />
                    </li>
                </ul>
");
            EndContext();
#line 44 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\_UserFilter.cshtml"
            }

#line default
#line hidden
            BeginContext(2639, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.FilterModel.UserFilterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591