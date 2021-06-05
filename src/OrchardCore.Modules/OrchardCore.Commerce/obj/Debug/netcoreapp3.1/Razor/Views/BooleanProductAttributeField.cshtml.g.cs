#pragma checksum "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6289c6cc7532a78466ace61b3d1e095f5c60b2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BooleanProductAttributeField), @"mvc.1.0.view", @"/Views/BooleanProductAttributeField.cshtml")]
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
#nullable restore
#line 1 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
using OrchardCore.Commerce.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
using OrchardCore.Commerce.Abstractions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6289c6cc7532a78466ace61b3d1e095f5c60b2f4", @"/Views/BooleanProductAttributeField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0b5401373261e722cddb3333bd5c5517fddf29", @"/Views/_ViewImports.cshtml")]
    public class Views_BooleanProductAttributeField : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
  
    int index = Model.Index;
    var attr = Model.AttributeDescription as ProductAttributeDescription;
    var settings = attr.Settings as BooleanProductAttributeFieldSettings;
    var id = $"{Model.IdPrefix}-attribute-{index}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 344, "\"", 378, 3);
            WriteAttributeValue("", 351, "line.Attributes[", 351, 16, true);
#nullable restore
#line 11 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 367, index, 367, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 373, "].Key", 373, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 379, "\"", 412, 3);
#nullable restore
#line 11 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 387, attr.PartName, 387, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 401, ".", 401, 1, true);
#nullable restore
#line 11 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 402, attr.Name, 402, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 438, "\"", 474, 3);
            WriteAttributeValue("", 445, "line.Attributes[", 445, 16, true);
#nullable restore
#line 12 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 461, index, 461, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 467, "].Value", 467, 7, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"false\" />\r\n<input");
            BeginWriteAttribute("id", " id=\"", 500, "\"", 508, 1);
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 505, id, 505, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 525, "\"", 561, 3);
            WriteAttributeValue("", 532, "line.Attributes[", 532, 16, true);
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 548, index, 548, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 554, "].Value", 554, 7, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
                                                                 Write(settings.DefaultValue ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"true\" class=\"form-check-input\" />\r\n<label");
            BeginWriteAttribute("for", " for=\"", 653, "\"", 662, 1);
#nullable restore
#line 14 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
WriteAttributeValue("", 659, id, 659, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-label\">");
#nullable restore
#line 14 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
                                      Write(string.IsNullOrEmpty(settings.Label) ? attr.Name : settings.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 15 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
 if (settings.Hint != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hint form-text text-muted\">");
#nullable restore
#line 17 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
                                      Write(settings.Hint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\BooleanProductAttributeField.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
