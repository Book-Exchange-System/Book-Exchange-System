#pragma checksum "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdb906d491c608761bfbf175156a7331ec271a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_users_table), @"mvc.1.0.view", @"/Views/Admin/users_table.cshtml")]
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
#line 1 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\_ViewImports.cshtml"
using BookStoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdb906d491c608761bfbf175156a7331ec271a2", @"/Views/Admin/users_table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703fdb5c853f7104676478a8f850abf326d7160c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_users_table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
   ViewData["Title"] = "Display Data";
                string[] table_headers = new string[]
                {
        "ID","Username","Password","Name","Surname","Birtday","Phone Number","Email","Gender","Action"
                    }; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"table\">\n    <table class=\"table table-bordered table-hover\">\n        <thead>\n            <tr>\n");
#nullable restore
#line 12 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
                 foreach (var head in table_headers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <th>");
#nullable restore
#line 14 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>");
#nullable restore
#line 14 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 18 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
             if (Model != null)
            {
                foreach (var data in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>");
#nullable restore
#line 24 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
                      
                    DateTime date = data.Birthday;
                    String birthday = date.ToString("yyyy-MM-dd");
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
            Write(birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>");
#nullable restore
#line 34 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 36 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
               Write(data.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcdb906d491c608761bfbf175156a7331ec271a28823", async() => {
                WriteLiteral("\n                        Delete\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1163, "~/delete/", 1163, 9, true);
#nullable restore
#line 38 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
AddHtmlAttributeValue("", 1172, data.ID, 1172, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>                ");
#nullable restore
#line 42 "C:\Users\ecems\Documents\GitHub\Book-Exchange-System\Project Solition\Son\BookStoreProject\BookStoreProject\Views\Admin\users_table.cshtml"
                                 }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n\n    </table>\n</div>");
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
