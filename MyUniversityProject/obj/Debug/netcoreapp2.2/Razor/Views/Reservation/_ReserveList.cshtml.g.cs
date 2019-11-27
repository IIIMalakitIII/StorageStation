#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c346ad9b7c59941763593c4efaa19b353509910"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation__ReserveList), @"mvc.1.0.view", @"/Views/Reservation/_ReserveList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/_ReserveList.cshtml", typeof(AspNetCore.Views_Reservation__ReserveList))]
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
#line 1 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
using MyUniversityProject.Models.Pagination;

#line default
#line hidden
#line 2 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
using MyUniversityProject.Models.FilterModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c346ad9b7c59941763593c4efaa19b353509910", @"/Views/Reservation/_ReserveList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation__ReserveList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexReserveAdminModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "GetReservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::MyUniversityProject.Helpers.PageLinkTagHelper __MyUniversityProject_Helpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
  
    ViewData["Title"] = "ReservationHistory";

#line default
#line hidden
            BeginContext(221, 62, true);
            WriteLiteral("\r\n<h1 class=\"text-center\">Reservation History</h1>\r\n<br />\r\n\r\n");
            EndContext();
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
 if (Model.Reservations.Any())
{

#line default
#line hidden
            BeginContext(318, 83, true);
            WriteLiteral("    <ul class=\"list-group bg-dark\">\r\n        <li class=\"list-group-item bg-dark\">\r\n");
            EndContext();
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
             foreach (var item in Model.Reservations)
            {

#line default
#line hidden
            BeginContext(471, 210, true);
            WriteLiteral("                <div class=\"wrapper-reserv\">\r\n                    <div class=\"wrapped-div-2\">\r\n                        <div class=\"col-md-12 offset-md-0\">\r\n                            <div class=\"form-group\">\r\n");
            EndContext();
#line 23 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                 if (item.Status)
                                {

#line default
#line hidden
            BeginContext(767, 100, true);
            WriteLiteral("                                    <div class=\"btn btn-success btn-block text-white\">Active</div>\r\n");
            EndContext();
#line 26 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(975, 104, true);
            WriteLiteral("                                    <div class=\"btn btn-danger btn-block text-white\">Deactivated</div>\r\n");
            EndContext();
#line 30 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                }

#line default
#line hidden
            BeginContext(1114, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1687, 243, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(1931, 94, false);
#line 40 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "Reservation Id", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2068, 125, false);
#line 41 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.ReservationId, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 244, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(2438, 87, false);
#line 46 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "Cell Id", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2525, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2568, 118, false);
#line 47 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.CellId, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 327, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        ");
            EndContext();
            BeginContext(3014, 97, false);
#line 54 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "Start Reservation", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3111, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3154, 128, false);
#line 55 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.StartReservation, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3282, 244, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(3527, 95, false);
#line 60 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "End Reservation", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3622, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3665, 126, false);
#line 61 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.EndReservation, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3791, 327, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        ");
            EndContext();
            BeginContext(4119, 85, false);
#line 68 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "Price", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4204, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4247, 150, false);
#line 69 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.Amount, new { htmlAttributes = new { @class = "form-control", @step = "any", @value = "0.00", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4397, 244, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(4642, 92, false);
#line 74 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "Storage Name", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4734, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4777, 133, false);
#line 75 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.Cell.Storage.Location, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4910, 244, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-4\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(5155, 87, false);
#line 80 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.Label("", "User Id", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(5242, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5285, 122, false);
#line 81 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                                   Write(Html.EditorFor(model => item.UserInfoId, new { htmlAttributes = new { @class = "form-control", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5407, 297, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    ");
            EndContext();
            BeginContext(5705, 135, false);
#line 88 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                               Write(Html.ActionLink("Information", "GetReserve", "Reservation", new { id = item.ReservationId }, new { @class = "btn btn-info btn-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(5840, 134, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    ");
            EndContext();
            BeginContext(5975, 182, false);
#line 91 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
                               Write(Html.ActionLink("Delete", "DeleteReserve", "Reservation", new { reserveId = item.ReservationId, page = @Model.PageViewModel.PageNumber }, new { @class = "btn btn-danger btn-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(6157, 164, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 98 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
            }

#line default
#line hidden
            BeginContext(6336, 116, true);
            WriteLiteral("        </li>\r\n        <li class=\"list-group-item-secondary text-center\" style=\"list-style-type:none\">\r\n            ");
            EndContext();
            BeginContext(6452, 856, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c346ad9b7c59941763593c4efaa19b35350991018117", async() => {
                BeginContext(7282, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __MyUniversityProject_Helpers_PageLinkTagHelper = CreateTagHelper<global::MyUniversityProject.Helpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__MyUniversityProject_Helpers_PageLinkTagHelper);
#line 101 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageModel = Model.PageViewModel;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MyUniversityProject_Helpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __MyUniversityProject_Helpers_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-SearchFilter", "MyUniversityProject.Helpers.PageLinkTagHelper", "PageUrlValues"));
            }
#line 102 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SearchFilter"] = Model.ReserveAdminViewModel.SearchFilter;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-SearchFilter", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SearchFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 103 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SortItem"] = Model.ReserveAdminViewModel.SortItem;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-SortItem", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SortItem"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 104 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["MinPrice"] = Model.ReserveAdminViewModel.MinPrice;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-MinPrice", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["MinPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 105 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["MaxPrice"] = Model.ReserveAdminViewModel.MaxPrice;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-MaxPrice", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["MaxPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 106 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SearchValue"] = Model.ReserveAdminViewModel.SearchValue;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-SearchValue", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SearchValue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 107 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["FirstDate"] = (Model.ReserveAdminViewModel.FirstDate==null ? null:Model.ReserveAdminViewModel.FirstDate.Value.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-FirstDate", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["FirstDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 108 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
__MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SecondDate"] = (Model.ReserveAdminViewModel.SecondDate==null ? null:Model.ReserveAdminViewModel.SecondDate.Value.Date.ToString("yyyy-MM-dd"));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-SecondDate", __MyUniversityProject_Helpers_PageLinkTagHelper.PageUrlValues["SecondDate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7308, 28, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
            EndContext();
#line 112 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(7348, 55, true);
            WriteLiteral("    <br />\r\n    <h1>Doesn\'t have any Reservation</h1>\r\n");
            EndContext();
#line 117 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\_ReserveList.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexReserveAdminModel> Html { get; private set; }
    }
}
#pragma warning restore 1591