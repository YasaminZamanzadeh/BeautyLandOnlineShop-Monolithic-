#pragma checksum "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ee7c57af722a1f303548deea554fd3c23bb23b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customers_Views_UserOrder_FailedPayment), @"mvc.1.0.view", @"/Areas/Customers/Views/UserOrder/FailedPayment.cshtml")]
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
#nullable restore
#line 1 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
using BeautyLand.Application.Services.Site.UserAddress;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee7c57af722a1f303548deea554fd3c23bb23b5", @"/Areas/Customers/Views/UserOrder/FailedPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330aa8184e8749ed2a4e8189e432ec2669c1a8c2", @"/Areas/Customers/Views/_ViewImports.cshtml")]
    public class Areas_Customers_Views_UserOrder_FailedPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserAddressDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
  
    ViewData["Title"] = "FailedPayment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""page-content"">
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
                        <div class=""checkout-message-failed mb-3"">
                            <div class=""icon-message failed-icon"">
                         ");
            WriteLiteral("       <i class=\"fas fa-times\"></i>\r\n                            </div>\r\n                            ");
#nullable restore
#line 30 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div class=""text-center text-muted"">
                            <p class=""mb-1"">
                                برای جلوگیری از لغو سیستمی سفارش، تا ۱ ساعت آینده پرداخت را انجام دهید.
                            </p>
                            <p class=""text-sm"">
                                چنانچه طی این فرایند مبلغی از حساب شما کسر شده است، طی ۷۲ ساعت آینده به حساب شما
                                باز خواهد گشت
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
                            ");
#nullable restore
#line 50 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <div class=""d-flex justify-content-between px-3 py-2"">
                        <span class=""text-muted""> کدپستی</span>
                        <span class=""text-danger"">
                            ");
#nullable restore
#line 56 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
                       Write(Model.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                            ");
#nullable restore
#line 71 "D:\BeautyLand\BeautyLand.SiteEndPoint\Areas\Customers\Views\UserOrder\FailedPayment.cshtml"
                       Write(Model.PostalAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </span>
                    </div>
                    <div class=""px-3 py-4"">
                        <a href=""#"" class=""d-flex align-items-center justify-content-center px-4 py-2 btn btn-danger"">
                            پرداخت
                            مجدد<i class=""fad fa-redo mr-3""></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
        <section class=""product-carousel"">
            <div class=""section-title"">
                <i class=""fad fa-retweet""></i>
                محصولات مرتبط
            </div>
            <div class=""swiper-container slider-lg swiper-container-initialized swiper-container-horizontal swiper-container-rtl"">
                <div class=""swiper-wrapper"" style=""transform: translate3d(0px, 0px, 0px);"">
                    <div class=""swiper-slide swiper-slide-active"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
    ");
            WriteLiteral("                        <div class=\"product-card-top\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4412, "\"", 4419, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/01.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">
                             ");
            WriteLiteral(@"           میز تحریر تاشوو تنظیم شو میلاد سفید
                                        70
                                    </a>
                                </h6>
                                <div class=""product-price product-price-clone""> </div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide swiper-slide-next"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                     ");
            WriteLiteral("       <div class=\"product-card-top\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6541, "\"", 6548, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/02.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">میز تحریر مدل M191</a>
       ");
            WriteLiteral(@"                         </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                            <div class=""product-card-top"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 8523, "\"", 8530, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/03.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">
                             ");
            WriteLiteral(@"           میز تحریر و لپ تاپ تاشو سایز بزرگ مدل
                                        G0025
                                    </a>
                                </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                      ");
            WriteLiteral("      <div class=\"product-card-top\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 10651, "\"", 10658, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/04.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">میز تحریر مدل 80 Owens B</a>
 ");
            WriteLiteral(@"                               </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                            <div class=""product-card-top"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 12639, "\"", 12646, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/05.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">میز تحریر مدل الیت</a>
       ");
            WriteLiteral(@"                         </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                            <div class=""product-card-top"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 14621, "\"", 14628, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/06.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">میز تحریر مدل چند حالته MT11</a");
            WriteLiteral(@">
                                </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                            <div class=""product-card-top"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 16613, "\"", 16620, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/07.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">
                             ");
            WriteLiteral(@"           میز تحریر تاشو و تنظیم شو سپهر یاس مدل
                                        60
                                    </a>
                                </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""swiper-slide"" style=""width: 234.8px; margin-left: 10px;"">
                        <div class=""product-card"">
                        ");
            WriteLiteral("    <div class=\"product-card-top\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 18739, "\"", 18746, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-image"">
                                    <img src=""./assets/images/products/08.jpg"" alt=""product image"">
                                </a>
                                <div class=""product-card-actions"">
                                    <button class=""add-to-wishlist""><i class=""fas fa-heart""></i></button>
                                    <button class=""add-to-compare""><i class=""fas fa-random""></i></button>
                                </div>
                            </div>
                            <div class=""product-card-middle"">
                                <div class=""ratings-container"">
                                    <div class=""ratings"">
                                        <div class=""ratings-val"" style=""width: 65%;""></div>
                                    </div>
                                </div>
                                <h6 class=""product-name"">
                                    <a href=""#"">
                             ");
            WriteLiteral(@"           میز تحریر باکسدار و صندلی طرح توت فرنگی
                                        (وایت بردی،تاشو،تنظیم شونده ارتفاع)
                                    </a>
                                </h6>
                                <div class=""product-price product-price-clone"">650,000 تومان</div>
                            </div>
                            <div class=""product-card-bottom"">
                                <div class=""product-price"">
                                    650,000 تومان
                                </div>
                                <a href=""#"" class=""btn-add-to-cart"">
                                    <i class=""fad fa-cart-plus""></i>
                                    افزودن به سبد خرید
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Add Arrows -->
                <div class=""swiper-button-next"" tabindex=""0"" role=""butto");
            WriteLiteral(@"n"" aria-label=""Next slide"" aria-disabled=""false""></div>
                <div class=""swiper-button-prev swiper-button-disabled"" tabindex=""0"" role=""button"" aria-label=""Previous slide"" aria-disabled=""true""></div>
                <span class=""swiper-notification"" aria-live=""assertive"" aria-atomic=""true""></span>
            </div>
        </section>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserAddressDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
