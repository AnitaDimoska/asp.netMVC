#pragma checksum "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bacd8ad681bd5c157db02a338190f157d4cf4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bacd8ad681bd5c157db02a338190f157d4cf4c", @"/Views/Users/Index.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 16, true);
            WriteLiteral("<h1>Users</h1>\r\n");
            EndContext();
#line 2 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
 foreach (var item in Model.Users)
{

#line default
#line hidden
            BeginContext(55, 119, true);
            WriteLiteral("    <div class=\"card mb-2\" style=\"width: 18rem;\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            EndContext();
            BeginContext(175, 14, false);
#line 6 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                              Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(191, 13, false);
#line 6 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                                              Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(204, 40, true);
            WriteLiteral("</h5>\r\n            <span>Books borrowed:");
            EndContext();
            BeginContext(245, 24, false);
#line 7 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                            Write(item.BooksBorrowed.Count);

#line default
#line hidden
            EndContext();
            BeginContext(269, 29, true);
            WriteLiteral("</span>\r\n\r\n            <ul>\r\n");
            EndContext();
#line 10 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                 foreach (var bookList in item.BooksBorrowed)
                {

#line default
#line hidden
            BeginContext(380, 70, true);
            WriteLiteral("                    <li class=\"card-text\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 450, "\"", 483, 2);
            WriteAttributeValue("", 457, "books/details/", 457, 14, true);
#line 13 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 471, bookList.Id, 471, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(484, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(486, 13, false);
#line 13 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                                                        Write(bookList.Name);

#line default
#line hidden
            EndContext();
            BeginContext(499, 33, true);
            WriteLiteral("</a>\r\n                    </li>\r\n");
            EndContext();
#line 15 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(551, 47, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Users\Index.cshtml"
}

#line default
#line hidden
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