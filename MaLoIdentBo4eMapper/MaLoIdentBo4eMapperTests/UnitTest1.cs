using FluentAssertions;
using MaLoIdentBo4eMapper;

namespace MaLoIdentBo4eMapperTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var myInstance = new MyClass();
        var actual = myInstance.DoStuff();
        actual.Should().Be("stuff");
    }
}
