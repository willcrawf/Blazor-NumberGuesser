using SyncfusionBlazorApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Blazored.LocalStorage;

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NHaF5cXmVCf1JpR2BGfV5yd0VHYlZRQXxbQU0DNHVRdkdgWH9cdHVRRmhYUkJ+V0Y=");


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredLocalStorage();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();	

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
