#pragma checksum "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd7df3a0596770ff4f6d170adf3ac1d563c4e0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd7df3a0596770ff4f6d170adf3ac1d563c4e0f", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703fdb5c853f7104676478a8f850abf326d7160c", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 form-text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\Login\Login.cshtml"
   ViewData["Title"] = "Login Page";
    Layout = "_LoginLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row no-gutters height-self-center"">
    <div class=""col-sm-12 align-self-center page-content rounded"">
        <div class=""row m-0"">
            <div class=""col-sm-12"">
                <div class=""sign-in-from bg-primary rounded"">
                    <h3 class=""mb-0 text-center text-white"">Sign in</h3>
                    <p class=""text-center text-white"">Enter your email address and password to access panel.</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd7df3a0596770ff4f6d170adf3ac1d563c4e0f4453", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""exampleInputEmail1"">Email address</label>
                            <input type=""email"" class=""form-control mb-0"" id=""exampleInputEmail1"" placeholder=""Enter email"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Password</label>
                            <a href=""#"" class=""float-right text-dark"">Forgot password?</a>
                            <input type=""password"" class=""form-control mb-0"" id=""exampleInputPassword1"" placeholder=""Password"">
                        </div>
                        <div class=""d-inline-block w-100"">
                            <div class=""custom-control custom-checkbox d-inline-block mt-2 pt-1"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                <label class=""custom-control-label"" for=""customCheck1"">Remember M");
                WriteLiteral(@"e</label>
                            </div>
                        </div>
                        <div class=""sign-info text-center"">
                            <button type=""submit"" class=""btn btn-white d-block w-100 mb-2"">Sign in</button>
                            <span class=""text-dark dark-color d-inline-block line-height-2"">Don't have an account? <a href=""sign-up.html"" class=""text-white"">Sign up</a></span>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n\n            </div>\n        </div>\n    </div>\n</div>");
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