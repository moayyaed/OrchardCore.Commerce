#pragma checksum "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\PricePart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "404a9ea9fcdee6d086467ff924eeedcfb2346570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PricePart), @"mvc.1.0.view", @"/Views/PricePart.cshtml")]
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
#line 10 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\_ViewImports.cshtml"
using OrchardCore.Commerce.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404a9ea9fcdee6d086467ff924eeedcfb2346570", @"/Views/PricePart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0b5401373261e722cddb3333bd5c5517fddf29", @"/Views/_ViewImports.cshtml")]
    public class Views_PricePart : OrchardCore.DisplayManagement.Razor.RazorPage<PricePartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\PricePart.cshtml"
 if (Model.CurrentDisplayCurrency.CurrencyIsoCode == Model.PriceCurrency)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"product-price\">");
#nullable restore
#line 5 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\PricePart.cshtml"
                      Write(Model.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 6 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\PricePart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PricePartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
