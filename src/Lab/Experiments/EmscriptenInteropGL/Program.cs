using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EmscriptenInteropGL;
using Microsoft.JSInterop;
using Silk.NET.Core.Loader;

SearchPathContainer.Platform = UnderlyingPlatform.Browser;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient(sp => (IJSInProcessRuntime) sp.GetRequiredService<IJSRuntime>());

await builder.Build().RunAsync();