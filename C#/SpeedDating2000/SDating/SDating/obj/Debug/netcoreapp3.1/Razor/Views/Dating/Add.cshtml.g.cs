#pragma checksum "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea54dd9b7a9df083d605f512b6279060a0f4578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dating_Add), @"mvc.1.0.view", @"/Views/Dating/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea54dd9b7a9df083d605f512b6279060a0f4578", @"/Views/Dating/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14aafd3da86d1b9feeb13246b3b686b6e37ea41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dating_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
  
    ViewData["Title"] = "Add Person";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Добавление участника</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
 using (Html.BeginForm("add", "dating"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <table class=\"blueTable\">\r\n        <tr class=\"thead\">\r\n            <th>Table #</th>\r\n            <th>");
#nullable restore
#line 18 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.TextBox("tableId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n        <tr>\r\n            <td сlass=\"blueTable_td_center\">Имя</td>\r\n            <td>");
#nullable restore
#line 22 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td сlass=\"blueTable_td_center\">Возраст</td>\r\n            <td>");
#nullable restore
#line 26 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.TextBox("age"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td сlass=\"blueTable_td_center\">Телефон</td>\r\n            <td>");
#nullable restore
#line 30 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.TextBox("phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td сlass=\"blueTable_td_center\">E-mail</td>\r\n            <td>");
#nullable restore
#line 34 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.TextBox("email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td сlass=\"blueTable_td_center\">M/F</td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
           Write(Html.DropDownList("Sex", new List<SelectListItem> {
           new SelectListItem { Text = "Boy", Value = "Boy", Selected = true },
           new SelectListItem { Text = "Girl", Value = "Girl" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"4\" align=\"center\">\r\n                <input name=\"submit\" type=\"submit\" value=\"Добавить\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 50 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\Add.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
