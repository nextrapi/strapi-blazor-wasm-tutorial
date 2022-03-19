using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("Strapi", client =>
    client.BaseAddress = new Uri("http://localhost:1337/api/"));
builder.Services.AddSingleton<AppServices.AuthApi>();
builder.Services.AddSingleton<AppServices.TasksApi>();
await builder.Build().RunAsync();
