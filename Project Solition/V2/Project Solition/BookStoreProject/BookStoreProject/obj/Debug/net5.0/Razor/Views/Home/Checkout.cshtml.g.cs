#pragma checksum "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Home\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64a03aa25214d0497bf6cebc6fb1f4a4fae2836c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Checkout), @"mvc.1.0.view", @"/Views/Home/Checkout.cshtml")]
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
#line 1 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64a03aa25214d0497bf6cebc6fb1f4a4fae2836c", @"/Views/Home/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703fdb5c853f7104676478a8f850abf326d7160c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/book-images/01.jpg\n                                                    "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bookpage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Home\Checkout.cshtml"
  
    ViewData["Title"] = "Check Out Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""checkout"">
    <div class=""row"">
        <div class=""col-lg-8"">
            <div class=""card"">
                <div class=""card-header d-flex justify-content-between align-items-center position-relative"">
                    <div class=""header-title"">
                        <h4 class=""card-title mb-0"">
                            Shopping Cart
                        </h4>
                    </div>
                </div>
                <div class=""card-body"">
                    <ul class=""list-inline p-0 m-0"">
");
#nullable restore
#line 17 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Home\Checkout.cshtml"
                         for (int i = 0; i < 3; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 686, "\"", 732, 3);
            WriteAttributeValue("", 694, "checkout-product", 694, 16, true);
            WriteAttributeValue(" ", 710, "product-", 711, 9, true);
#nullable restore
#line 19 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Home\Checkout.cshtml"
WriteAttributeValue("", 719, i.ToString(), 719, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <div class=\"row align-items-center\">\n                                    <div class=\"col-sm-2\">\n                                        <span class=\"checkout-product-img\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a03aa25214d0497bf6cebc6fb1f4a4fae2836c6769", async() => {
                WriteLiteral("\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "64a03aa25214d0497bf6cebc6fb1f4a4fae2836c7070", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </span>
                                    </div>
                                    <div class=""col-sm-4"">
                                        <div class=""checkout-product-details"">
                                            <h5>The Raze night book</h5>
                                            <p class=""text-success"">In stock</p>
                                            <div class=""price"">
                                                <h5>$180.00</h5>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-sm-6"">
                                        <div class=""row"">
                                            <div class=""col-sm-10"">
                                                <div class=""row align-items-center mt-2"">
                                                    <div class=""col-sm-7 col-md-6"">
           ");
            WriteLiteral(@"                                             <button type=""button"" class=""fa fa-minus qty-btn"" id=""btn-minus""></button>
                                                        <input type=""text"" id=""quantity"" value=""0"">
                                                        <button type=""button"" class=""fa fa-plus qty-btn"" id=""btn-plus""></button>
                                                    </div>
                                                    <div class=""col-sm-5 col-md-6"">
                                                        <span class=""product-price"">$180.00</span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-sm-2"">
                                                <a href=""#"" class=""text-dark font-size-20""><i class=""fas fa-trash"" style=""position:relative; top: 20%;""></i></a>
                                        ");
            WriteLiteral("    </div>\n                                        </div>\n                                    </div>\n                                </div>\n                            </li>\n");
#nullable restore
#line 59 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Home\Checkout.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\n                </div>\n            </div>\n        </div>\n        <div class=\"col-lg-4\">\n\n        </div>\n    </div>\n</div>");
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