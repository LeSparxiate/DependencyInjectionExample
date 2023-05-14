using DependencyInjectionExample.Library.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DependencyInjectionExample.Library.Implementations;

public class MyClass : IMyClass
{
    private readonly IConfiguration _configuration;

    public MyClass(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string HelloWorld()
    {
        var myParameterValue = _configuration.GetSection("MyParameter").Value;

        Console.WriteLine($"Hello World! {myParameterValue}");

        return myParameterValue;
    }
}