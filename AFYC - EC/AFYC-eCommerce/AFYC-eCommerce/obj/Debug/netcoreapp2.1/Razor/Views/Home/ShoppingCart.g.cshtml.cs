#pragma checksum "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5aa46aa6ce37785e3a18ffb005e2bb85a8e896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShoppingCart), @"mvc.1.0.view", @"/Views/Home/ShoppingCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShoppingCart.cshtml", typeof(AspNetCore.Views_Home_ShoppingCart))]
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
#line 1 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\_ViewImports.cshtml"
using AFYC_eCommerce;

#line default
#line hidden
#line 2 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\_ViewImports.cshtml"
using AFYC_eCommerce.Models;

#line default
#line hidden
#line 7 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aa46aa6ce37785e3a18ffb005e2bb85a8e896", @"/Views/Home/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8055717f7f2a2f565ce7aa588701bbce391bd6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addProductForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
  
    ViewData["Title"] = "ShoppingCart";

#line default
#line hidden
            BeginContext(48, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 4700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7acf35bb71d4e63855c98fb7ff5cc6c", async() => {
                BeginContext(219, 49, true);
                WriteLiteral("\r\n\r\n    <span id=\"userName\" style=\"display:none\">");
                EndContext();
                BeginContext(269, 29, false);
#line 13 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                                        Write(UserManager.GetUserName(User));

#line default
#line hidden
                EndContext();
                BeginContext(298, 620, true);
                WriteLiteral(@"</span>
    <div class=""container"" style=""padding-top:5%"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-10 col-md-offset-1"">
                <table style=""color:black"" class=""table"">
                    <thead>
                        <tr style=""color:black"">
                            <th>Product</th>
                            <th>Quantity</th>
                            <th>Price</th>
                            <th>Total</th>
                            <th> </th>
                        </tr>
                    </thead>

                    <tbody id=""cartProducts"">
");
                EndContext();
#line 29 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                         foreach (var cartProducts in ViewBag.cartProducts)
                        {
                            

#line default
#line hidden
#line 31 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                             if (@cartProducts.CartName == @UserManager.GetUserName(User))
                            {

#line default
#line hidden
                BeginContext(1145, 80, true);
                WriteLiteral("                                <tr>\r\n\r\n                                    <th>");
                EndContext();
                BeginContext(1226, 24, false);
#line 35 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                                   Write(cartProducts.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1250, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(1298, 21, false);
#line 36 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                                   Write(cartProducts.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(1319, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(1367, 25, false);
#line 37 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                                   Write(cartProducts.ProductPrice);

#line default
#line hidden
                EndContext();
                BeginContext(1392, 97, true);
                WriteLiteral(" lei</th>\r\n                                    <th><button class=\"add-cart-button btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1489, "\"", 1542, 3);
                WriteAttributeValue("", 1499, "RemoveFromCart(\'", 1499, 16, true);
#line 38 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
WriteAttributeValue("", 1515, cartProducts.ProductName, 1515, 25, false);

#line default
#line hidden
                WriteAttributeValue("", 1540, "\')", 1540, 2, true);
                EndWriteAttribute();
                BeginContext(1543, 57, true);
                WriteLiteral(">X</button></th>\r\n                                </tr>\r\n");
                EndContext();
#line 40 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                            }

#line default
#line hidden
#line 40 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(1658, 399, true);
                WriteLiteral(@"

                    </tbody>


                    <tfoot>
                        <tr>
                            <td>   </td>
                            <td>   </td>
                            <td>   </td>
                            <td>
                                <h3 id=""totalAmount"">
                                    Total :
                                    <span>");
                EndContext();
                BeginContext(2058, 13, false);
#line 55 "D:\PROGRAME\GitHub Desktop\eCommerceOnlineStore\AFYC - EC\AFYC-eCommerce\AFYC-eCommerce\Views\Home\ShoppingCart.cshtml"
                                     Write(ViewBag.Total);

#line default
#line hidden
                EndContext();
                BeginContext(2071, 1310, true);
                WriteLiteral(@"</span>
                                    lei
                                </h3>
                            </td>
                        </tr>
                        <tr>
                            <td>   </td>
                            <td>   </td>
                            <td>   </td>
                            <td>   </td>
                            <td>
                                <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#panel-customer"">
                                    <span class=""glyphicon glyphicon-check""></span>
                                </button>
                            </td>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
    </div>

    <div>


        <div id=""panel-customer"" class=""modal fade"" role=""dialog"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-h");
                WriteLiteral(@"eader"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                        <h4 class=""modal-title"" id=""hdr-form-customer"">Checkout</h4>
                    </div>
                    <div class=""modal-body"">
                        ");
                EndContext();
                BeginContext(3381, 1087, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "529ccf891e3f40e7891b0ae76c444dfb", async() => {
                    BeginContext(3426, 1035, true);
                    WriteLiteral(@"
                            <label>Email</label>
                            <input type=""text"" name=""value"" placeholder=""Enter Email"" id=""frm-customer-email"" class=""form-control"">

                            <label>First Name</label>
                            <input type=""text"" name=""text"" placeholder=""Enter First Name"" id=""frm-customer-first-name"" class=""form-control"">

                            <label>Last Name</label>
                            <input type=""text"" name=""text"" placeholder=""Enter Last Name"" id=""frm-customer-last-name"" class=""form-control"">

                            <label>City</label>
                            <input type=""text"" name=""text"" placeholder=""Enter City"" id=""frm-customer-city"" class=""form-control"">

                            <label>Address</label>
                            <input type=""text"" name=""text"" placeholder=""Enter Address"" id=""frm-customer-address"" class=""form-control"">

                            <div class=""clearfix""></div>
             ");
                    WriteLiteral("           ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4468, 438, true);
                WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-link pull-left"" data-dismiss=""modal"">Cancel</button>
                        <button type=""button"" onclick=""Checkout()"" class=""btn btn-default btn-success"" data-dismiss=""modal"">CheckOut</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4913, 11, true);
            WriteLiteral("\r\n\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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