using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KestrelLocalServer
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; private set; }

        public Startup()
        {
            Configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            var serverAddressesFeature = app.ServerFeatures.Get<IServerAddressesFeature>();

            app.UseMvcWithDefaultRoute();
        }
    }
}
