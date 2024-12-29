using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace KoinLabClient
{
    public class Program
    {
        private const string UriString = "https://koinlabserver.azurewebsites.net";

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            // Update the base address to the API URL
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(UriString) });

            await builder.Build().RunAsync();
        }
    }
}