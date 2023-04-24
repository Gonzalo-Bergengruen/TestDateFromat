using TestDateFormat;

namespace Library.Tests;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatoCorrecto()
    {
        string input = "24/04/2023";
        string expected = "2023-04-24";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FormatoIncorrecto()
    {
        string input = "24-04-2023";
        string expected = "Error: formato incorrecto.";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FormatoVacio()
    {
        string input = "";
        string expected = "Error: fecha vacía.";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FormatoNulo()
    {
        string input = null;
        string expected = "Error: fecha vacía.";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void FechaVálida()
    {
        string input = "89/65/-1";
        string expected = "Error: fecha invalida.";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, actual);
    }
}