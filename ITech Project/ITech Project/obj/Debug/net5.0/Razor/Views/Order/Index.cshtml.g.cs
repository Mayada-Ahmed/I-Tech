#pragma checksum "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd424cdfade54604a18dccd835c985414b57402", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItemFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d7244", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"container cart-c\">\r\n    <h1>Your cart</h1>\r\n    <div class=\"cart\">\r\n        <div class=\"products\">\r\n\r\n");
#nullable restore
#line 11 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
             foreach (var item in Model.ShoppingCart.ShoppingCartItems)
            {

                string str = item.product.Picture;
                var pictureList = str.Split(",");


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product\">\r\n");
#nullable restore
#line 18 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                     if (item.product.ModelMobile != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 566, "\"", 587, 1);
#nullable restore
#line 20 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 572, pictureList[0], 572, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 588, "\"", 612, 1);
#nullable restore
#line 20 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 594, item.product.Name, 594, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"\r\n                     onerror=\"this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\' \"\r\n                     class=\"product-img\">\r\n");
#nullable restore
#line 23 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                     if (item.product.ModelLabtop != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 918, "\"", 939, 1);
#nullable restore
#line 26 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 924, pictureList[0], 924, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 940, "\"", 964, 1);
#nullable restore
#line 26 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 946, item.product.Name, 946, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"\r\n                     onerror=\"this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\"\r\n                     class=\"product-img\">\r\n");
#nullable restore
#line 29 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                     if (item.product.Accessories != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1330, "\"", 1351, 1);
#nullable restore
#line 32 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 1336, pictureList[0], 1336, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1352, "\"", 1376, 1);
#nullable restore
#line 32 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 1358, item.product.Name, 1358, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"\r\n                     onerror=\"this.src=\'https://3.bp.blogspot.com/-zka4TWwz3ZM/WjQjLhMVNrI/AAAAAAABT18/tpJM9Owjtwwqc-ZlMlUiBrxL8By3tF55wCLcBGAs/s1600/best-tech-accessories.jpg\'\"\r\n                     class=\"product-img\">\r\n");
#nullable restore
#line 35 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"product-info\">\r\n                        <h4 class=\"product-name\">");
#nullable restore
#line 38 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                            Write(item.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <div class=\"mb-2\">\r\n                            <h6 class=\"d-inline\">Price:</h6>\r\n                            <span class=\"product-price d-inline\">");
#nullable restore
#line 41 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                            Write(item.product.UnitPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                            <h6 class=\"d-inline\">Discount:</h6>\r\n                            <span class=\"product-offer d-inline\">");
#nullable restore
#line 46 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                            Write(item.product.Discount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                            <h6 class=\"d-inline\">SubTotal:</h6>\r\n                            <span class=\"product-price d-inline\">");
#nullable restore
#line 51 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                             Write((item.Amount*item.product.UnitPrice-item.product.Discount).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                            <h6 class=\"d-inline\">Quantity:</h6>\r\n                            <span class=\"product-quantity\">\r\n                                ");
#nullable restore
#line 57 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d16939", async() => {
                WriteLiteral("\r\n                            <div class=\"product-add\">\r\n                                <i class=\'bx bxs-message-square-add\'></i>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                            WriteLiteral(item.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d19403", async() => {
                WriteLiteral("\r\n                            <div class=\"product-remove\">\r\n                                <i class=\'bx bxs-message-square-minus\'></i>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                             WriteLiteral(item.product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 76 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"cart-total\">\r\n            <p>\r\n                <span>Total Price</span>\r\n                <span>");
#nullable restore
#line 81 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <div class=\"Items-number-c\">\r\n                <span>Number of Items:</span>\r\n                <span>\r\n                    ");
#nullable restore
#line 86 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
               Write(await Component.InvokeAsync("ShoppingCartSummary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n            <p>\r\n                <span>Discount</span>\r\n                <span>");
#nullable restore
#line 91 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 Write(Model.ShoppingCartDiscount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d23621", async() => {
                WriteLiteral("Add More Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"paypal-chk\">\r\n                    <div id=\"paypal-btn\"></div>\r\n                </div>\r\n");
#nullable restore
#line 99 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d25832", async() => {
                WriteLiteral("Login To Complete Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 103 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"padding:5px\"></span>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eed80ef922be5a316ea53b1d5d6c6b4ae2e5273d27752", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<script src=\"https://www.paypalobjects.com/api/checkout.js\"></script>\r\n<script>\r\n\r\n    let _total = ");
#nullable restore
#line 114 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
            Write(Html.Raw(Model.ShoppingCartTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

    paypal.Button.render({
        //Configure environment
        env: 'sandbox',
        client: {
            sandbox: 'AckjySmxYA4fGOYvakp4CxB_CC3g_Hj240XCMjrmQ4gHfy0A4ek9W8myZWH38isHRiJaXWzt7kED8xhp'
        },

        //Customize button
        locale: 'en_US',
        style: {
            size: 'small',
            color: 'gold',
            shape: 'pill'
        },
        commit: true, // PAY NOW CHECK

        //Set up a payment
        payment: function (data, actions) {
            return actions.payment.create({
                transactions: [{
                    amount: {
                        total: _total,
                        currency: 'USD' //LE
                    }
                }]
            });
        },

        //Execute the payment
        onAuthorize: () => window.location.assign(""/ordercompleted?Ispaid=true"")
    }, '#paypal-btn')
</script>
");
            }
            );
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
