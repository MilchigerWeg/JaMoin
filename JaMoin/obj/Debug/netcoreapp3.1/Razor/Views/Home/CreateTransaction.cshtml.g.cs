#pragma checksum "G:\ProgrammingProjects\JaMoin\JaMoin\Views\Home\CreateTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aef55fa31d52a15ad580751122c0badf5b12f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateTransaction), @"mvc.1.0.view", @"/Views/Home/CreateTransaction.cshtml")]
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
#line 1 "G:\ProgrammingProjects\JaMoin\JaMoin\Views\_ViewImports.cshtml"
using JaMoin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ProgrammingProjects\JaMoin\JaMoin\Views\_ViewImports.cshtml"
using JaMoin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aef55fa31d52a15ad580751122c0badf5b12f4f", @"/Views/Home/CreateTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be910e304b07fc0ad00385d03208c177400a9dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JaMoin.Models.TransactionCreateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ProgrammingProjects\JaMoin\JaMoin\Views\Home\CreateTransaction.cshtml"
  
    ViewData["Title"] = "CreateTransaction";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Neue Transaktion</h1>\r\n\r\n\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">Geldgeber</div>\r\n        <div class=\"col-8\">\r\n            ");
#nullable restore
#line 14 "G:\ProgrammingProjects\JaMoin\JaMoin\Views\Home\CreateTransaction.cshtml"
       Write(Html.DropDownList("Geldleiher", Model.AllUsernames.Select(item => new SelectListItem
            {
                Value = item,
                Text = item
            })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""row"">
        <div class=""col-4"">Kommentar</div>
        <div class=""col-8"">
            <input type=""text"" placeholder=""Grund des Leihens"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col-4"">Gesamtbetrag</div>
        <div class=""col-8"">
            <input type=""number"" placeholder=""Gesamtbetrag"" min=""0"">
        </div>
    </div>
    <div>
        <!--TODO beteiligte Personen-->
    </div>
</div>

<input type=""button"" value=""Save"" id=""SaveButton"" />
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JaMoin.Models.TransactionCreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
