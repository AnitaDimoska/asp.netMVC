#pragma checksum "C:\Users\Anita\source\repos\LibraryHomeworkMVC\LibraryHomeworkMVC\Views\Borrow\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce931ca7b9f692b4df8177ecaf08bb5cf3ab48d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Borrow_Book), @"mvc.1.0.view", @"/Views/Borrow/Book.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Borrow/Book.cshtml", typeof(AspNetCore.Views_Borrow_Book))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce931ca7b9f692b4df8177ecaf08bb5cf3ab48d1", @"/Views/Borrow/Book.cshtml")]
    public class Views_Borrow_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryHomeworkMVC.Models.ViewModels.BorrowViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 374, true);
            WriteLiteral(@"
<form asp-route=""Book"" method=""post"">
    <h2>Create user: </h2>
    <label asp-for=""FirstName"">First Name</label>
    <input type=""text"" name=""FirstName"" value="""" /> <br />

    <label asp-for=""LastName"">Last Name</label>
    <input type=""text"" name=""LastName"" value="""" /> <br />

    <button type=""submit"" class=""btn btn-outline-success"">Borrow</button>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryHomeworkMVC.Models.ViewModels.BorrowViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
