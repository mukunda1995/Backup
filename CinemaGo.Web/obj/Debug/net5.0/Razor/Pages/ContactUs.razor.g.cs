#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13cb40d7b2550b40fb58fa65dcd83048398d7e5"
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
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactus")]
    public partial class ContactUs : Microsoft.AspNetCore.Components.ComponentBase
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
</style>");
#nullable restore
#line 83 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
 if (contactModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 86 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<h4 class=\"card-header\">Contact US</h4>\r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 93 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                              contactModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 93 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                           SaveContact

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-row");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group col-5");
                __builder2.AddMarkupContent(17, "<label>First Name :</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 98 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                contactModel.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactModel.FirstName = __value, contactModel.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contactModel.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __Blazor.CinemaGo.Web.Pages.ContactUs.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 99 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                  () => contactModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-row");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group col-5");
                __builder2.AddMarkupContent(31, "<label>Last Name :</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 105 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                contactModel.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactModel.LastName = __value, contactModel.LastName))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contactModel.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __Blazor.CinemaGo.Web.Pages.ContactUs.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 106 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                  () => contactModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-row");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group col-5");
                __builder2.AddMarkupContent(45, "<label>Email :</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 112 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                contactModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactModel.Email = __value, contactModel.Email))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contactModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.CinemaGo.Web.Pages.ContactUs.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 113 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                  () => contactModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-row");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group col-5");
                __builder2.AddMarkupContent(59, "<label>Phone Number :</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 119 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                contactModel.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactModel.PhoneNumber = __value, contactModel.PhoneNumber))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contactModel.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __Blazor.CinemaGo.Web.Pages.ContactUs.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 120 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                  () => contactModel.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-row");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group col-5");
                __builder2.AddMarkupContent(73, "<label>Comment :</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 126 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                contactModel.Comment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contactModel.Comment = __value, contactModel.Comment))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contactModel.Comment));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n                        ");
                __Blazor.CinemaGo.Web.Pages.ContactUs.TypeInference.CreateValidationMessage_4(__builder2, 80, 81, 
#nullable restore
#line 127 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                  () => contactModel.Comment

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                <textarea class=\" form-control \" id=\"Comments\" rows=\" 4\" required></textarea>\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "text-left");
                __builder2.AddMarkupContent(85, "<input type=\"submit\" class=\"btn btn-primary\" value=\"Save\">\r\n                    ");
                __builder2.OpenElement(86, "input");
                __builder2.AddAttribute(87, "type", "button");
                __builder2.AddAttribute(88, "class", "btn btn-primary");
                __builder2.AddAttribute(89, "value", "Clear");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 133 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
                                                                                         ClearForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\ContactUs.razor"
       
    [CascadingParameter]
    public EventCallback notify { get; set; }
    public ContactModel contactModel { get; set; }

    public List<ContactModel> contactList { get; set; }

    public ContactModel contactToUpdate { get; set; }

    public ContactModel contactToDelete { get; set; }

    public bool showEditPopup = false;

    public bool showDeletePopup = false;

    public bool successPopup = false;

    public string Message = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        contactModel = new ContactModel();
        await GetContacts();

    }

    private async Task SaveContact()
    {
        await userPanelService.SaveContact(contactModel);
        Message = "Messege Added Successfully !";
        ToggleSuccessPopup();
        contactModel = new ContactModel();
        await GetContacts();
    }

    private async Task GetContacts()
    {
        contactList = await userPanelService.GetContacts();
    }

    private void ClearForm()
    {
        contactModel = new ContactModel();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
    }
}
namespace __Blazor.CinemaGo.Web.Pages.ContactUs
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
