using Dnj.Colab.Samples.MvvmWebsocketServer.Wasm;
using Dnj.Colab.Samples.MvvmWebSocketServer.Identity.RCL;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<WasmApp>("#wasmapp");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri($"{builder.HostEnvironment.BaseAddress}/wasm/") });
builder.Services.AddScoped<LoginViewModel>();

await builder.Build().RunAsync();
