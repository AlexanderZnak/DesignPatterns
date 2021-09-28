using System;
using Microsoft.Extensions.DependencyInjection;

namespace Builder
{
    public class Startup
    {
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ConsoleWrite>(ConsoleWrite.Instance);
            return services.BuildServiceProvider(); 
        }
        
    }
}