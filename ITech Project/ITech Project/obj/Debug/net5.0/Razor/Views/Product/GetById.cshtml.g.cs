#pragma checksum "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93beec14c7387606b9c456b3ee88bf7097d8a60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetById), @"mvc.1.0.view", @"/Views/Product/GetById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93beec14c7387606b9c456b3ee88bf7097d8a60e", @"/Views/Product/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/details.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("style", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93beec14c7387606b9c456b3ee88bf7097d8a60e5504", async() => {
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
            WriteLiteral(@"
<section class=""items-section"">
    <div class=""container"">
        <div class=""h m-3 ms-0"">
            <p>Product Details</p>
        </div>
        <div class=""details d-flex flex-row"">
            <div id=""carouselExampleDark"" class=""carousel carousel-dark"" data-bs-ride=""carousel"">
");
#nullable restore
#line 14 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                  
                    string str = Model.Picture;
                    var pictureList = str.Split(",");
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-indicators\">\r\n");
#nullable restore
#line 19 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         for(int i = 0;i < @pictureList.Length; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"button\" data-bs-target=\"#carouselExampleDark\" data-bs-slide-to=\"");
#nullable restore
#line 21 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"\r\n                            aria-current=\"true\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 860, "\"", 881, 2);
            WriteAttributeValue("", 873, "Slide", 873, 5, true);
#nullable restore
#line 22 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue(" ", 878, i, 879, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 23 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 26 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                     if(pictureList.Length <= 1)
                    {
                        //image is one picture

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 30 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                             if (Model.ModelMobile != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1300, "\"", 1310, 1);
#nullable restore
#line 32 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 1306, str, 1306, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 1327, "\"", 1344, 1);
#nullable restore
#line 32 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 1333, Model.Name, 1333, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onerror=\"this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\'\">\r\n");
#nullable restore
#line 33 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                            }else if (Model.ModelLabtop != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1572, "\"", 1582, 1);
#nullable restore
#line 35 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 1578, str, 1578, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 1599, "\"", 1616, 1);
#nullable restore
#line 35 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 1605, Model.Name, 1605, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onerror=\"this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\">\r\n");
#nullable restore
#line 36 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 38 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                    } 
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 45 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                             if (Model.ModelMobile != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 2191, "\"", 2212, 1);
#nullable restore
#line 47 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 2197, pictureList[0], 2197, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 2229, "\"", 2255, 2);
#nullable restore
#line 47 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 2235, Model.Name, 2235, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2246, "onerror=", 2247, 9, true);
            EndWriteAttribute();
            WriteLiteral("this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\'\"\">\r\n");
#nullable restore
#line 48 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                            }else if (Model.ModelLabtop != null)
                            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 2475, "\"", 2496, 1);
#nullable restore
#line 50 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 2481, pictureList[0], 2481, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 2513, "\"", 2539, 2);
#nullable restore
#line 50 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 2519, Model.Name, 2519, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2530, "onerror=", 2531, 9, true);
            EndWriteAttribute();
            WriteLiteral("this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\"\">\r\n");
#nullable restore
#line 51 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 53 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        for(int i = 1;i < pictureList.Length;i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"carousel-item\">\r\n");
#nullable restore
#line 56 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 if (Model.ModelMobile != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 3040, "\"", 3061, 1);
#nullable restore
#line 58 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 3046, pictureList[i], 3046, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 3078, "\"", 3095, 1);
#nullable restore
#line 58 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 3084, Model.Name, 3084, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onerror=\"this.src=\'https://i.insider.com/60117b551d2df20018b71117?width=1136&format=jpeg\'\">\r\n");
#nullable restore
#line 59 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                }else if (Model.ModelLabtop != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 3335, "\"", 3356, 1);
#nullable restore
#line 61 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 3341, pictureList[i], 3341, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\"");
            BeginWriteAttribute("alt", " alt=\"", 3373, "\"", 3390, 1);
#nullable restore
#line 61 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
WriteAttributeValue("", 3379, Model.Name, 3379, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onerror=\"this.src=\'https://images.prismic.io/frameworkmarketplace/cca31de3-3b75-4932-af96-7646b7eba6c7__DSC3630-Edit-cropped.jpg?auto=compress,format\'\">\r\n");
#nullable restore
#line 62 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 64 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleDark""
                    data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleDark""
                    data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
            <div class=""speces"">
                <div class=""Product-Title"">
                    <h4>");
#nullable restore
#line 80 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                    <hr>
                </div>
                <div class=""Product-Specification"">
                    <h4>Product Specification</h4>
                    <hr>
                    <span class=""d-block"">
                        Brand:
");
#nullable restore
#line 88 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.Category == Category.Laptop)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">");
#nullable restore
#line 90 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                           Write(Model.ModelLabtop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 91 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else if(Model.Category == Category.Phone)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">");
#nullable restore
#line 94 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                           Write(Model.ModelMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 95 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                    <span>\r\n                        Color: <p class=\"d-inline\">");
#nullable restore
#line 98 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                              Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n                    </span>\r\n                    <span class=\"d-block\">\r\n                        Availability:\r\n");
#nullable restore
#line 102 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.UnitsInStock > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">In Stock</p>\r\n");
#nullable restore
#line 105 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">Out Of Stock</p>\r\n");
#nullable restore
#line 109 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                </div>\r\n                <div class=\"Product-reviews\">\r\n                    <h4>Product Reviews</h4>\r\n                    <hr>\r\n                    <span class=\"d-block\">\r\n");
#nullable restore
#line 116 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         for(int i = 0; i < Model.Ranking; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\'bx bxs-star\'></i> \r\n");
#nullable restore
#line 119 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         for(byte? i = Model.Ranking; i < 5; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\'bx bx-star\'></i>\r\n");
#nullable restore
#line 123 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         switch (Model.Ranking)
                        {
                            case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Very Bad</p>\r\n");
#nullable restore
#line 128 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                            case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Bad</p>\r\n");
#nullable restore
#line 131 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                            case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Normal</p>\r\n");
#nullable restore
#line 134 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                            case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Good</p>\r\n");
#nullable restore
#line 137 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                            case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Very Good</p>\r\n");
#nullable restore
#line 140 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                            case 5:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p class=\"d-inline\">Excellent</p>\r\n");
#nullable restore
#line 143 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                 break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </span>
                </div>
            </div>
            <div class=""Desc"">
                <div class=""Product-Description"">
                    <h4>Product description</h4>
                    <hr>
                    <span class=""d-block"">
                        <p>
                            ");
#nullable restore
#line 154 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </span>\r\n                </div>\r\n                <div class=\"Product-price\">\r\n                    <h4>Product price</h4>\r\n                    <hr>\r\n                    <span class=\"d-block price-val\">\r\n");
#nullable restore
#line 162 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                          
                            string price = ($"{Model.UnitPrice - Model.Discount}");
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\" style=\"text-decoration: line-through\">$ ");
#nullable restore
#line 165 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                                                                   Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"d-inline\">$");
#nullable restore
#line 166 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                            Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93beec14c7387606b9c456b3ee88bf7097d8a60e31612", async() => {
                WriteLiteral("<span class=\"d-flex justify-content-center align-items-center flex-row add-to-cart\">\r\n                        <i class=\'bx bxs-cart-add add-cart \'></i>\r\n                        <p class=\"d-inline\">add-to cart</p>\r\n                    </span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div id=""custome-accordion"" class=""d-flex flex-column"">
            <div class=""d-flex flex-row"" id=""ca-title"">
                <span>Description</span>
                <span>Specification</span>
                <span>reviews</span>
            </div>
            <div class=""d-flex flex-row"" id=""ca-body"">
                <div>
                    <h6>Product Description:</h6><br>
                    <p>");
#nullable restore
#line 184 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div hidden>\r\n                    <h6>Product Specification:</h6><br>\r\n                    <span class=\"d-block\">\r\n                        Brand:\r\n");
#nullable restore
#line 190 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.Category == Category.Laptop)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">");
#nullable restore
#line 192 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                           Write(Model.ModelLabtop);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 193 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else if(Model.Category == Category.Phone)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">");
#nullable restore
#line 196 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                           Write(Model.ModelMobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 197 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                    <span>\r\n                        Color: <p class=\"d-inline\">");
#nullable restore
#line 200 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                                              Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n                    </span>\r\n                    <span class=\"d-block\">\r\n                        Availability:\r\n");
#nullable restore
#line 204 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                         if(Model.UnitsInStock > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">In Stock</p>\r\n");
#nullable restore
#line 207 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"d-inline\">Out Of Stock</p>\r\n");
#nullable restore
#line 211 "D:\R@N\Ahmed\Pro\certificates\ITI\Content\ItI Menofia 3M\Final Project\I-TECH-Project\ITech Project\ITech Project\Views\Product\GetById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </span>
                </div>
                <div hidden>
                    <h6>Customers reviews:</h6><br>
                    Lorem, ipsum dolor sit amet consectetur adipisicing elit. Aliquid dolorem, atque nemo tenetur veritatis fuga dolore modi exercitationem quidem labore accusantium, delectus reiciendis quam voluptates architecto hic debitis sapiente earum.

                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93beec14c7387606b9c456b3ee88bf7097d8a60e38117", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
