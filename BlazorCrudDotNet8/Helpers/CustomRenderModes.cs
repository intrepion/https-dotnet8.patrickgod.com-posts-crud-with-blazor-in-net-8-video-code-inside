using Microsoft.AspNetCore.Components.Web;

namespace BlazorCrudDotNet8.Helpers;

public static class CustomRenderModes
{
    public static readonly InteractiveAutoRenderMode InteractiveAutoRenderModeNoPreRender
        = new(prerender: false);
    public static readonly InteractiveServerRenderMode InteractiveServerRenderModeNoPreRender
        = new(prerender: false);
    public static readonly InteractiveWebAssemblyRenderMode InteractiveWebAssemblyRenderModeNoPreRender
        = new(prerender: false);
}
