#pragma checksum "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ddc52839f6a03999ced8dbb29d9f2f143540e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetById), @"mvc.1.0.view", @"/Views/Order/GetById.cshtml")]
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
#line 1 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\_ViewImports.cshtml"
using ITech_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ddc52839f6a03999ced8dbb29d9f2f143540e8", @"/Views/Order/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb0f3bef2fceeb119792ca59c54b9e9a570706", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container mt-3\">\r\n    <h2>Show Order details</h2>\r\n\r\n    <table class=\"table table-bordered\">\r\n         <tr>\r\n            <th>Customer</th>\r\n");
#nullable restore
#line 10 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
             foreach(var item in ViewBag.Cust)
            {
                if(item.Id == Model.CustomerId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 14 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 15 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n        <tr>\r\n            <th>Order Number</th>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <th>Payment Method</th>\r\n           <td>");
#nullable restore
#line 24 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
          Write(Model.Payment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n            <th>Shipper</th>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Shipper);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        </tr>\r\n        \r\n        <tr>\r\n            <th>Order Date</th>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Freight</th>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Transaction Status</th>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n \r\n        <tr>\r\n            <th>Payment Date</th>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\Mayada\Desktop\I-TECH\I-TECH-Project\ITech Project\ITech Project\Views\Order\GetById.cshtml"
           Write(Model.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>    \r\n    </table>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4ddc52839f6a03999ced8dbb29d9f2f143540e87854", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n</div>\r\n \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
