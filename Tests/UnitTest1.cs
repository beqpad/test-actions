using Xunit;
using test_actions;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var m = new TestModel();

        var s = m.GetValue();

        // throws assert
        Assert.Equal("abcde", s);
    }
}