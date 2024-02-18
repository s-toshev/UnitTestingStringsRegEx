using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022";
        // Act
        string actual = MatchDates.Match(input);
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "Invalid date format";

        // Act
        string expected = string.Empty;
        string actual = MatchDates.Match(input);

        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "20/Dec/1992, 15-Jul-2005, 20-Feb-2002";
        // Act
        string actual = MatchDates.Match(input);
        string expected = "Day: 20, Month: Dec, Year: 1992";

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string expected = string.Empty;
        string actual = MatchDates.Match(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {

        //Act&Assert
        string input = null;
        var exceptionMessage = Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
        string actualExceptionMessage = "Input cannot be null!";
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
        Assert.AreEqual(exceptionMessage.Message, actualExceptionMessage);

    }
}
