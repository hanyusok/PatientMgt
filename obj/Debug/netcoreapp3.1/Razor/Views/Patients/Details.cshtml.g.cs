#pragma checksum "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e472ca7800183fe9b5266d65c32cbd2bfbb4a920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_Details), @"mvc.1.0.view", @"/Views/Patients/Details.cshtml")]
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
#line 1 "C:\Users\han\Documents\GitHub\PatientMgt\Views\_ViewImports.cshtml"
using PatientMgt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\han\Documents\GitHub\PatientMgt\Views\_ViewImports.cshtml"
using PatientMgt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e472ca7800183fe9b5266d65c32cbd2bfbb4a920", @"/Views/Patients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34145fc8318537b1df93509467826b7e4fc152", @"/Views/_ViewImports.cshtml")]
    public class Views_Patients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientMgt.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>patient</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 316, "\"", 350, 1);
#nullable restore
#line 17 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
WriteAttributeValue("", 322, Url.Content(Model.ImageUrl), 322, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\"/>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Bill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bill));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Notice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Notice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Procedure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Procedure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Examination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Examination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>    \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Diagnosis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diagnosis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>     \r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Charts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Charts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>        \r\n    </dl>                                                                                   \r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 112 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Patients\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e472ca7800183fe9b5266d65c32cbd2bfbb4a92014098", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientMgt.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
