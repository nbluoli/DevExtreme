#pragma checksum "I:\我的项目\组件\DevExtreme\DevExtreme.AspNet.Data\DevExtreme.AspNet.Data-2.5.1\net\Sample\Views\Home\SearchApi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dcf0d9c1d7b6c82b537c8341164f2388b30c768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchApi), @"mvc.1.0.view", @"/Views/Home/SearchApi.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcf0d9c1d7b6c82b537c8341164f2388b30c768", @"/Views/Home/SearchApi.cshtml")]
    public class Views_Home_SearchApi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "I:\我的项目\组件\DevExtreme\DevExtreme.AspNet.Data\DevExtreme.AspNet.Data-2.5.1\net\Sample\Views\Home\SearchApi.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"lookup\"></div>\n<script>\n    $(function() {\n        $(\"#lookup\").dxLookup({\n            dataSource: DevExpress.data.AspNet.createStore({\n                loadUrl: \"");
#nullable restore
#line 10 "I:\我的项目\组件\DevExtreme\DevExtreme.AspNet.Data\DevExtreme.AspNet.Data-2.5.1\net\Sample\Views\Home\SearchApi.cshtml"
                     Write(Url.Action("Products", "Northwind"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n            }),\n            valueExpr: \"productId\",\n            displayExpr: \"productName\",\n            searchEnabled: true\n        });\n    });\n</script>\n");
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