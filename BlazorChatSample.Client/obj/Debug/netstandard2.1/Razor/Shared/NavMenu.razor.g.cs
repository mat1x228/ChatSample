#pragma checksum "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c516c915a7024ad8d705f4b71865db3172c896f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorChatSample.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using BlazorChatSample.Client;

#line default
#line hidden
#line 7 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\_Imports.razor"
using BlazorChatSample.Client.Shared;

#line default
#line hidden
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorChatSample</a>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor"
                                              ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#line 8 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor"
             collapseNavMenu ? "collapse" : null

#line default
#line hidden
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor"
                                                             ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 11 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor"
                                                    NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 18 "C:\Users\sshab\Desktop\Projects\BlazorChatSample\BlazorChatSample.Client\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
