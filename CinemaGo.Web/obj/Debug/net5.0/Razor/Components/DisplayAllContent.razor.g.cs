#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6414d2ed9e5f6010d458ad4e4a080c1484e36b84"
// <auto-generated/>
#pragma warning disable 1591
namespace CinemaGo.Web.Components
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
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    public partial class DisplayAllContent : Microsoft.AspNetCore.Components.ComponentBase
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

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
#nullable restore
#line 29 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
     if (productList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 32 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "list-unstyled");
            __builder.AddMarkupContent(6, "<p class=\"text-center\" style=\"font-size:x-large; text-decoration-line:underline\">Now Showing Movies</p>");
#nullable restore
#line 37 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
     foreach (var (index, prod) in productList.Select((prod, i) => (i + 1, prod)))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "media my-3");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container mt-5 ");
            __builder.OpenElement(11, "form");
            __builder.AddAttribute(12, "class", " row g-3 ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", " col-md-3");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "media-img-wrapper mr-3");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/product/" + (
#nullable restore
#line 44 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                               prod.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "media-img");
            __builder.AddAttribute(21, "src", "http://localhost:36313/" + (
#nullable restore
#line 45 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                                                    prod.ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "alt", 
#nullable restore
#line 45 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                                                                                         prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", " col-md-9");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "media-body align-content-start ");
            __builder.AddMarkupContent(28, "<b>Title </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(29, 
#nullable restore
#line 53 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(31, "<b>Description </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(32, 
#nullable restore
#line 57 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(34, "<b>Release Date </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(35, 
#nullable restore
#line 61 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(37, "<b>Language </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(38, 
#nullable restore
#line 65 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.Language

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(40, "<b>Running Time </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(41, 
#nullable restore
#line 69 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.RunningTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(42, "\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(43, "<b>Seats stock </b>\r\n                            <br>\r\n                            ");
            __builder.AddContent(44, 
#nullable restore
#line 73 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                             prod.Stock

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n                            <br>\r\n                            ");
            __builder.OpenElement(46, "p");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "href", 
#nullable restore
#line 75 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
                                         prod.TrailerUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(49, "class", "link-info link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover");
            __builder.AddAttribute(50, "target", "_blank");
            __builder.AddContent(51, "[Trailer]");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Components\DisplayAllContent.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }
    public ProductModel productModel { get; set; }
    public List<ProductModel> products { get; set; }
    public List<ProductModel> productList { get; set; }


    protected override async Task OnInitializedAsync()
    {
        productModel = new ProductModel();
        await GetProducts();
    }

    private async Task GetProducts()
    {
        productList = await userPanelService.GetProducts();
    }




    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (firstRender)
            {
                await notify.InvokeAsync();
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
