#pragma checksum "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f525975a8b8b25a39ecb3909a37a665e3d09f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_user_table), @"mvc.1.0.view", @"/Views/User/user_table.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f525975a8b8b25a39ecb3909a37a665e3d09f7", @"/Views/User/user_table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703fdb5c853f7104676478a8f850abf326d7160c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_user_table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
   ViewData["Title"] = "Display Data";
                string[] table_headers = new string[]
                {
        "ID","Username","Password","Name","Surname","Birtday","Phone Number","Email","Gender"
                    }; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"table\">\n    <table class=\"table table-bordered table-hover\">\n        <thead>\n            <tr>\n");
#nullable restore
#line 12 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
                 foreach (var head in table_headers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <th>");
#nullable restore
#line 14 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
   Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>");
#nullable restore
#line 14 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 18 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
             if (Model != null)
            {
                foreach (var data in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n\n                <td>");
#nullable restore
#line 24 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
                      
                    DateTime date = data.Birthday;
                    String birthday = date.ToString("yyyy-MM-dd");
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
            Write(birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>");
#nullable restore
#line 34 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 35 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 36 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
               Write(data.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>                ");
#nullable restore
#line 37 "C:\Users\ecems\Desktop\Book-Exchange-System-main\Project Solition\BookStoreProject\BookStoreProject\Views\User\user_table.cshtml"
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
