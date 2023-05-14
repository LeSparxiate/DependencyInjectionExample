using DependencyInjectionExample.Library.Implementations;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace DependencyInjectionExample.Library.Tests.Implementations;

public class MyClassTests
{
    private const string Parameter = "I like sushis!";

    private readonly IConfiguration _configuration;

    private readonly MyClass _subject;

    public MyClassTests()
    {
        var builder = new ConfigurationBuilder();
        builder.AddInMemoryCollection(new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("MyParameter", Parameter)
        });
        _configuration = builder.Build();

        _subject = new MyClass(_configuration);
    }

    [Fact]
    public void HelloWorld_ReturnsExpectedConfigParameter()
    {
        var result = _subject.HelloWorld();

        result.Should().Be(Parameter);
    }
}