using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchNamesTests
{
    [Test]
    public void Test_Match_ValidNames_ReturnsMatchedNames()
    {
        // Arrange
        string names = "Naomi Rivers, a prominent attorney in Sofia, stands out for her intellect and determination. Alongside her siblings Jessica and Benjamin, she navigates life's challenges with grace. With friends like Maya Patel and David Thompson, Naomi's vibrant personality shines through, bringing laughter and joy. In her journey, Naomi embodies resilience, empathy, and the timeless mantra of finding joy in life's unexpected moments, reflected in her name spelled backward: 'I moan.'";

        string expected = "Naomi Rivers Maya Patel David Thompson";

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Match_NoValidNames_ReturnsEmptyString()
    {
        // Arrange
        string names = "Naomi, a prominent attorney in Sofia, stands out for her intellect and determination. Alongside her siblings Jessica and Benjamin, she navigates life's challenges with grace. With friends like Maya  and David , Naomi's vibrant personality shines through, bringing laughter and joy. In her journey, Naomi embodies resilience, empathy, and the timeless mantra of finding joy in life's unexpected moments, reflected in her name spelled backward: 'I moan.'";

        string expected = string.Empty;

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string names = "";

        string expected = string.Empty;

        // Act
        string actual = MatchNames.Match(names);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
