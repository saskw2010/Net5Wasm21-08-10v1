#pragma checksum "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56427c8b9e095609b57446e7a880b108a43b4028"
// <auto-generated/>
#pragma warning disable 1591
namespace Net5Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Net5Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\_Imports.razor"
using Net5Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Net5Wasm.Models.Net5Wasmconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Net5Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-shopping-cart")]
    public partial class AddShoppingCart : Net5Wasm.Pages.AddShoppingCartComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Net5Wasm.Models.Net5Wasmconn.ShoppingCart>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Net5Wasm.Models.Net5Wasmconn.ShoppingCart>(
#nullable restore
#line 18 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                   shoppingcart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                            shoppingcart != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Net5Wasm.Models.Net5Wasmconn.ShoppingCart>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Net5Wasm.Models.Net5Wasmconn.ShoppingCart>(this, 
#nullable restore
#line 18 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                                                                              Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Created On");
                    __builder3.AddAttribute(19, "Component", "CreatedOn");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCart.TypeInference.CreateRadzenDatePicker_0(__builder3, 24, 25, "dd/MM/yyyy", 26, "display: block; width: 100%", 27, "CreatedOn", 28, 
#nullable restore
#line 26 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                                             shoppingcart.CreatedOn

#line default
#line hidden
#nullable disable
                    , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcart.CreatedOn = __value, shoppingcart.CreatedOn)), 30, () => shoppingcart.CreatedOn);
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(32);
                    __builder3.AddAttribute(33, "Component", "CreatedOn");
                    __builder3.AddAttribute(34, "Text", "CreatedOn is required");
                    __builder3.AddAttribute(35, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(36, "\n            ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(39, "class", "row");
                    __builder3.OpenElement(40, "div");
                    __builder3.AddAttribute(41, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(42);
                    __builder3.AddAttribute(43, "Text", "Modified On");
                    __builder3.AddAttribute(44, "Component", "ModifiedOn");
                    __builder3.AddAttribute(45, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n              ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-md-9");
                    __Blazor.Net5Wasm.Client.Pages.AddShoppingCart.TypeInference.CreateRadzenDatePicker_1(__builder3, 49, 50, "dd/MM/yyyy", 51, "width: 100%", 52, "ModifiedOn", 53, 
#nullable restore
#line 38 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                             shoppingcart.ModifiedOn

#line default
#line hidden
#nullable disable
                    , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcart.ModifiedOn = __value, shoppingcart.ModifiedOn)), 55, () => shoppingcart.ModifiedOn);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenElement(57, "div");
                    __builder3.AddAttribute(58, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(59, "class", "row");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(62);
                    __builder3.AddAttribute(63, "Text", "User Id");
                    __builder3.AddAttribute(64, "Component", "UserId");
                    __builder3.AddAttribute(65, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n              ");
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(69);
                    __builder3.AddAttribute(70, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 48 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                          450

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(72, "Name", "UserId");
                    __builder3.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                                  shoppingcart.UserId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shoppingcart.UserId = __value, shoppingcart.UserId))));
                    __builder3.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shoppingcart.UserId));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(77);
                    __builder3.AddAttribute(78, "Component", "UserId");
                    __builder3.AddAttribute(79, "Text", "UserId is required");
                    __builder3.AddAttribute(80, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\n            ");
                    __builder3.OpenElement(82, "div");
                    __builder3.AddAttribute(83, "class", "row");
                    __builder3.OpenElement(84, "div");
                    __builder3.AddAttribute(85, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(86);
                    __builder3.AddAttribute(87, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 56 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "Icon", "save");
                    __builder3.AddAttribute(89, "Text", "Save");
                    __builder3.AddAttribute(90, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 56 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(92);
                    __builder3.AddAttribute(93, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 58 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(95, "Text", "Cancel");
                    __builder3.AddAttribute(96, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\AddShoppingCart.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Net5Wasm.Client.Pages.AddShoppingCart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
