using System.Collections.Generic;
using DiamondLogic;
using FluentAssertions;
using Xunit;

namespace DiamondTests;

public class DiamondTest
{
    [Fact]
    public void CreateDiamondTestWithC()
    {
        var diamondCreator = new DiamondCreator();

        var result = diamondCreator.generate("C");

        var expected = new List<string> { "  A  ",
                                          " B B ",
                                          "C   C",
                                          " B B ",
                                          "  A  " };

        result.Should().BeEquivalentTo(expected);

    }

    [Fact]
    public void CreateDiamondTestWithF()
    {
        var diamondCreator = new DiamondCreator();

        var result = diamondCreator.generate("F");

        var expected = new List<string> { "     A     ",
                                          "    B B    ",
                                          "   C   C   ",
                                          "  D     D  ",
                                          " E       E ",
                                          "F         F",
                                          " E       E ",
                                          "  D     D  ",
                                          "   C   C   ",
                                          "    B B    ",
                                          "     A     " };

        result.Should().BeEquivalentTo(expected);

    }

    public static IEnumerable<object[]> GetCharacterRange()
    {
        yield return new object[] { "A", new List<string> { "A" } };
        yield return new object[] { "B", new List<string> { "A", "B", "A" } };
        yield return new object[] { "Z", new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Y", "X", "W", "V", "U", "T", "S", "R", "Q", "P", "O", "N", "M", "L", "K", "J", "I", "H", "G", "F", "E", "D", "C", "B", "A" } };
    }

    [Theory]
    [MemberData(nameof(GetCharacterRange))]
    public void CreateRangeTest(string character, List<string> expected)
    {
        var diamondCreator = new DiamondCreator();

        var actual = diamondCreator.CreateRange(character);

        actual.Should().BeEquivalentTo(expected);
    }

    [Theory]
    [InlineData(1, " ")]
    [InlineData(5, "     ")]
    public void CreateLineTest(int lineLength, string expected)
    {
        var diamondCreator = new DiamondCreator();

        var actual = diamondCreator.CreateLine(lineLength);

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData("B", "   ", "B B")]
    [InlineData("A", "     ", "  A  ")]
    [InlineData("F", "           ", "F         F")]
    public void MergeInLineTest(string character, string line, string expected)
    {
        var diamondCreator = new DiamondCreator();

        var actual = diamondCreator.MergeInLine(character, line);

        actual.Should().Be(expected);
    }
}
