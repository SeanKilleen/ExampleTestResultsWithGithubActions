namespace Project1.Tests;

public class EchoerTests
{
    [Test]
    public void EchoerReturnsString()
    {
        var sut = new Echoer();

        var theValue = "Hello!";
        var result = sut.Echo(theValue);

        Assert.That(result, Is.EqualTo(theValue));
    }

    [TestCase("ALLCAPS")]
    [TestCase("alllower")]
    [TestCase("MiXedCasE")]
    public void WorksWithAllCases(string testString)
    {
        var sut = new Echoer();

        var result = sut.Echo(testString);

        Assert.That(result, Is.Not.EqualTo(testString));
    }
}