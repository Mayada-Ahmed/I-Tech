#pragma checksum "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c"
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
#line 1 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f229024b4237d17d1ea79fcdef1b7ab3ef6760c", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItemFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c6919", async() => {
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"container cart-c\">\r\n    <h1>Shopping Cart</h1>\r\n    <div class=\"cart\">\r\n        <div class=\"products\">\r\n\r\n");
#nullable restore
#line 46 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
             foreach (var item in Model.ShoppingCart.ShoppingCartItems)
            {

                string str = item.product.Picture;
                var pictureList = str.Split(","); 


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product\">\r\n");
#nullable restore
#line 53 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 if(item.product.ModelMobile != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 1733, "\"", 1754, 1);
#nullable restore
#line 55 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 1739, pictureList[0], 1739, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1755, "\"", 1779, 1);
#nullable restore
#line 55 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 1761, item.product.Name, 1761, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"\r\n                    onerror=\"this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\' \" \r\n                    class=\"product-img\">\r\n");
#nullable restore
#line 58 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 if(item.product.ModelLabtop != null)
                {    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 2071, "\"", 2092, 1);
#nullable restore
#line 61 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 2077, pictureList[0], 2077, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2093, "\"", 2117, 1);
#nullable restore
#line 61 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 2099, item.product.Name, 2099, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" \r\n                    onerror=\"this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\"\r\n                    class=\"product-img\">\r\n");
#nullable restore
#line 64 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 if(item.product.Accessories != null)
                {             

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 2478, "\"", 2499, 1);
#nullable restore
#line 67 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 2484, pictureList[0], 2484, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2500, "\"", 2524, 1);
#nullable restore
#line 67 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
WriteAttributeValue("", 2506, item.product.Name, 2506, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"\r\n                    onerror=\"this.src=\'https://3.bp.blogspot.com/-zka4TWwz3ZM/WjQjLhMVNrI/AAAAAAABT18/tpJM9Owjtwwqc-ZlMlUiBrxL8By3tF55wCLcBGAs/s1600/best-tech-accessories.jpg\'\"\r\n                    class=\"product-img\">\r\n");
#nullable restore
#line 70 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n                    <div class=\"product-info\">\r\n                        <h3 class=\"product-name\">");
#nullable restore
#line 73 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                            Write(item.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <div class=\"mb-2\">\r\n                            <h5 class=\"d-inline\">Price:</h5>\r\n                            <span class=\"product-price d-inline\">");
#nullable restore
#line 76 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                            Write(item.product.UnitPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                            <h5 class=\"d-inline\">Discount:</h5>\r\n                            <span class=\"product-offer d-inline\">");
#nullable restore
#line 81 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                            Write(item.product.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                             <h5 class=\"d-inline\">SubTotal:</h5>\r\n                            <span class=\"product-price d-inline\">");
#nullable restore
#line 86 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                                                             Write((item.Amount*item.product.UnitPrice).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                        </div>\r\n\r\n                        <div class=\"mb-2\">\r\n                            <h5 class=\"d-inline\">Quantity:</h5>\r\n                            <span class=\"product-quantity\">\r\n                                ");
#nullable restore
#line 92 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n\r\n                        \r\n                        <div class=\"product-add\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c16138", async() => {
                WriteLiteral("\r\n                                <i class=\'bx bxs-message-square-add\'></i>\r\n                            ");
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
#line 98 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
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
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"product-remove\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c18578", async() => {
                WriteLiteral("\r\n                                <i class=\'bx bxs-message-square-minus\'></i>\r\n                            ");
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
#line 104 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
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
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 111 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        <div class=\"cart-total\">\r\n            <p>\r\n                <span>Total Price</span>\r\n                <span>");
#nullable restore
#line 116 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                 Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <div class=\"Items-number-c\">\r\n                <span>Number of Items:</span>\r\n                <span>\r\n                        ");
#nullable restore
#line 121 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                   Write(await Component.InvokeAsync("ShoppingCartSummary"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n            <p>\r\n                <span>Discount</span>\r\n                <span>100$</span>\r\n            </p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c22320", async() => {
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
            WriteLiteral("\r\n\t\t    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c23784", async() => {
                WriteLiteral("Complete Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
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
            WriteLiteral("            <div class=\"paypal-chk\">\r\n              <div id=\"paypal-btn\"></div>\r\n            </div>\r\n\r\n              <span style=\"padding:5px\"></span>\r\n\t    </div>\r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f229024b4237d17d1ea79fcdef1b7ab3ef6760c25572", async() => {
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
                WriteLiteral("\r\n    <script src=\"https://www.paypalobjects.com/api/checkout.js\"></script>\r\n    <script>\r\n\r\n        let _total = ");
#nullable restore
#line 145 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
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
            onAuthorize: function (data, actions) {
                return actions.payment.execute().then(f");
                WriteLiteral("unction () {\r\n                    var url = \'");
#nullable restore
#line 178 "C:\Users\mgabr\OneDrive\Desktop\Finaaal\I-TECH-Project\ITech Project\ITech Project\Views\Order\Index.cshtml"
                          Write(Url.Action("CompleteOrder", "CompleteOrder", new { }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                    window.location.href = url;\r\n                });\r\n            }\r\n\r\n        }, \'#paypal-btn\')\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
