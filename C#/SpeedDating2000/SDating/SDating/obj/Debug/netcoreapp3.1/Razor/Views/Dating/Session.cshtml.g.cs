#pragma checksum "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13661f826d748438b2cbb44822807f9952e86af3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dating_Session), @"mvc.1.0.view", @"/Views/Dating/Session.cshtml")]
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
#nullable restore
#line 1 "C:\__SpeedDating2000\SDating\SDating\Views\_ViewImports.cshtml"
using SDating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\__SpeedDating2000\SDating\SDating\Views\_ViewImports.cshtml"
using SDating.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13661f826d748438b2cbb44822807f9952e86af3", @"/Views/Dating/Session.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14aafd3da86d1b9feeb13246b3b686b6e37ea41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dating_Session : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDating.Models.DatingSession>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/boy.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/girl.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/upload.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Загрузить фото"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Удалит участника"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/save.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/stat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
  
    ViewData["Title"] = "Ввод результатов совпадений";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ввод данных сессии</h1>\r\n\r\n<table class=\"blueTable_width_70\">\r\n    <tr>\r\n        <th>№</th>\r\n        <th>Имя</th>\r\n        <th>М/F</th>\r\n        <th><b>Фото</b></th>\r\n        <th><b>Cовпадения</b></th>\r\n        <th width=\"22\"></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
     foreach (PersonalBlanc blank in Model.PersonalBlancs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td valign=\"middle\" align=\"center\">");
#nullable restore
#line 23 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
                                          Write(blank.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td valign=\"middle\">");
#nullable restore
#line 24 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
                           Write(blank.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td valign=\"middle\" align=\"center\">\r\n");
#nullable restore
#line 26 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
                 if (@blank.isMan)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af37940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af39227", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n");
#nullable restore
#line 35 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
             if (String.IsNullOrEmpty(blank.Picture))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td align=\"center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1027, "\"", 1147, 1);
#nullable restore
#line 38 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
WriteAttributeValue("", 1034, Url.Action("Foto", "Dating", new { name = @blank.Name, tableId = @blank.TableId, sessionId = @Model.SessionID }), 1034, 113, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af311263", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </td>\r\n");
#nullable restore
#line 42 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 46 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
               Write(Html.ActionLink("<<Открыть фото>>", "OpenFoto", new { url = @blank.Picture }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 47 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                <b>\r\n                    ");
#nullable restore
#line 50 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
               Write(Html.ActionLink("<<Добавить совпадение>>", "Matching", new { user = @blank.Name, tableId = @blank.TableId, isMale = @blank.isMan }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </b>\r\n            </td>\r\n            <td align=\"center\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1856, 1);
#nullable restore
#line 54 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
WriteAttributeValue("", 1741, Url.Action("Remove", "Dating", new { name = @blank.Name, tableId = @blank.TableId, sessionId = @Model.SessionID }), 1741, 115, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af314134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n        <td colspan=\"5\">\r\n            <b>");
#nullable restore
#line 63 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
          Write(Html.ActionLink("Добавить участника", "Add"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </td>\r\n    </tr>\r\n\r\n    <p>");
#nullable restore
#line 67 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
  Write(ViewBag.SaveMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>    \r\n\r\n</table>\r\n\r\n<table align=\"center\" border=\"1\">\r\n    <tr>\r\n        <td valign=\"middle\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2272, "\"", 2308, 1);
#nullable restore
#line 74 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
WriteAttributeValue("", 2279, Url.Action("Save", "Dating"), 2279, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af316572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 76 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
           Write(Html.ActionLink("Сохранить сессию", "Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </td>\r\n        <td valign=\"middle\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 2531, "\"", 2570, 1);
#nullable restore
#line 80 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
WriteAttributeValue("", 2538, Url.Action("Results", "Dating"), 2538, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13661f826d748438b2cbb44822807f9952e86af318504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 82 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Session.cshtml"
           Write(Html.ActionLink("Сформировать результаты", "Results"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDating.Models.DatingSession> Html { get; private set; }
    }
}
#pragma warning restore 1591
