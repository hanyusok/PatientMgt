#pragma checksum "C:\src\PatientMgt\Views\Charts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114cd4ba59d011f06660646e929d6ac50886405e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charts_Details), @"mvc.1.0.view", @"/Views/Charts/Details.cshtml")]
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
#line 1 "C:\src\PatientMgt\Views\_ViewImports.cshtml"
using PatientMgt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\PatientMgt\Views\_ViewImports.cshtml"
using PatientMgt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114cd4ba59d011f06660646e929d6ac50886405e", @"/Views/Charts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34145fc8318537b1df93509467826b7e4fc152", @"/Views/_ViewImports.cshtml")]
    public class Views_Charts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientMgt.Models.Patient.Chart>
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
#line 3 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>chart of ... patient</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Cn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 23 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 29 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.VisitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 35 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.VisitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 41 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.ChiefComplaint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 47 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.ChiefComplaint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.PresentIllness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 53 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PresentIllness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.PastHistory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 59 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.PastHistory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Medication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 65 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Medication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.Impression));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 71 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Impression));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.DxPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 77 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.DxPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.TxPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 83 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.TxPlan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayNameFor(model =>model.UltrasoundExam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 89 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
       Write(Html.DisplayFor(model => model.UltrasoundExam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>               \r\n    </dl>                                                                                   \r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 94 "C:\src\PatientMgt\Views\Charts\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }, new { cid = Model.Cn}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "114cd4ba59d011f06660646e929d6ac50886405e10899", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientMgt.Models.Patient.Chart> Html { get; private set; }
    }
}
#pragma warning restore 1591
