#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6226ca595aefa0016a3eb9bb4d3bcc8f6581040c"
// <auto-generated/>
#pragma warning disable 1591
namespace CinemaGo.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using CinemaGo.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
using CinemaGo.Admin.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public partial class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .modal {
        position: fixed;
        z-index: 1;
        padding-top: 100px;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        overflow: hidden;
        background-color: rgb(0,0,0);
        background-color: rgba(0,0,0,0.4);
        display: block;
    }

    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 20px;
        padding: 20px;
        border: 1px solid #888;
        width: 50%;
        overflow: hidden;
    }

    .close {
        color: #aaaaaa;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
        .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }
</style>


");
            __builder.AddMarkupContent(1, "<h3>Orders</h3>");
#nullable restore
#line 50 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
 if (orderdetailModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 53 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body bg-dark");
#nullable restore
#line 57 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
         if (orderdetailList == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>");
#nullable restore
#line 60 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped table-bordered bg-light");
            __builder.AddMarkupContent(8, @"<thead><tr><th style=""width:15px;"">Sr.No</th>
                        <th>OrderId</th>
                        <th>ProductId</th>
                        <th>SeatQuantity</th>
                        <th>Total</th>
                        <th style=""width:80px;"">Delete?</th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 75 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                     foreach (var (index, msg) in orderdetailList.Select((msg, i) => (i + 1, msg)))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 78 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                 index

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 79 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                 msg.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 80 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                 msg.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 81 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                 msg.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 82 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                 msg.SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "value", "Delete");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                                                                                      (() => DeleteButtonClick(msg))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
 if (showDeletePopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-content");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-header");
            __builder.AddMarkupContent(38, "<h5>Delete Contact</h5>\r\n                ");
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "class", "close");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                              ToggleEditPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-body");
            __builder.AddMarkupContent(46, "\r\n                Are you sure you want to Delete");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "style", "background-color:yellow;");
            __builder.AddContent(49, 
#nullable restore
#line 102 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                                                                       orderdetailToDelete.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(50, " ?");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, " Orders\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-footer");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "value", "Yes");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                                                                   DeleteOrderDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 112 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
 if (successPopup == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "modal-content");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-header");
            __builder.AddMarkupContent(66, "\r\n                Alert ");
            __builder.OpenElement(67, "span");
            __builder.AddAttribute(68, "class", "close");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                                    ToggleSuccessPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "×");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-body");
            __builder.AddContent(74, 
#nullable restore
#line 121 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                 text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "modal-footer");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "btn btn-primary");
            __builder.AddAttribute(81, "value", "Close");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 124 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
                                                                                     ToggleSuccessPopup

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 128 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Admin\Pages\Orders.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }
    public OrderDetailModel orderdetailModel { get; set; }
    public List<OrderDetailModel> orderdetailList { get; set; }
    public bool showDeletePopup = false;
    public OrderDetailModel orderdetailToDelete { get; set; }
    public string text = string.Empty;
    public bool successPopup = false;
    public bool showEditPopup = false;

    protected override async Task OnInitializedAsync()
    {
        orderdetailModel = new OrderDetailModel();
        await GetOrderDetails();

    }

    private async Task GetOrderDetails()
    {
        orderdetailList = await adminPanelService.GetOrderDetails();

    }
    private async Task DeleteOrderDetail()
    {
        bool flag = await adminPanelService.DeleteOrderDetail(orderdetailToDelete);
        ToggleDeletePopup();
        if (flag)
        {
            text = "Messages Deleted Successfully !";
        }
        else
        {
            text = "Messages Not Deleted Try Again!";
        }

        ToggleSuccessPopup();
        orderdetailModel = new OrderDetailModel();
        await GetOrderDetails();
    }

    private void DeleteButtonClick(OrderDetailModel _orderdetailToDelete)
    {
        orderdetailToDelete = _orderdetailToDelete;
        ToggleDeletePopup();
    }
    private void ToggleEditPopup()
    {
        showEditPopup = showEditPopup == true ? false : true;
    }

    private void ToggleDeletePopup()
    {
        showDeletePopup = showDeletePopup == true ? false : true;
    }

    private void ToggleSuccessPopup()
    {
        successPopup = successPopup == true ? false : true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await notify.InvokeAsync();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminPanelService adminPanelService { get; set; }
    }
}
#pragma warning restore 1591