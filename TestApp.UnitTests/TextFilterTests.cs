using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { "mixing", "attack", "goat", "milk" };

        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Act

        string actual= TextFilter.Filter(bannedWords, text);

        string expected = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = { "Naomi's", "I moan", "quirks", "banter" };

        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Act

        string actual = TextFilter.Filter(bannedWords, text);

        string expected = "Unraveling the curious symmetry in ******* name, wherein '******' emerges when read backwards, injected a humorous undertone into our ******, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical ****** hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();   

        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Act

        string actual = TextFilter.Filter(bannedWords, text);

        string expected = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { "Naomi's name", "I moan", "delightful reminder" };

        string text = "Unraveling the curious symmetry in Naomi's name, wherein 'I moan' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a delightful reminder of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Act

        string actual = TextFilter.Filter(bannedWords, text);

        string expected = "Unraveling the curious symmetry in ************, wherein '******' emerges when read backwards, injected a humorous undertone into our banter, prompting a cascade of laughter and jests among us. It served as a ******************* of the whimsical quirks hidden within the mundane fabric of everyday life, igniting a sense of playful wonder and camaraderie within our circle.";
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
