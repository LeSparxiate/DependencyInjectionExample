using DependencyInjectionExample.Controllers;
using DependencyInjectionExample.Library.Implementations;
using DependencyInjectionExample.Library.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionExample;

public class DependencyInjections
{
    public static IServiceCollection PerformInjections()
    {
        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables();
        IConfiguration config = builder.Build();

        var services = new ServiceCollection().AddSingleton(_ => config)
            .AddScoped<MyController>()
            .AddScoped<IMyClass, MyClass>();

        return services;
    }
}
