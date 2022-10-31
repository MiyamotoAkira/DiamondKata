using System.Text;

namespace DiamondLogic;

public class DiamondCreator
{
    public IEnumerable<string> generate(string character)
    {
        var range = CreateRange(character);
        var line = CreateLine(range.Count());
        return range.Select(c => MergeInLine(c, line));
    }

    public IEnumerable<string> CreateRange(string character)
    {
        var firstHalf = Enumerable.Range('A', character[0] - 'A' + 1)
            .Select(c => ((char)c).ToString());
        var secondHalf = Enumerable.Range('A', character[0] - 'A')
                                           .Select(c => ((char)c).ToString())
            .OrderByDescending(c => c);
        return firstHalf.Concat(secondHalf);
    }

    public string CreateLine(int lineLength)
    {
        return string.Concat(Enumerable.Repeat(" ", lineLength));
    }

    public string MergeInLine(string character, string line)
    {
        var builder = new StringBuilder(line);
        var middleOfLine = line.Length / 2;
        var position = character[0] - 'A';
        builder[middleOfLine - position] = character[0];
        builder[middleOfLine + position] = character[0];
        return builder.ToString();
    }
}
