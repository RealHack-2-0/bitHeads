#pragma checksum "F:\Fiverr\Ernestoco\FE\ernestoco\ASPNET_Core_2_1\Views\Shared\_TopNavbar2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "814ba349d3940515589a8783a89dc3fd24467fdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TopNavbar2), @"mvc.1.0.view", @"/Views/Shared/_TopNavbar2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TopNavbar2.cshtml", typeof(AspNetCore.Views_Shared__TopNavbar2))]
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
#line 1 "F:\Fiverr\Ernestoco\FE\ernestoco\ASPNET_Core_2_1\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814ba349d3940515589a8783a89dc3fd24467fdc", @"/Views/Shared/_TopNavbar2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de49c825730062aa489a40b9712f0775fa5ef96", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TopNavbar2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 595, true);
            WriteLiteral(@"<div class=""row border-bottom white-bg"">
    <nav class=""navbar navbar-expand-lg navbar-static-top"" role=""navigation"">
        <a href=""#"" class=""navbar-brand"">Inspinia</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <i class=""fa fa-reorder""></i>
        </button>
        <div class=""navbar-collapse collapse"" id=""navbar"">
            <ul class=""nav navbar-nav mr-auto"">
                <li class=""active"">
                    <a aria-expanded=""false"" role=""button""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 595, "\"", 633, 1);
#line 10 "F:\Fiverr\Ernestoco\FE\ernestoco\ASPNET_Core_2_1\Views\Shared\_TopNavbar2.cshtml"
WriteAttributeValue("", 602, Url.Action("Index", "Layouts"), 602, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(634, 2431, true);
            WriteLiteral(@"> Back to main Layout page</a>
                </li>
                <li class=""dropdown"">
                    <a aria-expanded=""false"" role=""button"" href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""> Menu item</a>
                    <ul role=""menu"" class=""dropdown-menu"">
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                    </ul>
                </li>
                <li class=""dropdown"">
                    <a aria-expanded=""false"" role=""button"" href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""> Menu item</a>
                    <ul role=""menu"" class=""dropdown-menu"">
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu it");
            WriteLiteral(@"em</a></li>
                    </ul>
                </li>
                <li class=""dropdown"">
                    <a aria-expanded=""false"" role=""button"" href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""> Menu item</a>
                    <ul role=""menu"" class=""dropdown-menu"">
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                    </ul>
                </li>
                <li class=""dropdown"">
                    <a aria-expanded=""false"" role=""button"" href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown""> Menu item</a>
                    <ul role=""menu"" class=""dropdown-menu"">
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href="""">Menu item</a></li>
                        <li><a href=""""");
            WriteLiteral(@">Menu item</a></li>
                    </ul>
                </li>

            </ul>
            <ul class=""nav navbar-top-links navbar-right"">
                <li>
                    <a href=""login.html"">
                        <i class=""fa fa-sign-out""></i> Log out
                    </a>
                </li>
            </ul>
        </div>
    </nav>
</div>");
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
