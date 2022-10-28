namespace DiamondLogic;

public class DiamondCreator
{
    public IEnumerable<string> generate(string character)
    {
        var range = CreateRange(character);
        return range.Select(Expand);
    }

    public IEnumerable<string> CreateRange(string character)
    {
        return Enumerable.Range('A', character[0] - 'A' + 1)
                         .Select(c => ((char)c).ToString())
                         .Concat(Enumerable.Range('A', character[0] - 'A')
                                           .Select(c => ((char)c).ToString())
                                           .OrderByDescending(c => c));
    }

    private string Expand(string arg1, int index)
    {
        throw new NotImplementedException();
    }
}
