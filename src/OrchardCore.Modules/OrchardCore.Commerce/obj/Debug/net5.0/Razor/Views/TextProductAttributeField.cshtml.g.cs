#pragma checksum "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "191d4b89204715199bce4bfb90800016bb501df4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TextProductAttributeField), @"mvc.1.0.view", @"/Views/TextProductAttributeField.cshtml")]
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
#line 1 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
using OrchardCore.Commerce.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
using OrchardCore.Commerce.Abstractions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"191d4b89204715199bce4bfb90800016bb501df4", @"/Views/TextProductAttributeField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0b5401373261e722cddb3333bd5c5517fddf29", @"/Views/_ViewImports.cshtml")]
    public class Views_TextProductAttributeField : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
  
    int index = Model.Index;
    var attr = Model.AttributeDescription as ProductAttributeDescription;
    var settings = attr.Settings as TextProductAttributeFieldSettings;
    var id = $"{Model.IdPrefix}-attribute-{index}";
    int optionIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<label");
            BeginWriteAttribute("for", " for=\"", 353, "\"", 362, 1);
#nullable restore
#line 12 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 359, id, 359, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
            Write(attr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n<input type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 404, "\"", 438, 3);
            WriteAttributeValue("", 411, "line.Attributes[", 411, 16, true);
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 427, index, 427, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 433, "].Key", 433, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 439, "\"", 472, 3);
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 447, attr.PartName, 447, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 461, ".", 461, 1, true);
#nullable restore
#line 13 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 462, attr.Name, 462, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 14 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
 if (settings.PredefinedValues is null || settings.PredefinedValues.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input");
            BeginWriteAttribute("id", " id=\"", 574, "\"", 582, 1);
#nullable restore
#line 16 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 579, id, 579, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 595, "\"", 631, 3);
            WriteAttributeValue("", 602, "line.Attributes[", 602, 16, true);
#nullable restore
#line 16 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 618, index, 618, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 624, "].Value", 624, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 632, "\"", 662, 1);
#nullable restore
#line 16 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 640, settings.DefaultValue, 640, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 663, "\"", 698, 1);
#nullable restore
#line 16 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 677, settings.Placeholder, 677, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n");
#nullable restore
#line 17 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
}
else if (settings.MultipleValues)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 21 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
         foreach (string predefinedValue in settings.PredefinedValues)
        {
            var optionId = $"{id}-{optionIndex++}";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <input id=\"optionId\" type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 982, "\"", 1018, 3);
            WriteAttributeValue("", 989, "line.Attributes[", 989, 16, true);
#nullable restore
#line 25 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1005, index, 1005, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1011, "].Value", 1011, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 1019, "\"", 1072, 1);
#nullable restore
#line 25 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1029, predefinedValue == settings.DefaultValue, 1029, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\" />\r\n                <label");
            BeginWriteAttribute("for", " for=\"", 1125, "\"", 1140, 1);
#nullable restore
#line 26 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1131, optionId, 1131, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-label\">");
#nullable restore
#line 26 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                                           Write(predefinedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </li>\r\n");
#nullable restore
#line 28 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 30 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
}
else if (settings.RestrictToPredefinedValues)
{
    if (settings.PredefinedValues.Count() > 5) // Doing radio buttons for less than 5 options
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <select");
            BeginWriteAttribute("id", " id=\"", 1404, "\"", 1412, 1);
#nullable restore
#line 35 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1409, id, 1409, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1413, "\"", 1449, 3);
            WriteAttributeValue("", 1420, "line.Attributes[", 1420, 16, true);
#nullable restore
#line 35 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1436, index, 1436, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1442, "].Value", 1442, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n");
#nullable restore
#line 36 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
             foreach (string predefinedValue in settings.PredefinedValues)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191d4b89204715199bce4bfb90800016bb501df411831", async() => {
#nullable restore
#line 38 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                                                          Write(predefinedValue);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
AddHtmlAttributeValue("", 1599, predefinedValue == settings.DefaultValue, 1599, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n");
#nullable restore
#line 41 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 45 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
             foreach (string predefinedValue in settings.PredefinedValues)
            {
                var optionId = $"{id}-{optionIndex++}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <input");
            BeginWriteAttribute("id", " id=\"", 1939, "\"", 1953, 1);
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1944, optionId, 1944, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1967, "\"", 2003, 3);
            WriteAttributeValue("", 1974, "line.Attributes[", 1974, 16, true);
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 1990, index, 1990, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1996, "].Value", 1996, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2004, "\"", 2028, 1);
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2012, predefinedValue, 2012, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 2029, "\"", 2082, 1);
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2039, predefinedValue == settings.DefaultValue, 2039, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-input\" />\r\n                    <label");
            BeginWriteAttribute("for", " for=\"", 2139, "\"", 2154, 1);
#nullable restore
#line 50 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2145, optionId, 2145, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-check-label\">");
#nullable restore
#line 50 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                                               Write(predefinedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </li>\r\n");
#nullable restore
#line 52 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 54 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input");
            BeginWriteAttribute("id", " id=\"", 2289, "\"", 2297, 1);
#nullable restore
#line 58 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2294, id, 2294, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\"");
            BeginWriteAttribute("name", " name=\"", 2310, "\"", 2346, 3);
            WriteAttributeValue("", 2317, "line.Attributes[", 2317, 16, true);
#nullable restore
#line 58 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2333, index, 2333, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2339, "].Value", 2339, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2347, "\"", 2377, 1);
#nullable restore
#line 58 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2355, settings.DefaultValue, 2355, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2378, "\"", 2413, 1);
#nullable restore
#line 58 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
WriteAttributeValue("", 2392, settings.Placeholder, 2392, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n    <select data-related=\"line.Attributes[");
#nullable restore
#line 59 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                     Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("].Value\" class=\"product-attribute-combo-select form-control\">\r\n");
#nullable restore
#line 60 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
         foreach (string predefinedValue in settings.PredefinedValues)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "191d4b89204715199bce4bfb90800016bb501df419703", async() => {
#nullable restore
#line 62 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                                                      Write(predefinedValue);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 62 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
AddHtmlAttributeValue("", 2664, predefinedValue == settings.DefaultValue, 2664, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>
    <script at=""Foot"">
        $(function () {
            $("".product-attribute-combo-select"").on('change', function (e) {
                var select = $(e.target);
                select
                    .closest('form')
                    .find('input[name=""' + select.data('related') + '""]')
                    .val(select.val());
            });
        });
    </script>
");
#nullable restore
#line 76 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
 if (settings.Hint != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hint form-text text-muted\">");
#nullable restore
#line 79 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
                                      Write(settings.Hint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 80 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\TextProductAttributeField.cshtml"
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
