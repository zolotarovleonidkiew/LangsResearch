#pragma checksum "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1585815ef83ed72a0e8da59025f86cc40fdfcc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Init), @"mvc.1.0.view", @"/Views/Settings/Init.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1585815ef83ed72a0e8da59025f86cc40fdfcc1", @"/Views/Settings/Init.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14aafd3da86d1b9feeb13246b3b686b6e37ea41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_Init : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDating.SmtpSetting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/settings.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/send.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/m/stat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
  
    ViewData["Title"] = "Настройки";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Настройки</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc14386", async() => {
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
            WriteLiteral("\r\n    Настройка отправки почты (SMTP)\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc15459", async() => {
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
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 15 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
 using (Html.BeginForm("save", "settings"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"blueTable_width_50\">\r\n        <tr>\r\n            <th colspan=\"2\">SMTP настройка</th>\r\n        </tr>\r\n        <tr>\r\n            <td>Host-name</td>\r\n            <td>");
#nullable restore
#line 23 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.host));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Port</td>\r\n            <td>");
#nullable restore
#line 27 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.Port));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Логин (от почты)</td>\r\n            <td>");
#nullable restore
#line 31 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.MailBoxLogin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Пароль (от почты)</td>\r\n            <td>");
#nullable restore
#line 35 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.MailBoxPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Тема письма (парни)</td>\r\n            <td>");
#nullable restore
#line 39 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.EmailSubjectpatterntBoys));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Тема письма (девушки)</td>\r\n            <td>");
#nullable restore
#line 43 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.EmailSubjectpatterntGirls));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Ваш email</td>\r\n            <td>");
#nullable restore
#line 47 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.TextBoxFor(m => m.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"center\">\r\n                <input name=\"submit\" type=\"submit\" value=\"Сохранить\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 55 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc19562", async() => {
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
            WriteLiteral("\r\n    Отправить тестовой письмо\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc110629", async() => {
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
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 63 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
 if (@ViewData["tmg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 65 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
  Write(ViewData["tmg"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
 using (Html.BeginForm("test", "settings"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"blueTable_width_50\">\r\n        <tr>\r\n            <td>Получатель =></td>\r\n            <td>");
#nullable restore
#line 73 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.ValueFor(m=>m.From));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"center\">\r\n                <input name=\"submit\" type=\"submit\" value=\"Отправить\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 81 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table border=\"0\" align=\"center\">\r\n    <tr>\r\n        <td valign=\"middle\" align=\"center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc113370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            Сформировать отчет по использованиию памяти на носителе\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1585815ef83ed72a0e8da59025f86cc40fdfcc114484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td align=\"center\">\r\n            <b>\r\n                ");
#nullable restore
#line 94 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
           Write(Html.ActionLink("Сформировать отчет", "stat", "settings"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </b>\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n<div class=\"stat\">\r\n");
#nullable restore
#line 101 "C:\__SpeedDating2000\SDating\SDating\Views\Settings\Init.cshtml"
     if (@ViewData["statmsg"] != null)
    {
        await Html.RenderPartialAsync("StatPartial");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDating.SmtpSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591