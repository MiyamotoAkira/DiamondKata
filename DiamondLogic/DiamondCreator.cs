namespace DiamondLogic;

public class DiamondCreator
{
    public IEnumerable<string> generate(string character)
    {
        var range = CreateRange(character);
        return range.Select(Expand).Select(c => Wrap(c, character));
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

    public string Expand(string character)
    {

        var spaces = string.Concat(Enumerable.Repeat(" ", character[0] - 'A'));

        if (spaces == "")
        {
            return $"{character}";
        }

        return $"{character}{spaces}{character}";
    }

    public string Wrap(string character, string requestedCharacter)
    {
        var spaces = string.Concat(Enumerable.Repeat(" ", requestedCharacter[0] - character[0]));

        
        return $"{spaces}{character}{spaces}";
    }
}
