#pragma checksum "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff45d42b75e8d28d259f06aa9c748fd71f0b1e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Navigation.cshtml", typeof(AspNetCore.Views_Shared__Navigation))]
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
#line 1 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff45d42b75e8d28d259f06aa9c748fd71f0b1e9", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/profile_small.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 267, true);
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    ");
            EndContext();
            BeginContext(267, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eff45d42b75e8d28d259f06aa9c748fd71f0b1e94406", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            EndContext();
            BeginContext(342, 499, true);
            WriteLiteral(@"
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Gershom Senevirahtne</span>
                        <span class=""text-muted text-xs block"">User <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"" style=""position: absolute; top: 91px; left: 0px; will-change: top, left;"">
                        <li><a class=""dropdown-item""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 841, "\"", 882, 1);
#line 12 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 848, Url.Action("Profile", "AppViews"), 848, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(883, 131, true);
            WriteLiteral(">Profile</a></li>\r\n                        <li class=\"dropdown-divider\"></li>\r\n                        <li><a class=\"dropdown-item\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1050, 1);
#line 14 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1021, Url.Action("Login", "Pages"), 1021, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1051, 197, true);
            WriteLiteral(">Logout</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"logo-element\">\r\n                    QnA+\r\n                </div>\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1248, "\"", 1299, 1);
#line 21 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1256, Html.IsSelected(controller: "Environment"), 1256, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1300, 21, true);
            WriteLiteral(">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1321, "\"", 1363, 1);
#line 22 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1328, Url.Action("Index", "Environment"), 1328, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1364, 150, true);
            WriteLiteral("><i class=\"fa fa-cube\"></i> <span class=\"nav-label\" data-i18n=\"nav.dashboard\">Questions</span> <span class=\"fa arrow\"></span></a>\r\n                <ul");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1514, "\"", 1610, 4);
            WriteAttributeValue("", 1522, "nav", 1522, 3, true);
            WriteAttributeValue(" ", 1525, "nav-second-level", 1526, 17, true);
            WriteAttributeValue(" ", 1542, "collapse", 1543, 9, true);
#line 23 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue(" ", 1551, Html.IsSelected(controller: "Dashboards", cssClass: "in"), 1552, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1611, 26, true);
            WriteLiteral(">\r\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1637, "\"", 1687, 1);
#line 24 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1645, Html.IsSelected(action: "MyEnvironments"), 1645, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1688, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1691, "\"", 1742, 1);
#line 24 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1698, Url.Action("MyEnvironments", "Environment"), 1698, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1743, 48, true);
            WriteLiteral(">All Questions</a></li>\r\n                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1791, "\"", 1844, 1);
#line 25 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1799, Html.IsSelected(action: "CreateEnvironment"), 1799, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1845, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1848, "\"", 1902, 1);
#line 25 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1855, Url.Action("CreateEnvironment", "Environment"), 1855, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1903, 83, true);
            WriteLiteral(">My Questions</a></li>\r\n\r\n                </ul>\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1986, "\"", 2033, 1);
#line 29 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1994, Html.IsSelected(controller: "Library"), 1994, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2034, 21, true);
            WriteLiteral(">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2055, "\"", 2093, 1);
#line 30 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2062, Url.Action("Index", "Library"), 2062, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2094, 136, true);
            WriteLiteral("><i class=\"fa fa-book\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">New Question</span> </a>\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2230, "\"", 2278, 1);
#line 32 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2238, Html.IsSelected(controller: "Settings"), 2238, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2279, 21, true);
            WriteLiteral(">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2300, "\"", 2339, 1);
#line 33 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2307, Url.Action("Index", "Settings"), 2307, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2340, 131, true);
            WriteLiteral("><i class=\"fa fa-cog\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Settings</span> </a>\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2471, "\"", 2518, 1);
#line 35 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2479, Html.IsSelected(controller: "Contact"), 2479, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2519, 21, true);
            WriteLiteral(">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2540, "\"", 2578, 1);
#line 36 "F:\Realhack\FE\FE\ASPNET_Core_2_1\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2547, Url.Action("Index", "Contact"), 2547, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2579, 172, true);
            WriteLiteral("><i class=\"fa fa-phone-square\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Contact</span> </a>\r\n            </li>\r\n\r\n           \r\n        </ul>\r\n    </div>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
