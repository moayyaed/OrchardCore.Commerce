#pragma checksum "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963360bff7986a72c14b582b8830c18fdf69f4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 2 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
using OrchardCore.Commerce.Abstractions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
using Money;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963360bff7986a72c14b582b8830c18fdf69f4b7", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0b5401373261e722cddb3333bd5c5517fddf29", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : OrchardCore.DisplayManagement.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("form", new global::Microsoft.AspNetCore.Html.HtmlString("shopping-cart-update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tag", new global::Microsoft.AspNetCore.Html.HtmlString("li"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "OrchardCore.Commerce", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("shopping-cart-update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::OrchardCore.DisplayManagement.TagHelpers.ZoneTagHelper __OrchardCore_DisplayManagement_TagHelpers_ZoneTagHelper;
        private global::OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("zone", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963360bff7986a72c14b582b8830c18fdf69f4b76326", async() => {
                WriteLiteral("\r\n    <header class=\"masthead\">\r\n        <div class=\"container\">\r\n            <div class=\"intro-text\">\r\n                <div class=\"intro-lead-in\"></div>\r\n                <div class=\"intro-heading text-uppercase\">");
#nullable restore
#line 9 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                                     Write(T["Your cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n");
            }
            );
            __OrchardCore_DisplayManagement_TagHelpers_ZoneTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ZoneTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ZoneTagHelper);
            __OrchardCore_DisplayManagement_TagHelpers_ZoneTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section id=\"shopping-cart\">\r\n");
#nullable restore
#line 15 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
 if (Model.Lines != null && Model.Lines.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"d-none d-sm-flex row border-bottom mt-3 pb-2 font-weight-bold\">\r\n            <div class=\"col-xs-12 col-sm-1\">");
#nullable restore
#line 19 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                       Write(T["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-xs-12 col-sm-9\">");
#nullable restore
#line 20 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                       Write(T["Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-xs-12 col-sm-1\">");
#nullable restore
#line 21 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                       Write(T["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-xs-12 col-sm-1\">");
#nullable restore
#line 22 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                       Write(T["Action"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 24 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
          
            int line = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
         foreach (ShoppingCartLineViewModel item in Model.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row border-bottom mt-3 pb-2\">\r\n                <div class=\"col-xs-12 col-sm-1\">\r\n");
#nullable restore
#line 31 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                      
                        int i = 0;
                        var name = $"cart.lines[{line++}]";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input form=\"shopping-cart-update\" type=\"number\" min=\"0\"");
            BeginWriteAttribute("name", " name=\"", 1323, "\"", 1346, 2);
#nullable restore
#line 35 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1330, name, 1330, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1337, ".Quantity", 1337, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1347, "\"", 1369, 1);
#nullable restore
#line 35 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1355, item.Quantity, 1355, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n                    <input form=\"shopping-cart-update\" type=\"hidden\"");
            BeginWriteAttribute("name", " name=\"", 1464, "\"", 1489, 2);
#nullable restore
#line 36 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1471, name, 1471, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1478, ".ProductSku", 1478, 11, true);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1490, "\"", 1514, 1);
#nullable restore
#line 36 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1498, item.ProductSku, 1498, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 37 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                     foreach (IProductAttributeValue attr in item.Attributes.Select(attr => attr.Value).Where(val => val.UntypedValue != null))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("shape", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "963360bff7986a72c14b582b8830c18fdf69f4b712884", async() => {
            }
            );
            __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                         WriteLiteral(attr.GetType().Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("Type", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alternate", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 1758, attr.GetType().Name, 1758, 22, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1780, "_hidden", 1780, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("prop-index", "OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper", "Properties"));
            }
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["index"] = (i++);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("prop-index", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["index"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attributeValue"] = attr;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("prop-attributeValue", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attributeValue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["namePrefix"] = name;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("prop-namePrefix", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["namePrefix"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-xs-12 col-sm-9\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2012, "\"", 2035, 1);
#nullable restore
#line 43 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2019, item.ProductUrl, 2019, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                          Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 44 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                     if (item.Attributes != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"cart-product-attributes list-inline\">\r\n");
#nullable restore
#line 47 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                             foreach (IProductAttributeValue attr in item.Attributes.Select(attr => attr.Value).Where(val => val.UntypedValue != null))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("shape", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "963360bff7986a72c14b582b8830c18fdf69f4b718720", async() => {
            }
            );
            __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper>();
            __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                          WriteLiteral(attr.GetType().Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("Type", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("prop-attribute", "OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper", "Properties"));
            }
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attribute"] = attr;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("prop-attribute", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attribute"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["label"] = attr.Label;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("prop-label", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["label"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 52 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-xs-12 col-sm-1\">");
#nullable restore
#line 54 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                           Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-xs-12 col-sm-1\">\r\n");
#nullable restore
#line 56 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                      
                        i = 0;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963360bff7986a72c14b582b8830c18fdf69f4b722943", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"line.ProductSku\"");
                BeginWriteAttribute("value", " value=\"", 3010, "\"", 3034, 1);
#nullable restore
#line 60 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3018, item.ProductSku, 3018, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 61 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                         foreach (IProductAttributeValue attr in item.Attributes.Select(attr => attr.Value).Where(val => val.UntypedValue != null))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("shape", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "963360bff7986a72c14b582b8830c18fdf69f4b724081", async() => {
                }
                );
                __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper = CreateTagHelper<global::OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper>();
                __tagHelperExecutionContext.Add(__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                             WriteLiteral(attr.GetType().Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("Type", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Type, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alternate", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
AddHtmlAttributeValue("", 3290, attr.GetType().Name, 3290, 22, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3312, "_hidden", 3312, 7, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                if (__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("prop-index", "OrchardCore.DisplayManagement.TagHelpers.ShapeTagHelper", "Properties"));
                }
#nullable restore
#line 63 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["index"] = (i++);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("prop-index", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["index"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
__OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attributeValue"] = attr;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("prop-attributeValue", __OrchardCore_DisplayManagement_TagHelpers_ShapeTagHelper.Properties["attributeValue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 65 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                                                 Write(T["Remove"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 69 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3 mb-3 pb-2\">\r\n            <div class=\"col-xs-12 col-sm-10 font-weight-bold\">");
#nullable restore
#line 71 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                                         Write(T["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-xs-12 col-sm-1\">\r\n");
#nullable restore
#line 73 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                 foreach (Amount total in Model.Totals)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>");
#nullable restore
#line 75 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                    Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 76 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-xs-12 col-sm-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "963360bff7986a72c14b582b8830c18fdf69f4b731449", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 80 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
                                                             Write(T["Update"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 85 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 88 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
  Write(T["Your shopping cart is empty."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 89 "E:\Repositories\OrchardCore.Commerce\OrchardCore.Commerce\Views\ShoppingCart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
