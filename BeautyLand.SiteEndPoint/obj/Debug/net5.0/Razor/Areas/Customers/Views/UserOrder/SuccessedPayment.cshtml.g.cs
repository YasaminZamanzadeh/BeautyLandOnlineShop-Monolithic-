#pragma checksum "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\SuccessedPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155db5442560dd896d7c2b2f7b6a8377ecabb160"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customers_Views_UserOrder_SuccessedPayment), @"mvc.1.0.view", @"/Areas/Customers/Views/UserOrder/SuccessedPayment.cshtml")]
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
#line 1 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\_ViewImports.cshtml"
using BeautyLand.SiteEndPoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\_ViewImports.cshtml"
using BeautyLand.SiteEndPoint.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155db5442560dd896d7c2b2f7b6a8377ecabb160", @"/Areas/Customers/Views/UserOrder/SuccessedPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330aa8184e8749ed2a4e8189e432ec2669c1a8c2", @"/Areas/Customers/Views/_ViewImports.cshtml")]
    public class Areas_Customers_Views_UserOrder_SuccessedPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\SuccessedPayment.cshtml"
  
    ViewData["Title"] = "SuccessedPayment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""page-content my-5"">
    <div class=""container"">
        <div class=""row mb-4"">
            <div class=""col-xl-9 col-lg-8 col-md-8 mb-md-0 mb-3"">
                <div class=""checkout-section shadow-around"">
                    <div class=""checkout-step"">
                        <ul>
                            <li class=""active"">
                                <a href=""#""><span>سبد خرید</span></a>
                            </li>
                            <li class=""active"">
                                <span>نحوه ارسال و پرداخت</span>
                            </li>
                            <li class=""active"">
                                <span>اتمام خرید و ارسال</span>
                            </li>
                        </ul>
                    </div>
                    <div class=""checkout-message"">
                        <div class=""checkout-message-success mb-3"">
                            <div class=""icon-message success-icon"">
                ");
            WriteLiteral("                <i class=\"fas fa-check\"></i>\r\n                            </div>\r\n                            ");
#nullable restore
#line 30 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\SuccessedPayment.cshtml"
                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div class=""text-center text-muted"">
                            <p class=""mb-4"">
                              از اینکه ما را برای خرید انتخاب کردید از
                                شما سپاسگزاریم.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-4 col-md-4"">
                <div class=""shadow-around pt-3"">
                    <div class=""d-flex justify-content-between px-3 py-2"">
                        <span class=""text-muted"">نام تحویل گیرنده:</span>
                        <span class=""text-muted"">
                            جلال بهرامی راد
                        </span>
                    </div>
                    <div class=""d-flex justify-content-between px-3 py-2"">
                        <span class=""text-muted"">شماره تماس :</span>
                        <span class=""text-danger"">
           ");
            WriteLiteral(@"                 09121234567
                        </span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between px-3 py-2"">
                        <span class=""font-weight-bold"">مبلغ کل:</span>
                        <span class=""font-weight-bold"">
                            ۳۰,۸۶۸,۰۰۰
                            <span class=""text-sm"">تومان</span>
                        </span>
                    </div>
                    <hr>
                    <div class=""px-3 py-2"">
                        <span class=""text-muted d-block"">آدرس :</span>
                        <span class=""text-info"">
                            تهران، بلوار فرحزادی، نبش سیمای ایران
                        </span>
                    </div>
                    <div class=""px-3 py-4"">
                        <a href=""#"" class=""d-flex align-items-center justify-content-center px-4 py-2 btn btn-primary"">
                            پیگیری
              ");
            WriteLiteral("              سفارش <i class=\"fad fa-clipboard-list mr-3\"></i>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
