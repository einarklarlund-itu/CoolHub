#pragma checksum "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39b12edb9f5f7ca0d181878446055c283f7d5aa"
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
#line 1 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
using CoolHub.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
using CoolHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
using CoolHub.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class TopicFormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
                  Topic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
                                         CreateTopic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-4");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label for=\"name\">Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "id", "name");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
                                                                   Topic.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Topic.Name = __value, Topic.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Topic.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label for=\"notes\">Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "id", "notes");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
                                                                        Topic.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Topic.Description = __value, Topic.Description))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Topic.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.AddMarkupContent(31, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Einar\Documents\Projects\BDSA\CoolHub\CoolHub.Server\Components\Test Components\TopicFormComponent.razor"
       
    [CascadingParameter(Name = "CategoryViewModel")]
    CategoryViewModel CategoryViewModel { get; set; }

    private TopicCreateDTO Topic = new TopicCreateDTO();

    private void CreateTopic()
    {
        CategoryViewModel.CreateTopic(Topic);

        Topic = new TopicCreateDTO();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
