#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d57377748b489b6cdc83ab6fe5943db7fc0e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Index), @"mvc.1.0.view", @"/Views/Reservation/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservation/Index.cshtml", typeof(AspNetCore.Views_Reservation_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d57377748b489b6cdc83ab6fe5943db7fc0e38", @"/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ade478114418871ab43e38a2e377a8ee271c89", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.ReservationModel.ReservationLuggage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/icons8-цветные-48.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/icons8-trash-can-48.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(114, 103, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div-1\">\r\n        <div class=\"col-md-12 offset-md-0\">\r\n");
            EndContext();
#line 10 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
             using (Html.BeginForm("Index", "Reservation", new { htmlAttributes = new { @class = "mb-4" } }))
            {
                

#line default
#line hidden
            BeginContext(360, 39, false);
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
           Write(Html.HiddenFor(model => model.Storages));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                                        ;
                

#line default
#line hidden
            BeginContext(419, 23, false);
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(444, 59, true);
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                ");
            EndContext();
            BeginContext(504, 64, false);
#line 15 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(568, 159, true);
            WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(728, 127, false);
#line 19 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                       Write(Html.LabelFor(model => model.StartReservation, "Date Reservation", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(855, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(886, 167, false);
#line 20 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                       Write(Html.EditorFor(model => model.StartReservation, new { htmlAttributes = new { @class = "form-control", @type = "date", @min = "1899-01-01", @id = "listingDateOpen" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1084, 94, false);
#line 21 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                       Write(Html.ValidationMessageFor(model => model.StartReservation, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1363, 127, false);
#line 26 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                       Write(Html.LabelFor(model => model.StartReservation, "Date Reservation", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1521, 125, false);
#line 27 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                       Write(Html.DropDownListFor(model => model.SelectedStorage, Model.Storages as List<SelectListItem>, new { @class = "form-control"} ));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 275, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    ");
            EndContext();
            BeginContext(1922, 115, false);
#line 34 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.LabelFor(model => model.Time, "Time Reservation", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2037, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2076, 109, false);
#line 35 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.EditorFor(model => model.Time, new { htmlAttributes = new { @class = "form-control", @type = "time" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2224, 82, false);
#line 36 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Time, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 224, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <div class=\"form-group\">\r\n                                    ");
            EndContext();
            BeginContext(2531, 121, false);
#line 41 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.LabelFor(model => model.HowManyHours, "How Many Hours", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2652, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2691, 156, false);
#line 42 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.EditorFor(model => model.HowManyHours, new { htmlAttributes = new { @class = "form-control", @placeholder = "In Hours", @min = 1, @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2847, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2886, 90, false);
#line 43 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.HowManyHours, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2976, 210, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div>\r\n                            <table id=\"luggageBlock\" class=\"table\">\r\n");
            EndContext();
#line 49 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                 if (Model != null)
                                {
                                    for (int i = 0; i < Model.Luggages.Count; i++)
                                    {

#line default
#line hidden
            BeginContext(3397, 239, true);
            WriteLiteral("                                        <tr class=\'form-group\' name=\'record\'>\r\n                                            <td class=\'align-bottom\'>\r\n                                                <label class=\'control-label text-white\'> ");
            EndContext();
            BeginContext(3638, 5, false);
#line 55 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                                                                     Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3644, 178, true);
            WriteLiteral("</label>\r\n                                            </td>\r\n                                            <td class=\'form-group\'>\r\n                                                ");
            EndContext();
            BeginContext(3823, 89, false);
#line 58 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.Label("Width", "Width", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3912, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3963, 136, false);
#line 59 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.EditorFor(model => Model.Luggages[i].Width, new { htmlAttributes = new { @class = "form-control", @min = "0", @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4099, 170, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\'form-group\'>\r\n                                                ");
            EndContext();
            BeginContext(4270, 91, false);
#line 62 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.Label("Height", "Height", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4361, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4412, 137, false);
#line 63 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.EditorFor(model => Model.Luggages[i].Height, new { htmlAttributes = new { @class = "form-control", @min = "0", @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4549, 170, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\'form-group\'>\r\n                                                ");
            EndContext();
            BeginContext(4720, 91, false);
#line 66 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.Label("Length", "Length", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4811, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4862, 137, false);
#line 67 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.EditorFor(model => Model.Luggages[i].Length, new { htmlAttributes = new { @class = "form-control", @min = "0", @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4999, 170, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\'form-group\'>\r\n                                                ");
            EndContext();
            BeginContext(5170, 95, false);
#line 70 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.Label("Capacity", "Capacity", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(5265, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(5316, 139, false);
#line 71 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                           Write(Html.EditorFor(model => Model.Luggages[i].Capacity, new { htmlAttributes = new { @class = "form-control", @min = "0", @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5455, 97, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            ");
            EndContext();
            BeginContext(5553, 89, false);
#line 73 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                       Write(Html.ValidationMessageFor(model => Model.Luggages[i], "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5642, 49, true);
            WriteLiteral("\r\n                                        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(5765, 345, true);
            WriteLiteral(@"                            </table>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <a class=""addLink text-white btn btn-success btn-block"">
                                            ");
            EndContext();
            BeginContext(6110, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3d57377748b489b6cdc83ab6fe5943db7fc0e3821834", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6192, 452, true);
            WriteLiteral(@"
                                            Add Luggage
                                        </a>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <a class=""text-white btn btn-danger btn-block"" id=""remove"">
                                            ");
            EndContext();
            BeginContext(6644, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3d57377748b489b6cdc83ab6fe5943db7fc0e3823714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6743, 445, true);
            WriteLiteral(@"
                                            Remove Luggage
                                        </a>
                                    </div>
                                </div>
                            </div>
                            <div class=""row text-center"">
                                <div class=""col-md-8"">
                                    <div class=""form-group"">
                                        ");
            EndContext();
            BeginContext(7189, 154, false);
#line 99 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                   Write(Html.LabelFor(model => model.DivideTheLuggage, "Put in the cell those baggage that fit", htmlAttributes: new { @class = "control-label text-white pt-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(7343, 244, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-md-3\">\r\n                                    <div class=\"form-group\">\r\n                                        ");
            EndContext();
            BeginContext(7588, 235, false);
#line 104 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                                   Write(Html.CheckBoxFor(model => model.DivideTheLuggage, htmlAttributes: new { @class = "form-control", @type = "checkbox", @checked = true, @data_toggle = "toggle", @data_onstyle = "success", @data_offstyle = "danger", @data_width = "100" }));

#line default
#line hidden
            EndContext();
            BeginContext(7823, 395, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <input type=""submit"" value=""Make Reservation"" class=""btn btn-success btn-lg btn-block"" />
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 113 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8241, 1918, true);
            WriteLiteral(@"                    <div class=""accordion"" id=""accordionExample"">
                        <div class=""card-header text-center"" id=""headingOne"">
                            <button class=""btn btn-info"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                                How To Make Reservation ?
                            </button>
                        </div>
                        <div id=""collapseOne"" class=""collapse show bg-white"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <p>
                                    Anim pariatur cliche reprehenderit,
                                    enim eiusmod high life accusamus terry richardson ad squid.
                                    3 wolf moon officia aute, non cupidatat skateboard dolor brunch.
                                    Food truck quinoa nesciunt laborum ei");
            WriteLiteral(@"usmod. Brunch 3 wolf moon tempor,
                                </p>
                                <br />
                                <p>
                                    sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et.
                                    Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
                                    Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table,
                                    raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus
                                    labore sustainable VHS.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10181, 65, true);
                WriteLiteral("\r\n        <script>\r\n        $(function () {\r\n            var i = ");
                EndContext();
                BeginContext(10248, 37, false);
#line 146 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                Write(Model==null ? 0: Model.Luggages.Count);

#line default
#line hidden
                EndContext();
                BeginContext(10286, 578, true);
                WriteLiteral(@";
            $('.addLink').click(function () {
                if (i >= 4) {
                    alert(""Max count of luggages 4"")
                }
                else {
                    var html2Add =
                        ""<tr class='form-group' name='record'>"" +
                            ""<td class='align-bottom'>"" +
                                ""<label class = 'control-label text-white'>"" + (i + 1) + "" "" + ""</label>"" +
                            ""</td>"" +
                            ""<td class='form-group'>"" +
                                '");
                EndContext();
                BeginContext(10865, 89, false);
#line 158 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                            Write(Html.Label("Width", "Width", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(10954, 261, true);
                WriteLiteral(@"' +
                                ""<input class = 'form-control' type='number' min = '0' name='Luggages["" + i + ""].Width' />"" +
                            ""</td>"" +
                            ""<td class='form-group'>"" +
                                '");
                EndContext();
                BeginContext(11216, 91, false);
#line 162 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                            Write(Html.Label("Height", "Height", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(11307, 266, true);
                WriteLiteral(@"' +
                                ""<input class = 'form-control' type='number' min = '0' name='Luggages["" + i + ""].Height' />"" +
                            ""</td>"" +
                                ""<td class='form-group'>"" +
                                '");
                EndContext();
                BeginContext(11574, 91, false);
#line 166 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                            Write(Html.Label("Length", "Length", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(11665, 262, true);
                WriteLiteral(@"' +
                                ""<input class = 'form-control' type='number' min = '0' name='Luggages["" + i + ""].Length' />"" +
                            ""</td>"" +
                            ""<td class='form-group'>"" +
                                '");
                EndContext();
                BeginContext(11928, 95, false);
#line 170 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\Reservation\Index.cshtml"
                            Write(Html.Label("Capacity", "Capacity", htmlAttributes: new { @class = "control-label text-white" }));

#line default
#line hidden
                EndContext();
                BeginContext(12023, 1156, true);
                WriteLiteral(@"' +
                                ""<input class = 'form-control' type='number' min = '0' name='Luggages["" + i + ""].Capacity' />"" +
                            ""</td>"" +
                        ""</tr>"";
                    $('#luggageBlock').append(html2Add);
                    i++;
                }
            });
            $('#remove').on(""click"", function () {
                if (i > 0) {
                    --i;
                    $('.table tr:last').remove();
                }
            });
        });
        </script>
        <script>
            $(function () {
                let today = new Date(),
                    day = today.getDate(),
                    month = today.getMonth() + 1,
                    year = today.getFullYear();
                if (day < 10) {
                    day = '0' + day
                }
                if (month < 10) {
                    month = '0' + month
                }
                today = year + '-' + month + '-' + da");
                WriteLiteral("y;\r\n                document.getElementById(\"listingDateOpen\").setAttribute(\"min\", today);\r\n            });\r\n        </script>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.ReservationModel.ReservationLuggage> Html { get; private set; }
    }
}
#pragma warning restore 1591
