#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279cc0ac90aafcabd1496d7871cceb92f64e81dc"
// <auto-generated/>
#pragma warning disable 1591
namespace CinemaGo.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using CinemaGo.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using CinemaGo.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{name}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
        * {
            box-sizing: border-box;
        }

        .column {
            float: left;
            width: 33.33%;
            padding: 5px;
        }

        /* Clearfix (clear floats) */
        .row::after {
            content: """";
            clear: both;
            display: table;
        }
    </style>

    <br>
    ");
            __builder.AddMarkupContent(1, "<p class=\"text-center\" style=\"text-decoration-line:underline;font-size:100px\">Movie Booking</p>\r\n    ");
            __builder.AddMarkupContent(2, "<h2 style=\"text-decoration-line:underline\">Selected Movie</h2>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "media-body align-content-start ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
#nullable restore
#line 38 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
             if (productList == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 41 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-unstyled");
#nullable restore
#line 45 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
             foreach (var (index, prod) in productList.Select((prod, i) => (i + 1, prod)))
            {
                if (@prod.Name == @Name)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "media my-3");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container mt-5 ");
            __builder.OpenElement(14, "form");
            __builder.AddAttribute(15, "class", " row g-3 ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", " col-md-3");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "media-img-wrapper mr-3");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "class", "media-img");
            __builder.AddAttribute(22, "src", "http://localhost:36313/" + (
#nullable restore
#line 55 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                                                                            prod.ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "alt", 
#nullable restore
#line 55 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                                                                                                 prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", " col-md-9");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "media-body align-content-start ");
            __builder.AddMarkupContent(29, "<b>Title </b>\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(30, 
#nullable restore
#line 63 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                         prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                                        <br>\r\n                                        ");
            __builder.AddMarkupContent(32, "<b>Description </b>\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(33, 
#nullable restore
#line 67 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                         prod.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n                                        <br>\r\n                                        ");
            __builder.AddMarkupContent(35, "<b>Release Date </b>\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(36, 
#nullable restore
#line 71 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                         prod.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\r\n                                        <br>\r\n                                        ");
            __builder.AddMarkupContent(38, "<b>Language </b>\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(39, 
#nullable restore
#line 75 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                         prod.Language

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                                        <br>\r\n                                        ");
            __builder.AddMarkupContent(41, "<b>Running Time </b>\r\n                                        <br>\r\n                                        ");
            __builder.AddContent(42, 
#nullable restore
#line 79 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                         prod.RunningTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "\r\n                                        <br>\r\n                                        ");
            __builder.OpenElement(44, "p");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 81 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                                     prod.TrailerUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "class", "link-info link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover");
            __builder.AddAttribute(48, "target", "_blank");
            __builder.AddContent(49, "[Trailer]");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "li");
            __builder.AddMarkupContent(52, "<h2 style=\"text-decoration-line:underline\">Select Seat</h2>\r\n                        ");
            __builder.OpenComponent<CinemaGo.Web.Pages.SelectSeat>(53);
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n                        <br>\r\n                        ");
            __builder.AddMarkupContent(55, "<h2 style=\"text-decoration-line:underline\">Select Seat Type</h2>\r\n                        ");
            __builder.OpenComponent<CinemaGo.Web.Components.SeatType>(56);
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "container text-center");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", "/mycart");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                                                        (() => AddToCart_Click(prod))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "<br>\r\n                                ");
            __builder.AddMarkupContent(64, "<span style=\"font-size:30px; vertical-align:central; padding:7px; color:black; border-radius:100%; padding-top:10px;font-weight:bold; border:solid\"><sup>Book Now</sup></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 102 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
                    
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 106 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
           
        [Parameter]
        public string Name { get; set; }
        [CascadingParameter]
        public EventCallback notify { get; set; }
        public ProductModel productModel { get; set; }
        public List<ProductModel> productList { get; set; }
        public int prodSelected;
        public List<CartModel> myCart { get; set; }
        public bool cartFlag = false;

        protected override async Task OnInitializedAsync()
        {
            productModel = new ProductModel();
            await GetProducts();
        }

        private async Task GetProducts()
        {
            productList = await userPanelService.GetProducts();
        }

        private async Task AddToCart_Click(ProductModel productClicked)
        {
            cartFlag = true;

            var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");


            if (!result.Success)
            {
                myCart = new List<CartModel>();

                if (productClicked.CartFlag)
                {
                    var existing_product = myCart.Where(x => x.ProductId == productClicked.Id).FirstOrDefault();
                    if (existing_product != null)
                    {
                        myCart.Remove(existing_product);
                        await sessionStorage.SetAsync("myCart", myCart);

                    }
                }
                else
                {

                    CartModel cm = new CartModel();

                    cm.ProductId = productClicked.Id;

                    cm.Quantity = 1;
                    cm.AvailableStock = Convert.ToInt32(productClicked.Stock);

                    cm.ProductName = productClicked.Name;

                    cm.ProductImage = productClicked.ImageUrl;

                    cm.Price = Convert.ToInt32(productClicked.Price);

                    myCart.Add(cm);

                    await sessionStorage.SetAsync("myCart", myCart);
                }
            }
            else
            {
                myCart = result.Value;
                if (productClicked.CartFlag)
                {
                    var existing_product = myCart.Where(x => x.ProductId == productClicked.Id).FirstOrDefault();
                    if (existing_product != null)
                    {
                        myCart.Remove(existing_product);
                        await sessionStorage.SetAsync("myCart", myCart);
                    }
                }
                else
                {

                    CartModel cm = new CartModel();

                    cm.ProductId = productClicked.Id;

                    cm.Quantity = 1;
                    cm.AvailableStock = Convert.ToInt32(productClicked.Stock);

                    cm.ProductName = productClicked.Name;

                    cm.ProductImage = productClicked.ImageUrl;

                    cm.Price = Convert.ToInt32(productClicked.Price);

                    myCart.Add(cm);

                    await sessionStorage.SetAsync("myCart", myCart);
                }
            }
            await notify.InvokeAsync();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                var result = await sessionStorage.GetAsync<List<CartModel>>("myCart");
                if (result.Success)
                {
                    cartFlag = true;
                }
            }

        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
#pragma warning restore 1591
