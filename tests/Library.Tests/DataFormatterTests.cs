namespace Library.Tests;
using TestDateFormat;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void Control()
    {
        string expected = "1997-11-10";
        string dateCtrl = "10/11/1997";
        string date = DateFormatter.ChangeFormat(dateCtrl);
        Assert.AreEqual(date, expected);
    }
    [Test]
    public void TestValidChar()
    {
        string expected = "Error, ingrese el formato correcto.";
        string dateCtrl = "10/b1/1a97";
        string date = DateFormatter.ChangeFormat(dateCtrl);
        Assert.AreEqual(date, expected);
    }
}