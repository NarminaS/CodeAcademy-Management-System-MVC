#pragma checksum "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81fd7a2a13fce40597f1219c158c0b66008f28ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Editors_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Editors/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Editors/List.cshtml", typeof(AspNetCore.Areas_Admin_Views_Editors_List))]
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
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy;

#line default
#line hidden
#line 2 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy.Models;

#line default
#line hidden
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\_ViewImports.cshtml"
using CodeAcademy.Areas.Admin.Models;

#line default
#line hidden
#line 1 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
using CodeAcademy.Areas.Admin.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fd7a2a13fce40597f1219c158c0b66008f28ee", @"/Areas/Admin/Views/Editors/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778857f70f4cdec2b405a49d526b1807f09cd39b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Editors_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(113, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(123, 410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eebd489dcf674aaebe7740c64602c2ba", async() => {
                BeginContext(129, 397, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>List</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
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
            BeginContext(533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(535, 6685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f356e128faa8424f857e601b9013c90b", async() => {
                BeginContext(541, 360, true);
                WriteLiteral(@"
    <div class=""container-fluid"">
        <h3 style=""color:red"">Editors CRUD page</h3>
        <br />
        <input type=""button"" id=""showform"" value=""Create new editor"" class=""btn btn-info"" />
        <br />
        <br />
    </div>
    <div class=""container-fluid"">
        <div class=""row"">
            <div id=""editorsList"" class=""col-sm-5"">
");
                EndContext();
#line 25 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                  
                    if (!Model.Any())
                    {

#line default
#line hidden
                BeginContext(983, 48, true);
                WriteLiteral("                        <h5>No editors...</h5>\r\n");
                EndContext();
#line 29 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(1073, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                 foreach (var editor in Model)
                {

#line default
#line hidden
                BeginContext(1142, 37, true);
                WriteLiteral("                    <span class=\"h5\">");
                EndContext();
                BeginContext(1180, 11, false);
#line 34 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                                Write(editor.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1191, 53, true);
                WriteLiteral(" &nbsp </span>\r\n                    <span class=\"h5\">");
                EndContext();
                BeginContext(1245, 12, false);
#line 35 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                                Write(editor.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1257, 347, true);
                WriteLiteral(@" &nbsp</span>
                    <input type=""button"" class=""btn btn-info editInfo"" value=""Edit"" />
                    <input type=""button"" value=""Delete"" class=""openSubmit btn btn-danger"" />
                    <br />
                    <hr />
                    <div class=""submitDelete col-sm-8"">
                        <h6>The user ");
                EndContext();
                BeginContext(1605, 11, false);
#line 41 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                                Write(editor.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1616, 74, true);
                WriteLiteral(" will be deleted permanently. Are you sure?</h6>\r\n                        ");
                EndContext();
                BeginContext(1690, 300, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "276a4fc226484ed88cb765356ddd4d45", async() => {
                    BeginContext(1778, 50, true);
                    WriteLiteral("\r\n                            <input type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1828, "\"", 1846, 1);
#line 43 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
WriteAttributeValue("", 1836, editor.Id, 1836, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1847, 136, true);
                    WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"submitInput btn btn-danger btn-sm\" value=\"Yes\" />\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 42 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1990, 133, true);
                WriteLiteral("\r\n                        <input type=\"button\" value=\"No\" class=\"closeSubmit btn btn-primary btn-sm\" />\r\n                    </div>\r\n");
                EndContext();
#line 48 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
                }

#line default
#line hidden
                BeginContext(2142, 113, true);
                WriteLiteral("            </div>\r\n            <div class=\"col-sm-5\">\r\n                <div id=\"editForm\">\r\n                    ");
                EndContext();
                BeginContext(2255, 789, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a225bec4d7942f2a7e541a7989fc165", async() => {
                    BeginContext(2358, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(2384, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f9982facc1430aaf4a62f3083db1c5", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 53 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2430, 311, true);
                    WriteLiteral(@"
                        <label name=""Name"">Name</label><br />
                        <input class=""form-control"" type=""text"" name=""Name""><br />
                        <label name=""GenderId"">Gender</label>
                        <select class=""form-control"" name=""GenderId"">
                            ");
                    EndContext();
                    BeginContext(2741, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10bd754027124a50b4d80908b9afade7", async() => {
                        BeginContext(2759, 4, true);
                        WriteLiteral("Male");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2772, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(2802, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61a58656ec5f44eab20a5d131513358e", async() => {
                        BeginContext(2820, 6, true);
                        WriteLiteral("Female");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2835, 202, true);
                    WriteLiteral("\r\n                        </select>\r\n                        <br />\r\n                        <input type=\"button\" class=\"btn btn-warning\" id = \"confirmChange\" value=\"Change Info\"/>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 52 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3044, 227, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div id=\"createform\">\r\n                    ");
                EndContext();
                BeginContext(3271, 1138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a98eb1fc5b49da85d1a222a029a26c", async() => {
                    BeginContext(3376, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(3402, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c678374789e64ae28004c634ea5aa1ed", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 74 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3448, 580, true);
                    WriteLiteral(@"
                        <label name=""Name"">Name</label><br />
                        <input class=""form-control"" type=""text"" id=""Name""><br />
                        <label id=""Email"">Email</label><br />
                        <input class=""form-control"" type=""email"" name=""Email""><br />
                        <label name=""Password"">Password</label><br />
                        <input class=""form-control"" type=""password"" name=""Password"" /><br /><br />
                        <select class=""form-control"" name=""GenderId"" id=""GenderId"">
                            ");
                    EndContext();
                    BeginContext(4028, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d389720ee571419eb97b0e651dddd4ce", async() => {
                        BeginContext(4046, 4, true);
                        WriteLiteral("Male");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4059, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(4089, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b83522bea9946e9b53144fbbb0ef23b", async() => {
                        BeginContext(4107, 6, true);
                        WriteLiteral("Female");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4122, 280, true);
                    WriteLiteral(@"
                        </select>
                        <br />
                        <input type=""submit"" value=""Create"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""closeCreate"" class=""btn btn-danger"" />
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
#line 73 "C:\Users\Руфат\source\repos\CodeAcademy\CodeAcademy\Areas\Admin\Views\Editors\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4409, 2804, true);
                WriteLiteral(@"
                </div>
            </div>

        </div>
    </div>

    <style>
        .submitDelete {
            line-height: 0 !important;
            height: 0;
            overflow: hidden;
            transition: 0.3s ease-in-out;
        }

        #createform {
            display: none;
        }

        .editor {
            border: 1px solid aqua;
            border-radius: 1vh;
            padding: 1vh;
            margin: 1vh;
        }

            .editor span {
                font-family: 'Comic Sans MS'sans-serif;
            }
    </style>

    <script>
        var userName;
        var userMail;

        $("".editInfo"").click(function (e) {
            userName = $(e.target).prev().prev().text();
            userMail = $(e.target).prev().text();
            $(""#editForm form input.form-control"").val(userName);
        })

        $(""#confirmChange"").click(function (e) {
            $.ajax({
                method: ""POST"",
                url:");
                WriteLiteral(@" ""/Admin/Editors/Edit/email"",
                data: {
                    email: userMail,
                    name: $(""#editForm form input.form-control"").val(),
                    genderId: $(e.target).prev().prev().val()
                }
                    
            })
                .done(function (obj) {
                    document.location.reload()
                })
        });

        $("".submitInput"").click(function (e) {
            var userId = $(e.target).prev().val();
            $.ajax({
                method: ""POST"",
                url: ""/Admin/Editors/Delete/id"",
                data: { id: userId }
            })
                .done(function (obj) {
                    document.location.reload()
                })

        })

        $("".openSubmit"").click(function (e) {
            $(e.target).next().next().next().css(""height"", ""100%"");
        })

        $("".closeSubmit"").click(function (e) {
            $(e.target.parentElement).css(""height"", """);
                WriteLiteral(@"0px"");
        })

        $(""#showform"").click(function () {
            $(""#createform"").css(""display"", ""block"");
        });

        $(""#closeCreate"").click(function () {
            $(""#createform"").css(""display"", ""none"");
        });

        function ProcessData() {
            $.ajax({
                method: ""POST"",
                url: ""/Admin/Editors/Create"",
                data: {
                    name:Name.value,
                    email: Email.value,
                    password: Password.value,
                    genderId: GenderId.value
                }
            })
                .done(function (obj) {
                    document.location.reload()
                })
        }

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
            BeginContext(7220, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
