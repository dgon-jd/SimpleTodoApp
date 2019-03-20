#pragma checksum "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457e412febe0b06a01632a3214f21645da7f784e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
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
#line 1 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo;

#line default
#line hidden
#line 2 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\_ViewImports.cshtml"
using AspNetCoreTodo.Models;

#line default
#line hidden
#line 2 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457e412febe0b06a01632a3214f21645da7f784e", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63823eaa5b73e495aebe7447edc96790f50c299d", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Manage Your Todo List";

#line default
#line hidden
            BeginContext(100, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(180, 17, false);
#line 9 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(197, 219, true);
            WriteLiteral("</div>\r\n\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <td>&#x2714;</td>\r\n                <td>Item</td>\r\n                <td>Due</td>\r\n            </tr>\r\n        </thead>\r\n\r\n");
            EndContext();
#line 20 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            BeginContext(471, 150, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(622, 10, false);
#line 26 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(632, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(660, 21, false);
#line 27 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
               Write(item.DueAt.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(681, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "c:\Users\DGon\Documents\Work\TechFabric\AspNetCoreTodo\Views\Todo\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(718, 90, true);
            WriteLiteral("    </table>\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n        \r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
