#pragma checksum "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf68679442c82943a838a2d29cd74bf41628714b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyOffice_GetUser), @"mvc.1.0.view", @"/Views/MyOffice/GetUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyOffice/GetUser.cshtml", typeof(AspNetCore.Views_MyOffice_GetUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf68679442c82943a838a2d29cd74bf41628714b", @"/Views/MyOffice/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db963d04bd4b185239d217111c0291317422622", @"/Views/_ViewImports.cshtml")]
    public class Views_MyOffice_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyUniversityProject.Models.UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 161, true);
            WriteLiteral("\r\n<div class=\"wrapper\">\r\n    <div class=\"wrapped-div\">\r\n        <div class=\"tab-header\">\r\n            <div class=\"col-md-10 offset-md-1\">\r\n                <br>\r\n");
            EndContext();
#line 8 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                 using (Html.BeginForm("GetUser", "MyOffice", new { htmlAttributes = new { @class = "mb-4" } }))
                {
                    

#line default
#line hidden
            BeginContext(359, 23, false);
#line 10 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(384, 59, true);
            WriteLiteral("            <div class=\"form-horizontal\">\r\n                ");
            EndContext();
            BeginContext(444, 64, false);
#line 12 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(508, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(527, 39, false);
#line 13 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
           Write(Html.HiddenFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(566, 159, true);
            WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(726, 114, false);
#line 17 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.FirstName, "FirstName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(840, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(871, 126, false);
#line 18 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", @placeholder = "FirstName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(997, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1028, 87, false);
#line 19 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1300, 112, false);
#line 24 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.LastName, "LastName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1443, 128, false);
#line 25 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control hio", @placeholder = "LastName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1602, 86, false);
#line 26 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1873, 114, false);
#line 31 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.UserInfoId, "LastName", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2018, 152, false);
#line 32 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.UserInfoId, new { htmlAttributes = new { @class = "form-control hio", @placeholder = "UserId", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2201, 88, false);
#line 33 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.UserInfoId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 243, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2533, 116, false);
#line 40 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.PassportId, "PassportId", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(2649, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2680, 130, false);
#line 41 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.PassportId, new { htmlAttributes = new { @class = "form-control", @placeholder = "Pasport Code" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2810, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2841, 88, false);
#line 42 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PassportId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2929, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3114, 110, false);
#line 47 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.Address, "Address", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3224, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3255, 122, false);
#line 48 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control", @placeholder = "Address" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3377, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3408, 85, false);
#line 49 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3493, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3678, 104, false);
#line 54 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.Role, "Role", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(3782, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3813, 139, false);
#line 55 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.Role, new { htmlAttributes = new { @class = "form-control", @placeholder = "Role", @readonly ="readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3952, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3983, 82, false);
#line 56 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Role, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4065, 243, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4309, 106, false);
#line 63 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.Email, "Email", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(4415, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4446, 142, false);
#line 64 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", @placeholder = "Email", @readonly = "readonly" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4588, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4619, 83, false);
#line 65 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4702, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(4887, 118, false);
#line 70 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.LabelFor(model => model.PhoneNumber, "PhoneNumber", htmlAttributes: new { @class = "control-label  text-white" }));

#line default
#line hidden
            EndContext();
            BeginContext(5005, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5036, 124, false);
#line 71 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5160, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(5191, 89, false);
#line 72 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5280, 287, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Edit"" class=""btn btn-success btn-lg btn-block"" />
                    </div>
                </div>
");
            EndContext();
#line 80 "C:\Users\user\Documents\GitHub\StorageStation\MyUniversityProject\Views\MyOffice\GetUser.cshtml"
                }

#line default
#line hidden
            BeginContext(5586, 58, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyUniversityProject.Models.UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
