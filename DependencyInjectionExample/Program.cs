using System.Diagnostics.CodeAnalysis;
using DependencyInjectionExample.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionExample;

[ExcludeFromCodeCoverage]
internal class Program
{
    public static void Main()
    {
        var serviceProvider = CreateServiceProvider();

        StartProgram(serviceProvider);
    }

    private static void StartProgram(ServiceProvider serviceProvider)
    {
        var controller = serviceProvider.GetService<MyController>();
        controller.Start();
    }

    private static ServiceProvider CreateServiceProvider()
    {
        return DependencyInjections.PerformInjections().BuildServiceProvider();
    }
}
