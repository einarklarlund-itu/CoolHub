// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoFormComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoFormComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
    public partial class ToDoFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\elmel\ITU\BDSA2020\Project\CoolHub\Coolhub.Server\Components\Test Components\ToDoFormComponent.razor"
       
    [CascadingParameter(Name = "ViewModel")]
    IToDoViewModel ViewModel { get; set; }

    void SaveTodoItem()
    {
        ViewModel.SaveToDoItem(ViewModel.ToDoItem);
        ViewModel.ToDoItem = new ToDoItem();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
