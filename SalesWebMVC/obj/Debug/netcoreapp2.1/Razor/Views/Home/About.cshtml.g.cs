#pragma checksum "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e571897ce6823fb483167226b1fb42a8d917622d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC;

#line default
#line hidden
#line 2 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e571897ce6823fb483167226b1fb42a8d917622d", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6df1509d91b065201157174002cf59bdfba603", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 19, true);
            WriteLiteral("</h2>\r\n<br />\r\n<h4>");
            EndContext();
            BeginContext(83, 19, false);
#line 6 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 24, true);
            WriteLiteral("</h4>\r\n\r\n<h4>Professor: ");
            EndContext();
            BeginContext(127, 21, false);
#line 8 "C:\Users\amiqu\Box\Curso Nelio C#\projetos\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
          Write(ViewData["Professor"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 141, true);
            WriteLiteral("</h4>\r\n<br />\r\n<adress>\r\n        <strong> More information: </strong> <a href=\"http://educandoweb.com.br\">Educandoweb.com.br</a>\r\n</adress>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
