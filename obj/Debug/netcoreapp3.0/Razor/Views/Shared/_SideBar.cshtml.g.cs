#pragma checksum "D:\Projects\kustutamaha\CleanAspNetCoreWithFreeMetronic\CleanAspNetCoreWithFreeMetronic\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "353a6de0c2a331cdedca41fa06233e157aebe5ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideBar), @"mvc.1.0.view", @"/Views/Shared/_SideBar.cshtml")]
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
#line 1 "D:\Projects\kustutamaha\CleanAspNetCoreWithFreeMetronic\CleanAspNetCoreWithFreeMetronic\Views\_ViewImports.cshtml"
using CleanAspNetCoreWithFreeMetronic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\kustutamaha\CleanAspNetCoreWithFreeMetronic\CleanAspNetCoreWithFreeMetronic\Views\_ViewImports.cshtml"
using CleanAspNetCoreWithFreeMetronic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353a6de0c2a331cdedca41fa06233e157aebe5ce", @"/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddfb575c842bce5b5f005928d737e038fff39cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- BEGIN SIDEBAR -->
<div class=""sidebar col-md-3 col-sm-5"">
    <ul class=""list-group margin-bottom-25 sidebar-menu"">
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Ladies</a></li>
        <li class=""list-group-item clearfix dropdown active"">
            <a href=""shop-product-list.html"" class=""collapsed"">
                <i class=""fa fa-angle-right""></i>
                Mens

            </a>
            <ul class=""dropdown-menu"" style=""display:block;"">
                <li class=""list-group-item dropdown clearfix active"">
                    <a href=""shop-product-list.html"" class=""collapsed""><i class=""fa fa-angle-right""></i> Shoes </a>
                    <ul class=""dropdown-menu"" style=""display:block;"">
                        <li class=""list-group-item dropdown clearfix"">
                            <a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Classic </a>
                            <ul class=""dropdown");
            WriteLiteral(@"-menu"">
                                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Classic 1</a></li>
                                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Classic 2</a></li>
                            </ul>
                        </li>
                        <li class=""list-group-item dropdown clearfix active"">
                            <a href=""shop-product-list.html"" class=""collapsed""><i class=""fa fa-angle-right""></i> Sport  </a>
                            <ul class=""dropdown-menu"" style=""display:block;"">
                                <li class=""active""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Sport 1</a></li>
                                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Sport 2</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>
                <li><a href=""shop-product-list");
            WriteLiteral(@".html""><i class=""fa fa-angle-right""></i> Trainers</a></li>
                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Jeans</a></li>
                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Chinos</a></li>
                <li><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> T-Shirts</a></li>
            </ul>
        </li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Kids</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Accessories</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Sports</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Brands</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angl");
            WriteLiteral(@"e-right""></i> Electronics</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Home &amp; Garden</a></li>
        <li class=""list-group-item clearfix""><a href=""shop-product-list.html""><i class=""fa fa-angle-right""></i> Custom Link</a></li>
    </ul>
</div>
<!-- END SIDEBAR -->");
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