using NUnit.Framework;

using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);
        List<string> expected = new List<string>();
        // Assert
        Assert.AreEqual(expected, actual);

    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);
        List<string> expected = new List<string>();
        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle. Then she opened the URL https://www.Imoan.com";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);
        List<string> expected = new List<string> { "https://www.Imoan.com" };
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle. Then she opened the URL 'https://www.Imoan.com' and after that 'http://google.gr' and https://www.jairo.net and http://comeWithMe.au";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);
        List<string> expected = new List<string> { "https://www.Imoan.com", "http://google.gr", "https://www.jairo.net", "http://comeWithMe.au" };
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle. Then she opened the URL 'https://www.Imoan.com' and after that 'http://google.gr' ";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(text);
        List<string> expected = new List<string> { "https://www.Imoan.com", "http://google.gr" };
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
