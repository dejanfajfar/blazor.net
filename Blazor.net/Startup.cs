using Blazor.net.Services;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.net
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IBinaryFormatterService>(new BinaryFormatterService());
            serviceCollection.AddSingleton<IToDoService>(new ToDoService());
        }

        public void Configure(IBlazorApplicationBuilder blazorApplicationBuilder)
        {
            blazorApplicationBuilder.AddComponent<MyApp>("myApp");
        }
    }
}
