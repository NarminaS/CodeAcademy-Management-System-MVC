#pragma checksum "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c253d1f9e61887165ee1cb3fa4b3d28e7b3bf08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Editor_Views_Tags_Index), @"mvc.1.0.view", @"/Areas/Editor/Views/Tags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Editor/Views/Tags/Index.cshtml", typeof(AspNetCore.Areas_Editor_Views_Tags_Index))]
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
using CodeAcademy.Areas.Editor;

#line default
#line hidden
#line 4 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\_ViewImports.cshtml"
using CodeAcademy.Components.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
using CodeAcademy.Areas.Editor.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c253d1f9e61887165ee1cb3fa4b3d28e7b3bf08", @"/Areas/Editor/Views/Tags/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d993feb7724ee4e7c8aa754143af9eb4c94fbf", @"/Areas/Editor/Views/_ViewImports.cshtml")]
    public class Areas_Editor_Views_Tags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TagFacultyViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Editor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(106, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(135, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f1db9c571e4f3994830a40c41665f5", async() => {
                BeginContext(141, 189, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js\"></script>\r\n    <title>Tag Crud page</title>\r\n");
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
            BeginContext(337, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(339, 5285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1fe9487993e47e98980f3763b7d638a", async() => {
                BeginContext(345, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(352, 77, false);
#line 16 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
Write(await Component.InvokeAsync("UpperPanel", new { email = User.Identity.Name }));

#line default
#line hidden
                EndContext();
                BeginContext(429, 42, true);
                WriteLiteral("\r\n    <h1>TAG CRUD!!!</h1>\r\n    <br />\r\n\r\n");
                EndContext();
#line 20 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
     if (!Model.Tags.Any())
    {

#line default
#line hidden
                BeginContext(507, 29, true);
                WriteLiteral("        <h4>No tags...</h4>\r\n");
                EndContext();
#line 23 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(543, 348, true);
                WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <input type=""button"" class=""btn btn-info"" id=""open-create-tag"" value=""New Tag"" />
            </div>
        </div>
    </div>
    <br />
    <div class=""container"">
        <div class=""row col-sm-5"">
            <div class=""tags"">
");
                EndContext();
#line 35 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                 foreach (var tag in Model.Tags)
                {

#line default
#line hidden
                BeginContext(960, 93, true);
                WriteLiteral("                    <div class=\"badge badge-dark tag\">\r\n                        <input hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1068, 1);
#line 38 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
WriteAttributeValue("", 1061, tag.Id, 1061, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1069, 45, true);
                WriteLiteral(" />\r\n                        <p class=\"lead\">");
                EndContext();
                BeginContext(1115, 8, false);
#line 39 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                                   Write(tag.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1123, 136, true);
                WriteLiteral("</p>\r\n                        <input type=\"button\" class=\"btn btn-sm btn-warning tag-edit\" value=\"Edit\" />\r\n                    </div>\r\n");
                EndContext();
#line 42 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1278, 52, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
                EndContext();
                BeginContext(1354, 230, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div id=\"new-tag\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">New Tag</h5>\r\n                    ");
                EndContext();
                BeginContext(1584, 987, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9faf6c899c4fb9b3b0135605bb56b0", async() => {
                    BeginContext(1713, 145, true);
                    WriteLiteral("\r\n                        <label for=\"FacultyId\">Choose Faculty</label>\r\n                        <select name=\"FacultyId\" class=\"form-control\">\r\n");
                    EndContext();
#line 57 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                             foreach (var faculty in Model.Faculties)
                            {

#line default
#line hidden
                    BeginContext(1960, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(1992, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e045f1c2295457f83b4723c2a50ae95", async() => {
                        BeginContext(2021, 12, false);
#line 59 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                                                       Write(faculty.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                                   WriteLiteral(faculty.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2042, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 60 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                            }

#line default
#line hidden
                    BeginContext(2075, 489, true);
                    WriteLiteral(@"                        </select>
                        <label for=""name"">Name</label>
                        <input type=""text"" name=""name"" id=""create-tag-name"" placeholder=""Tag name..."" class=""form-control"" />
                        <br />
                        <input type=""submit"" value=""Create Tag"" id=""submit-create"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""close-create-tag"" class=""btn btn-danger"" />
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
                BeginContext(2571, 76, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
                BeginContext(2672, 232, true);
                WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <div id=\"edit-tag\" class=\"custom-modal\">\r\n                    <h5 class=\"h5 text-center\">Edit Tag</h5>\r\n                    ");
                EndContext();
                BeginContext(2904, 1022, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dd027a67024b24897601283759d660", async() => {
                    BeginContext(3031, 205, true);
                    WriteLiteral("\r\n                        <input type=\"hidden\" id=\"id\" name=\"Id\" value=\"\" />\r\n                        <label>Choose Faculty</label>\r\n                        <select name=\"FacultyId\" class=\"form-control\">\r\n");
                    EndContext();
#line 83 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                             foreach (var faculty in Model.Faculties)
                            {

#line default
#line hidden
                    BeginContext(3338, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                    BeginContext(3370, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30c2847aa6b44afa8d778f16d55db610", async() => {
                        BeginContext(3399, 12, false);
#line 85 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                                                       Write(faculty.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                                   WriteLiteral(faculty.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3420, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 86 "C:\Users\Руфат\source\CodeAcademy-Management-System\CodeAcademy\Areas\Editor\Views\Tags\Index.cshtml"
                            }

#line default
#line hidden
                    BeginContext(3453, 466, true);
                    WriteLiteral(@"                        </select>
                        <label for=""name"">Name</label>
                        <input type=""text"" name=""name"" id=""edit-tag-name"" placeholder=""Tag name..."" class=""form-control"" />
                        <br />
                        <input type=""submit"" value=""Update Tag"" class=""btn btn-success"" />
                        <input type=""button"" value=""Close"" id=""close-edit-tag"" class=""btn btn-danger"" />
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
                BeginContext(3926, 1691, true);
                WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <style>
        .tags {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
            align-items: flex-start;
            align-content: flex-start;
        }
        .tags >*{
            margin:.5vh;
        }

        .custom-modal {
            padding: 2vh;
            display: none;
            position: fixed;
            width: 25vw;
            z-index: 3;
            top: 15vh;
            left: 35vw;
            overflow: auto;
            border: 1px solid black;
            border-radius: 1vh;
            background-color: #ababab;
        }
    </style>

    <script>
        var tagId;
        var tagName;

        $(""#open-create-tag"").click(function () {
            $(""#new-tag"").css(""display"", ""block"");
        });

        $(""#close-create-tag"").click(function () {
            $(""#new-tag"").css(""display"",""none"");
        });

");
                WriteLiteral(@"
        $("".tag-edit"").click(function (e) {
            tagId = $(e.target).parent().children().first().val();
            tagName = $(e.target).parent().children().first().next().text()
            $(""#edit-tag"").css(""display"", ""block"");
            $(""#edit-tag form #id"").val(tagId);
            $(""#edit-tag form #edit-tag-name"").val(tagName);
        });

        $(""#close-edit-tag"").click(function () {
            $(""#edit-tag"").css(""display"", ""none"");
        });

        document.getElementById(""submit-create"").addEventListener(""click"", function () {
            $.ajax({

            })
                .done
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
            BeginContext(5624, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TagFacultyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
