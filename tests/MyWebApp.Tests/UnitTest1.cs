namespace MyWebApp.Tests;

public class GreetingServiceTests
{
    [Fact]
    public void GetGreeting_ReturnsExpectedMessage()
    {
        var result = GreetingService.GetGreeting("World");

        Assert.Equal("Hello World!", result);
    }
}
