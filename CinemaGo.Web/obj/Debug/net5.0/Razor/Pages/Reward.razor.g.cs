#pragma checksum "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae3d3e7891b2c720595f09484ec2624b84095268"
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
#line 3 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
using CinemaGo.DataModels.CustomModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
using CinemaGo.Web.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reward")]
    public partial class Reward : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    \r\n    input[type=radio] {\r\n        border: 0px;\r\n        width: 20%;\r\n        height: 1em;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<h3>Reward</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "reward");
            __builder.OpenElement(4, "table");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<td>Cinema Type</td>\r\n            ");
            __builder.OpenElement(7, "td");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", " text-align : left; margin:0px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 29 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                                     cinematypeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.CinemaGo.Web.Pages.Reward.TypeInference.CreateInputRadioGroup_0(__builder2, 13, 14, 
#nullable restore
#line 30 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                                                      cinematypeModel.Name

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cinematypeModel.Name = __value, cinematypeModel.Name)), 16, () => cinematypeModel.Name, 17, (__builder3) => {
#nullable restore
#line 31 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                             foreach (var option in rdOptions)
                            {

#line default
#line hidden
#nullable disable
                    __Blazor.CinemaGo.Web.Pages.Reward.TypeInference.CreateInputRadio_1(__builder3, 18, 19, 
#nullable restore
#line 33 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                                                   option

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(20, 
#nullable restore
#line 33 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                                                               option

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(21, " <br>");
#nullable restore
#line 34 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
     if (cinematypeModel.Name == "GSC")
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<div class=\"container text-center\"><div class=\"row\"><div class=\"col col-md-4\"><a href=\"https://epaymentwebapp.gsc.com.my/login\" target=\"_blank\"><img src=\"https://i.ibb.co/gvpqhDg/GSC-JOM-Rewards.png\"></a></div></div></div>\r\n        ");
            __builder.AddMarkupContent(23, "<div class=\"container text-center\"><div class=\"col col-md-4\"><a href=\"https://eticket.gsc.com.my/sign\" target=\"_blank\"><img src=\"https://i.ibb.co/xhLdvWj/Gsc-Rewards.png\"></a></div></div>");
#nullable restore
#line 60 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
    }
    else if (cinematypeModel.Name == "TGV")
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, @"<div class=""container text-center""><div class=""col col-md-4""><a href=""https://www.tgv.com.my/promotions/all-year-long-deals-more-savings-more-movies"" target=""_blank""><img src=""https://i.ibb.co/YTvjM6D/a89073fa-88b5-48f0-aa22-d8cf94ec7a84-original.jpg""></a></div></div>");
#nullable restore
#line 70 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
    }
    else if (cinematypeModel.Name == "MBO")
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<div class=\"container text-center\"><div class=\"col col-md-4\"><a href=\"https://mbocinemas.com/Browsing/Loyalty/Clubs/1\" target=\"_blank\"><img src=\"https://i.ibb.co/rZf3KMh/mbo.png\"></a></div></div>");
#nullable restore
#line 80 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
    }
    else if (cinematypeModel.Name == "LFS")
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<div class=\"container text-center\"><div class=\"col col-md-4\"><a href=\"https://www.lfs.com.my/Promotion\" target=\"_blank\"><img src=\"https://i.ibb.co/26CPk48/promotion-web-923.jpg\" style=\"height:800px;width:800px;\"></a></div></div>");
#nullable restore
#line 90 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\mukunda\Desktop\New folder\CinemaGo\CinemaGo.Web\Pages\Reward.razor"
       

    [CascadingParameter]
    public EventCallback notify { get; set; }
    public string cinematypeMode { get; set; }

    protected override Task OnInitializedAsync()
    {

        cinematypeMode = "GSC";
        return base.OnInitializedAsync();
    }

    CinemaTypeModeModel cinematypeModel = new CinemaTypeModeModel()
    {
        Name = "GSC"// default value
    };

    List<string> rdOptions = new List<string> { "GSC", "TGV", "MBO", "LFS" };

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserPanelService userPanelService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage sessionStorage { get; set; }
    }
}
namespace __Blazor.CinemaGo.Web.Pages.Reward
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputRadio_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591