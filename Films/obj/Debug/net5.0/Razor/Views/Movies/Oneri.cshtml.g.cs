#pragma checksum "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c493d1ca390870d23f0a5f32bb829e38ac45c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Oneri), @"mvc.1.0.view", @"/Views/Movies/Oneri.cshtml")]
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
#line 1 "C:\Users\SERRA\source\repos\Films\Films\Views\_ViewImports.cshtml"
using Films;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SERRA\source\repos\Films\Films\Views\_ViewImports.cshtml"
using Films.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c493d1ca390870d23f0a5f32bb829e38ac45c1", @"/Views/Movies/Oneri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03f980fcf2bc5389fcfedc7fcbbe79afae25386", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Oneri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Films.Models.Movies>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
  
    ViewData["Title"] = "Must Watch";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 7 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n<div class=\"container align-content-sm-center\">\r\n\r\n    <div class=\"card bg-secondary text-white\">\r\n        <div class=\"card-header\"><p class=\"text-uppercase\"><strong>");
#nullable restore
#line 13 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
                                                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p></div>\r\n        <div class=\"card-body\">\r\n            <p><strong>Genre:</strong> ");
#nullable restore
#line 15 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
                                  Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n            <p><strong>Score: </strong>");
#nullable restore
#line 16 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
                                  Write(Model.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n            <p><strong>Director: </strong> ");
#nullable restore
#line 17 "C:\Users\SERRA\source\repos\Films\Films\Views\Movies\Oneri.cshtml"
                                      Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n</div>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Films.Models.Movies> Html { get; private set; }
    }
}
#pragma warning restore 1591
