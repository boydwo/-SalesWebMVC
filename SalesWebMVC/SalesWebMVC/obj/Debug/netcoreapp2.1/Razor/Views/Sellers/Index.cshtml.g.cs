#pragma checksum "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c70a725e85f230e45978f2fb54726a7f5bbec435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
#line 1 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC;

#line default
#line hidden
#line 2 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c70a725e85f230e45978f2fb54726a7f5bbec435", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6df1509d91b065201157174002cf59bdfba603", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMVC.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
  
    ViewData["Title"] = "Sellers";

#line default
#line hidden
            BeginContext(92, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(99, 17, false);
#line 7 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(116, 119, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(236, 40, false);
#line 13 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(276, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(332, 41, false);
#line 16 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(373, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(429, 45, false);
#line 19 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(474, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(530, 46, false);
#line 22 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(576, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 27 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
         foreach ( var item in Model)
        {

#line default
#line hidden
            BeginContext(689, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(738, 39, false);
#line 31 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(777, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(833, 40, false);
#line 34 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(929, 44, false);
#line 37 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1029, 45, false);
#line 40 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaseSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 43 "C:\Projetos\GitHub\-SistemaDeVendas\SalesWebMVC\SalesWebMVC\Views\Sellers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1121, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMVC.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
