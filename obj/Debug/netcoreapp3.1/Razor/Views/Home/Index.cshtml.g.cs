#pragma checksum "G:\DACN\dacn\dacn\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35c31524e4258b4be3e39c96fdd2fd85996a72b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\DACN\dacn\dacn\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e35c31524e4258b4be3e39c96fdd2fd85996a72b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <!-- HEADER  -->\r\n    <header class=\"header\">\r\n\r\n        <div class=\"container d-flex justify-content-between align-items-center h-100 text-center\">\r\n            <div class=\"header__content mx-auto\">\r\n");
            WriteLiteral(@"                
            </div>
        </div>

    </header>
    <!-- BANNER  -->

    <div class=""banner"">
        <div class=""container"">
            <h2 class=""banner__heading heading"">
                <h1>Wander Lust - Hành trình hạnh phúc - Muôn nẻo yêu thương</h1>
            </h2>
            <div class=""row"">
                <div class=""col-12 col-md-4"">
                    <div class=""banner__item"">
                        <img class=""img-fluid"" src=""./assets/images/banner1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 923, "\"", 929, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""banner__item-img"">
                    </div>
                </div>
                <div class=""col-12 col-md-4"">
                    <div class=""banner__item"">
                        <img class=""img-fluid"" src=""./assets/images/banner2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1214, "\"", 1220, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"banner__item-img\">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-12 col-md-4\">\r\n                    <div class=\"banner__item\">\r\n                        <img class=\"img-fluid\" src=\"./assets/images/banner3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1476, "\"", 1482, 0);
            EndWriteAttribute();
            WriteLiteral("\r\n                            class=\"banner__item-img\">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <!-- SERVICE  -->\r\n");
            WriteLiteral("\r\n    <!-- ROOM HOT -->\r\n");
            WriteLiteral("\r\n    <!-- NEWS  -->\r\n\r\n    <div class=\"news\">\r\n        <div class=\"container\">\r\n            <h2 class=\"news__heading heading\">\r\n                <h1>Tin tức</h1>\r\n            </h2>\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 246 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Posts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-md-3\">\r\n                        <div class=\"news__item\">\r\n                            <div class=\"news__img\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 11189, "\"", 11210, 1);
#nullable restore
#line 251 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
WriteAttributeValue("", 11195, item.Thumbnail, 11195, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 11211, "\"", 11217, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <h2 class=\"news__title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 11345, "\"", 11373, 2);
            WriteAttributeValue("", 11352, "/blog/detail/", 11352, 13, true);
#nullable restore
#line 254 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
WriteAttributeValue("", 11365, item.Id, 11365, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 255 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h2>\r\n                            <div class=\"news__description\">\r\n                                ");
#nullable restore
#line 259 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 263 "G:\DACN\dacn\dacn\Views\Home\Index.cshtml"
                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
     <script>
        $(function () {
            $('input[id$=datepicker]').datepicker({
                dateFormat: 'dd/mm/yy'
            });
            const now = new Date();
            $(""#datepicker"").val(now.toLocaleDateString('en-GB'));
        });

    </script>
    ");
            }
            );
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
