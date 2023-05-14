using DependencyInjectionExample.Controllers;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DependencyInjectionExample.Tests;

public class DependencyInjectionsTests
{
    [Fact]
    public void PerformInjections_ReturnsExpectedController()
    {
        var services = DependencyInjections.PerformInjections();

        var serviceProvider = services.BuildServiceProvider();
        var controller = serviceProvider.GetService<MyController>();

        controller.Should().NotBeNull();
    }
}
