#pragma checksum "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageCells.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1503fb17eef4b6cab0879ebeac780586e1fdfff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storage_StorageCells), @"mvc.1.0.view", @"/Views/Storage/StorageCells.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Storage/StorageCells.cshtml", typeof(AspNetCore.Views_Storage_StorageCells))]
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
#line 1 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject;

#line default
#line hidden
#line 2 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using MyUniversityProject.Models.ErrorViewModel;

#line default
#line hidden
#line 4 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 5 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1503fb17eef4b6cab0879ebeac780586e1fdfff", @"/Views/Storage/StorageCells.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Storage_StorageCells : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.Pagination.IndexCellViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 55, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n        ");
            EndContext();
            BeginContext(121, 65, false);
#line 4 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageCells.cshtml"
   Write(await Html.PartialAsync("_CellFilter", Model.CellFilterViewModel));

#line default
#line hidden
            EndContext();
            BeginContext(186, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-7\">\r\n        ");
            EndContext();
            BeginContext(237, 46, false);
#line 7 "C:\Users\Latif\Documents\GitHub\StorageStation\MyUniversityProject\Views\Storage\StorageCells.cshtml"
   Write(await Html.PartialAsync("_ListOfCells", Model));

#line default
#line hidden
            EndContext();
            BeginContext(283, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.Pagination.IndexCellViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
