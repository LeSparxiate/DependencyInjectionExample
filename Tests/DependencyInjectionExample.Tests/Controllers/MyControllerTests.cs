using DependencyInjectionExample.Controllers;
using DependencyInjectionExample.Library.Interfaces;
using NSubstitute;
using Xunit;

namespace DependencyInjectionExample.Tests.Controllers;

public class MyControllerTests
{
    private readonly IMyClass _myClass;

    private readonly MyController _subject;

    public MyControllerTests()
    {
        _myClass = Substitute.For<IMyClass>();

        _subject = new MyController(_myClass);
    }

    [Fact]
    public void Start_PerformsAction()
    {
        _subject.Start();
    }
}
