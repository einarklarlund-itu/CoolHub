#pragma checksum "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540f72ed854343412020090494d23ddf09af756a"
// <auto-generated/>
#pragma warning disable 1591
namespace CoolHub
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using CoolHub.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\_Imports.razor"
using CoolHub.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/all-categories")]
    public partial class AllCategories : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "Tutorials-pagecontent");
            __builder.AddMarkupContent(2, "<h1 class=\"Tutorials-header\">Choose what to learn</h1>\r\n    <br>\r\n\r\n    ");
            __Blazor.CoolHub.AllCategories.TypeInference.CreateCascadingValue_0(__builder, 3, 4, 
#nullable restore
#line 20 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor"
                           AllCategoriesViewModel

#line default
#line hidden
#nullable disable
            , 5, "AllCategoriesViewModel", 6, (__builder2) => {
                __builder2.OpenComponent<CoolHub.CategoryListComponent>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<CoolHub.CategoryFormComponent>(9);
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Pages\AllCategories.razor"
 
    // update the entire view, the page and its components on PropertyChanged
    protected override async Task OnInitializedAsync()
    {
        AllCategoriesViewModel.PropertyChanged += async (sender, e) => { 
            await InvokeAsync(() =>
            {
                StateHasChanged();
            });
        };
        await base.OnInitializedAsync();
    }

    private async void OnPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
    {
        await InvokeAsync(() =>
        {
            StateHasChanged();
        });
    }

    public void Dispose()
    {
        AllCategoriesViewModel.PropertyChanged -= OnPropertyChangedHandler;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AllCategoriesViewModel AllCategoriesViewModel { get; set; }
    }
}
namespace __Blazor.CoolHub.AllCategories
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
