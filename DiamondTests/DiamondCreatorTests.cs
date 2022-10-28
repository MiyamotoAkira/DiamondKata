using System.Collections.Generic;
using DiamondLogic;
using FluentAssertions;
using Xunit;

namespace DiamondTests;

public class DiamondTest
{
    [Fact]
    public void CreateDiamondTest()
    {
        var diamondCreator = new DiamondCreator();

        var result = diamondCreator.generate("C");

        var expected = new List<string> { "A", "B B", "C  C", "B B", "A" };

        result.Should().BeSameAs(expected);

    }

    public static IEnumerable<object[]> GetCharacterRange ()
    {
        yield return new object[] { "A", new List<string> { "A" } };
    }

    [Theory]
    [MemberData(nameof(GetCharacterRange))]
    public void CreateRangeTest(string character, List<string> expected)
    {
        var diamondCreator = new DiamondCreator();

        var actual = diamondCreator.CreateRange(character);

        actual.Should().BeEquivalentTo(expected);
    }
}
