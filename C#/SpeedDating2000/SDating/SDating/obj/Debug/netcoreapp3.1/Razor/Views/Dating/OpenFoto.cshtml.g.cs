#pragma checksum "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7291bd0917de7c0b337bd239f3bb9943abb6ebf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dating_OpenFoto), @"mvc.1.0.view", @"/Views/Dating/OpenFoto.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7291bd0917de7c0b337bd239f3bb9943abb6ebf8", @"/Views/Dating/OpenFoto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14aafd3da86d1b9feeb13246b3b686b6e37ea41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dating_OpenFoto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml"
  
    ViewData["Title"] = "Фото";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Фото участника</h1>\r\n<p>URL: ");
#nullable restore
#line 8 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml"
   Write(ViewBag.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 10 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml"
 using (Html.BeginForm("OpenFoto", "Dating"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" value=\"Вернуться к списку участников\" />\r\n");
#nullable restore
#line 13 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"blueTable\">\r\n    <tr>\r\n        <th><img");
            BeginWriteAttribute("src", " src=\"", 308, "\"", 326, 1);
#nullable restore
#line 17 "C:\__SpeedDating2000\SDating\SDating\Views\Dating\OpenFoto.cshtml"
WriteAttributeValue("", 314, ViewBag.url, 314, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"foto\" /></th>\r\n    </tr>\r\n</table>");
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