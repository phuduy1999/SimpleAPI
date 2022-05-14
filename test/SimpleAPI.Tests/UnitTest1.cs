using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get(2);
        Assert.Equal("Les Jackson", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}