#pragma checksum "C:\Users\SERRA\source\repos\Films\Films\Views\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a005cd518f01ee21478d27aceeaeb90c8b625a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Index), @"mvc.1.0.view", @"/Views/Shared/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a005cd518f01ee21478d27aceeaeb90c8b625a7a", @"/Views/Shared/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03f980fcf2bc5389fcfedc7fcbbe79afae25386", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-target", new global::Microsoft.AspNetCore.Html.HtmlString(".navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-bs-offset", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SERRA\source\repos\Films\Films\Views\Shared\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .box5 {
        background-color: transparent;
        position: relative
    }

        .box5:after, .box5:before {
            width: 50px;
            height: 50px;
            border-radius: 50%;
            background: #10a5b8;
            position: absolute;
            top: -80px;
            left: 15px;
            opacity: 0;
            z-index: 1;
            transition: all .35s ease
        }

        .box5:after {
            top: auto;
            left: auto;
            bottom: -80px;
            right: 15px
        }

        .box5:hover:after, .box5:hover:before {
            opacity: .75;
            transform: scale(8);
            transition-delay: .15s
        }

        .box5 img {
            width: 100%;
            height: auto;
            transition: all .35s ease-out 0s;
        }

        .box5:hover img {
            opacity: .4
        }

        .box5 .icon {
            margin: 0;
            position: absolute;
   ");
            WriteLiteral(@"         bottom: 15px;
            right: 15px;
            z-index: 2;
            transform: scale(0);
            transition: all .35s ease-out
        }

        .box5:hover .icon {
            transform: scale(1);
            transition-delay: .15s
        }

        .box5 .icon li a {
            display: block;
            width: 35px;
            height: 35px;
            line-height: 35px;
            background: #fff;
            font-size: 18px;
            color: #444;
            margin-right: 10px;
            position: relative;
            transition: all .5s ease 0s
        }

            .box5 .icon li a:hover {
                background: #444;
                color: #fff
            }

        .box5 .box-content {
            padding: 20px 15px;
            position: absolute;
            top: 0;
            left: 0;
            z-index: 1
        }

        .box5 .title {
            font-size: 20px;
            font-weight: 800;
            color:");
            WriteLiteral(@" #444;
            margin: 0 0 5px;
            opacity: 0;
            transform: translate(-20px,-20px);
            transition: all .35s ease-out
        }

        .box5:hover .title {
            opacity: 1;
            transform: translate(0,0);
            transition-delay: .15s
        }

        .box5 .releasedate {
            display: inline-block;
            font-size: 16px;
            color: #444;
            opacity: 0;
            transform: translate(-20px,-20px);
            transition: all .35s ease-out
        }

        .box5:hover .releasedate {
            opacity: 1;
            transform: translate(0,0);
            transition-delay: .15s
        }

    .box6 .title, .box6 img, .box6:after {
        transition: all .35s ease 0s
    }

    ");
            WriteLiteral("@media only screen and (max-width:990px) {\r\n        .box5 {\r\n            margin-bottom: 30px\r\n        }\r\n    }\r\n</style>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a005cd518f01ee21478d27aceeaeb90c8b625a7a7530", async() => {
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>
    <style>
        body {
            position: relative;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a005cd518f01ee21478d27aceeaeb90c8b625a7a8948", async() => {
                WriteLiteral(@"
    <div id=""section1"" class=""container-fluid bg-secondary"" style=""padding:100px 20px;"">
        <h1 class=""text-white"">WELCOME</h1>
        <p class=""text-white"">Try to scroll this section and look at the navigation bar while scrolling! Try to scroll this section and look at the navigation bar while scrolling!</p>
        <p class=""text-white"">Try to scroll this section and look at the navigation bar while scrolling! Try to scroll this section and look at the navigation bar while scrolling!</pclass=""text-white"">
    </div>

    <div id=""section2"" class=""container-fluid bg-transparent"" style=""padding:100px 20px;"">

        <div class=""container mt-40"">
            <h1 class=""text"">Coming Soon...</h1>
            <br />
            <div class=""row mt-30"">
                <div class=""col-md-4 col-sm-6"">
                    <div class=""box5"">
                        <img class=""pic-1"" src=""/NewFolder/pngwingcom.png"">

                        <ul class=""icon"">
                            <li><a");
                WriteLiteral(@" href=""#"" class=""fa fa-search""></a></li>
                            <li><a href=""#"" class=""fa fa-link""></a></li>
                        </ul>
                        <div class=""box-content"">
                            <h3 class=""title"">The Dark Knight Rises</h3>
                            <span class=""releasedate"">01/09/2022</span>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-6"">
                    <div class=""box5"">
                        <img class=""pic-1"" src=""/NewFolder/powerpuffgirlspngwing.com.png"">
                        <ul class=""icon"">
                            <li><a href=""#"" class=""fa fa-search""></a></li>
                            <li><a href=""#"" class=""fa fa-link""></a></li>
                        </ul>
                        <div class=""box-content"">
                            <h3 class=""title"">Powerpuff Girls</h3>
                            <span class=""releasedate"">15/09/2022</span>");
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-6"">
                    <div class=""box5"">
                        <img class=""pic-1"" src=""/NewFolder/cocopngwing.com.png"">
                        <ul class=""icon"">
                            <li><a href=""#"" class=""fa fa-search""></a></li>
                            <li><a href=""#"" class=""fa fa-link""></a></li>
                        </ul>
                        <div class=""box-content"">
                            <h3 class=""title"">Coco</h3>
                            <span class=""releasedate"">3/10/2022</span>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 col-sm-6"">
                    <div class=""box5"">
                        <img class=""pic-1"" src=""/NewFolder/totoropngwing.com.png"">
                        <ul class=""icon"">
                            <li><a href=""#"" class=""fa fa-search");
                WriteLiteral(@"""></a></li>
                            <li><a href=""#"" class=""fa fa-link""></a></li>
                        </ul>
                        <div class=""box-content"">
                            <h3 class=""title"">My Neighbour Totoro</h3>
                            <span class=""releasedate"">3/10/2022</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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