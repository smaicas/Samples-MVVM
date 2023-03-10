using System.Reflection;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Dnj.Colab.Samples.MvvmWebsocketServer.Server;
public partial class App : ComponentBase
{
    private readonly List<Assembly> _lazyLoadedAssemblies = new();

    private async Task OnNavigateAsync(NavigationContext args)
    {
        try
        {
            _lazyLoadedAssemblies.Clear();
            //_lazyLoadedAssemblies.Add(Assembly.Load("Dnj.Colab.Samples.MvvmWebsocketServer.Wasm"));
            _lazyLoadedAssemblies.Add(Assembly.Load("Dnj.Colab.Samples.MvvmWebsocketServer.RCL"));
            _lazyLoadedAssemblies.Add(Assembly.Load("Dnj.Colab.Samples.MvvmWebSocketServer.Identity.RCL"));
        }
        catch (Exception ex)
        {
            //Log.Error("Error: Unable to load additional assemblies", ex.Message);
        }
    }
}