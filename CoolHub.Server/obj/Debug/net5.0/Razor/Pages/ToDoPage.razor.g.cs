#pragma checksum "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af85e09c34f91f1e8cbf22d060f28d35418482b7"
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
#line 1 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using CoolHub.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\_Imports.razor"
using CoolHub.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todopage")]
    public partial class ToDoPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.CoolHub.ToDoPage.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 13 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor"
                       ViewModel

#line default
#line hidden
#nullable disable
            , 2, "ViewModel", 3, (__builder2) => {
                __builder2.OpenComponent<CoolHub.ToDoListComponent>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<CoolHub.ToDoFormComponent>(6);
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "h1");
            __builder.AddContent(9, "Items to do: ");
            __builder.AddContent(10, 
#nullable restore
#line 18 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor"
                  ViewModel.ItemsToDo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Pages\ToDoPage.razor"
 
    // update the entire view, the page and its components on PropertyChanged
    protected override async Task OnInitializedAsync()
    {
        ViewModel.PropertyChanged += async (sender, e) => { 
            await InvokeAsync(() =>
            {
                StateHasChanged();
            });
        };
        await base.OnInitializedAsync();
    }

    async void OnPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
    {
        await InvokeAsync(() =>
        {
            StateHasChanged();
        });
    }

    public void Dispose()
    {
        ViewModel.PropertyChanged -= OnPropertyChangedHandler;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToDoViewModel ViewModel { get; set; }
    }
}
namespace __Blazor.CoolHub.ToDoPage
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
