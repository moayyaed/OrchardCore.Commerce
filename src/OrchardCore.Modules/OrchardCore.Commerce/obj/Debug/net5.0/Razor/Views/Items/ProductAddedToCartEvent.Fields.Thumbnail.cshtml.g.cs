#pragma checksum "E:\Repositories\OrchardCore.Commerce\src\OrchardCore.Modules\OrchardCore.Commerce\Views\Items\ProductAddedToCartEvent.Fields.Thumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a25a3936812f8427f8eb42e55514cb598ebda79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_ProductAddedToCartEvent_Fields_Thumbnail), @"mvc.1.0.view", @"/Views/Items/ProductAddedToCartEvent.Fields.Thumbnail.cshtml")]
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
#line 10 "E:\Repositories\OrchardCore.Commerce\src\OrchardCore.Modules\OrchardCore.Commerce\Views\_ViewImports.cshtml"
using OrchardCore.Commerce.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a25a3936812f8427f8eb42e55514cb598ebda79", @"/Views/Items/ProductAddedToCartEvent.Fields.Thumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0b5401373261e722cddb3333bd5c5517fddf29", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_ProductAddedToCartEvent_Fields_Thumbnail : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4 class=\"card-title\"><i class=\"fa fa-shopping-cart\"></i>");
#nullable restore
#line 1 "E:\Repositories\OrchardCore.Commerce\src\OrchardCore.Modules\OrchardCore.Commerce\Views\Items\ProductAddedToCartEvent.Fields.Thumbnail.cshtml"
                                                     Write(T["Product added"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<p>");
#nullable restore
#line 2 "E:\Repositories\OrchardCore.Commerce\src\OrchardCore.Modules\OrchardCore.Commerce\Views\Items\ProductAddedToCartEvent.Fields.Thumbnail.cshtml"
Write(T["Executes when a product is added to the shopping cart."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
