using Xunit;

public class testclass
{
    [Fact]
    public void PassingAddTest()
    {
        Assert.Equal(4, Program.Add(2,2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.NotEqual(5, Program.Add(2,2));
    }
    

}