#pragma checksum "C:\Users\han\Documents\GitHub\PatientMgt\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a832660699397a50d7f90ab5444269371505384c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a832660699397a50d7f90ab5444269371505384c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce34145fc8318537b1df93509467826b7e4fc152", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "C:\Users\han\Documents\GitHub\PatientMgt\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n");
            WriteLiteral(@"    <p>Patient oriented Ultrasound Charting System</p>
    <h5>Sharing Ultrasound Images for Contined Medical Education.</h5>
</div>

  <!-- Masthead -->
  
   
    <div class=""container"">
      <div class=""row"">
        <div class=""col-xl-9 mx-auto"">
          <p class=""mb-5 text-center"">Build a personl ultrasound page for your patients!</p>
        </div>
        <div class=""col-md-10 col-lg-8 col-xl-7 mx-auto"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a832660699397a50d7f90ab5444269371505384c3917", async() => {
                WriteLiteral(@"
            <div class=""form-row"">
              <div class=""col-12 col-md-9 mb-2 mb-md-0"">
                <input type=""email"" class=""form-control form-control-lg"" placeholder=""Enter your email..."">
              </div>
              <div class=""col-12 col-md-3"">
                <button type=""submit"" class=""btn btn-block btn-lg btn-primary"">Sign up!</button>
              </div>
            </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
      </div>
    </div>
  

  <!-- Icons Grid -->
  <section class=""features-icons bg-light text-center"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-4"">
          <div class=""features-icons-item mx-auto mb-5 mb-lg-0 mb-lg-3"">
            <div class=""features-icons-icon d-flex"">
              <i class=""icon-screen-desktop m-auto text-primary""></i>
            </div>
            <h3>Fully Responsive</h3>
            <p class=""lead mb-0"">This theme will look great on any device, no matter the size!</p>
          </div>
        </div>
        <div class=""col-lg-4"">
          <div class=""features-icons-item mx-auto mb-5 mb-lg-0 mb-lg-3"">
            <div class=""features-icons-icon d-flex"">
              <i class=""icon-layers m-auto text-primary""></i>
            </div>
            <h3>Bootstrap 4 Ready</h3>
            <p class=""lead mb-0"">Featuring the latest build of the new Bootstrap 4 framework!</p>
          </div>
        </div>
");
            WriteLiteral(@"        <div class=""col-lg-4"">
          <div class=""features-icons-item mx-auto mb-0 mb-lg-3"">
            <div class=""features-icons-icon d-flex"">
              <i class=""icon-check m-auto text-primary""></i>
            </div>
            <h3>Easy to Use</h3>
            <p class=""lead mb-0"">Ready to use with your own content, or customize the source files!</p>
          </div>
        </div>
      </div>
    </div>
  </section>





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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591