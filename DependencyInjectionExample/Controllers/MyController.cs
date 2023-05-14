using DependencyInjectionExample.Library.Interfaces;

namespace DependencyInjectionExample.Controllers;

public class MyController
{
    private readonly IMyClass _myClass;

    public MyController(IMyClass myClass)
    {
        _myClass = myClass;
    }

    public void Start()
    {
        _myClass.HelloWorld();
    }
}
