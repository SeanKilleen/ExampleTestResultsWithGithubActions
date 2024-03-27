namespace Project2.Tests;

public class ReverseEchoerTests
{
    [Test]
    public void EchoerReturnsString()
    {
        var sut = new ReverseEchoer();

        var theValue = "Hello!";
        var result = sut.Echo(theValue);

        Assert.That(result, Is.EqualTo("!olleH"));
    }
}