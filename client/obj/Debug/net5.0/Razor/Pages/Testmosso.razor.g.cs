#pragma checksum "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c37bfd5bdf7a71ab7e189b5b17c27fb5c64ff0d2"
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
#line 6 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Net5Wasm.Models.Net5Wasmconn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Net5Wasm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(BlazorshopLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/testmosso")]
    public partial class Testmosso : Net5Wasm.Pages.TestmossoComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "testmosso");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Radzen.ODataServiceResult<Net5Wasm.Models.Net5Wasmconn.Category>>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ODataServiceResult<Net5Wasm.Models.Net5Wasmconn.Category>>(
#nullable restore
#line 19 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                               categorylist

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(12, "class", "row");
                    __builder3.OpenElement(13, "div");
                    __builder3.AddAttribute(14, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDataList<Net5Wasm.Models.Net5Wasmconn.Category>>(15);
                    __builder3.AddAttribute(16, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                        getCategoriesCount

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Net5Wasm.Models.Net5Wasmconn.Category>>(
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                                   getCategoriesResult

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                                                                                                                10

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                                                                                                                                                Datalist0LoadData

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(22, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Net5Wasm.Models.Net5Wasmconn.Category>)((data) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCard>(23);
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(25, "div");
                            __builder5.AddAttribute(26, "class", "col-md-3");
                            __builder5.OpenElement(27, "div");
                            __builder5.AddAttribute(28, "class", "card card-product-grid");
                            __builder5.OpenElement(29, "a");
                            __builder5.AddAttribute(30, "href", "products/category/" + (
#nullable restore
#line 28 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                      data.Name

#line default
#line hidden
#nullable disable
                            ) + "/" + (
#nullable restore
#line 28 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                 data.Id

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(31, "class", "img-wrap");
                            __builder5.OpenElement(32, "img");
                            __builder5.AddAttribute(33, "src", 
#nullable restore
#line 29 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                         data.ImageSource

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(34, "\n                                          ");
                            __builder5.OpenElement(35, "figcaption");
                            __builder5.AddAttribute(36, "class", "info-wrap");
                            __builder5.OpenElement(37, "a");
                            __builder5.AddAttribute(38, "href", "products/category/" + (
#nullable restore
#line 32 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                          data.Name

#line default
#line hidden
#nullable disable
                            ) + "/" + (
#nullable restore
#line 32 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                                                     data.Id

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(39, "class", "title");
                            __builder5.AddContent(40, 
#nullable restore
#line 33 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                                   data.Name

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(41, "\n                              ");
                            __builder5.OpenElement(42, "div");
                            __builder5.AddContent(43, 
#nullable restore
#line 40 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                    data.ImageSource

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 23 "C:\2021-06-HP-D-drive\2021_07_Radzen_WorkRunning-CPD\Net5Wasm\client\Pages\Testmosso.razor"
                                  datalist0 = (Radzen.Blazor.RadzenDataList<Net5Wasm.Models.Net5Wasmconn.Category>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
