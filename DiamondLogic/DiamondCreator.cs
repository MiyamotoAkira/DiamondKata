namespace DiamondLogic;

public class DiamondCreator
{
    public IEnumerable<string> generate(string character)
    {
        var range = CreateRange(character);
        return range.Select(Expand);
    }

    public List<string> CreateRange(string character)
    {
        return new List<string> { character };
    }

    private string Expand(string arg1, int index)
    {
        throw new NotImplementedException();
    }
}
