#pragma checksum "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d6fc5d86e8e268bc54ab79ddcb5b5d6d4e0c79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Editor_Views_Teachers_List), @"mvc.1.0.view", @"/Areas/Editor/Views/Teachers/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Editor/Views/Teachers/List.cshtml", typeof(AspNetCore.Areas_Editor_Views_Teachers_List))]
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
#line 1 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy;

#line default
#line hidden
#line 2 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Models;

#line default
#line hidden
#line 3 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Areas.Admin.Models;

#line default
#line hidden
#line 4 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Components.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml"
using CodeAcademy.Areas.Editor.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d6fc5d86e8e268bc54ab79ddcb5b5d6d4e0c79e", @"/Areas/Editor/Views/Teachers/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac37bf94f0ab55bffa43146f51a3323212eb12dc", @"/Areas/Editor/Views/_ViewImports.cshtml")]
    public class Areas_Editor_Views_Teachers_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TeacherViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Editor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teachers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(109, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(136, 410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d677a7e2c694c4285b2adee6c89aee8", async() => {
                BeginContext(142, 397, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <title>List</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(546, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(548, 4038, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77a36fb64948437cb0471aadd7e688f2", async() => {
                BeginContext(554, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(561, 77, false);
#line 16 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml"
Write(await Component.InvokeAsync("UpperPanel", new { email = User.Identity.Name }));

#line default
#line hidden
                EndContext();
                BeginContext(638, 42, true);
                WriteLiteral("\r\n    <h1>TAG CRUD!!!</h1>\r\n    <br />\r\n\r\n");
                EndContext();
#line 20 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
                BeginContext(711, 33, true);
                WriteLiteral("        <h4>No teachers...</h4>\r\n");
                EndContext();
#line 23 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Teachers\List.cshtml"
    }

#line default
#line hidden
                BeginContext(751, 261, true);
                WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <input type=""button"" class=""btn btn-info"" id=""open-create-teacher"" value=""New Teacher"" />
            </div>
        </div>
    </div>
    <br />

");
                EndContext();
                BeginContext(1040, 238, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div id=\"new-teacher\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">New Teacher</h5>\r\n                    ");
                EndContext();
                BeginContext(1278, 1606, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "badc08f0770d413b8804584f59d093a8", async() => {
                    BeginContext(1411, 1466, true);
                    WriteLiteral(@"
                        <label>Name</label>
                        <input type=""text"" class=""form-control"" required name=""Name"" value="""" />
                        <label>Surname</label>
                        <input type=""text"" class=""form-control"" required name=""Surname"" value="""" />
                        <label>Birth date</label>
                        <input type=""date"" class=""form-control"" required name=""birthdate"" value="""" />
                        <label>Phone Number</label>
                        <input type=""tel"" class=""form-control"" required name=""phonenumber"" value="""" />
                        <label>Email</label>
                        <input type=""email"" class=""form-control"" required name=""email"" value="""" />
                        <label>Password</label>
                        <input type=""password"" class=""form-control"" required name=""password"" value="""" />
                        <label>Gender</label>
                        <select name=""GenderId"" id=""gender"" class=""form");
                    WriteLiteral(@"-control""></select>
                        <label>Faculty</label>
                        <select name=""FacultyId"" id=""faculty"" class=""form-control""></select>
                        <br />
                        <input type=""submit"" value=""Create Teacher"" id=""submit-create"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""close-create-teacher"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2884, 1695, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>


    <style>
        .custom-modal {
            padding: 2vh;
            display: none;
            position: fixed;
            width: 25vw;
            z-index: 3;
            top: 5vh;
            left: 35vw;
            overflow: auto;
            border: 1px solid black;
            border-radius: 1vh;
            background-color: #ababab;
        }
    </style>
    <script>
        $(""#open-create-teacher"").click(function () {
            $(""#new-teacher"").css(""display"", ""block"");
        });

        $(""#close-create-teacher"").click(function () {
            $(""new-teacher"").css(""display"", ""none"");
        });

        $.ajax({
            method: ""GET"",
            url: ""/Editor/Teachers/GetFaculties"",
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var fac = document.createElement(""option"");
                    fac.value = dat");
                WriteLiteral(@"a[i].id;
                    fac.innerText = data[i].name
                    document.getElementById(""faculty"").appendChild(fac);
                }
            },
        });

        $.ajax({
            method: ""GET"",
            url: ""/Editor/Teachers/GetGenders"",
            success: function (data) {
                for (var i = 0; i < data.length; i++) {
                    var gen = document.createElement(""option"");
                    gen.value = data[i].id;
                    gen.innerText = data[i].name
                    document.getElementById(""gender"").appendChild(gen);
                }
            },
        })
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4586, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TeacherViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591