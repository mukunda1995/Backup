// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 250 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ProductDetails.razor"
       
    [Parameter]
    public string Name { get; set; }
    [CascadingParameter]
    public EventCallback notify { get; set; }
    public ProductModel productModel { get; set; }
    public List<ProductModel> productList { get; set; }
    public int prodSelected;
    public List<CartModel> myCart { get; set; }
    public bool cartFlag = false;

    public string testingShow = "testing";

    private string selectedSeatText = "Select a seat";
    private (int row, int seat)? selectedSeat;
    private int seatNumber;
    private int selectedSEAT;
    private string takenSeats;

    private void AddSeat()
    {
        takenSeats += $",{selectedSEAT}";
        testingShow = takenSeats;
    }


    private bool isSeatTaken = false;

    void SelectSeat(int row, int seat)
    {
        selectedSeat = (row, seat);
        selectedSeatText = $"Selected Row {row}, Seat {seat}";
        selectedSEAT = ((row - 1) * 22) + seat;
    }



    private bool IsSeatSelected(int row, int seat)
    {
        return selectedSeat.HasValue && selectedSeat.Value.row == row && selectedSeat.Value.seat == seat;
    }

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
                cm.ProductStatus = productClicked.Status;
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
                cm.ProductStatus = productClicked.Status;

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
