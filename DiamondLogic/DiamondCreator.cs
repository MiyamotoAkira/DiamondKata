namespace DiamondLogic;

public class DiamondCreator
{
    public IEnumerable<string> generate(string character)
    {
        var range = CreateRange(character);
        return range.Select(Expand);
    }

    private List<string> CreateRange(string character)
    {
        throw new NotImplementedException();
    }

    private string Expand(string arg1, int index)
    {
        throw new NotImplementedException();
    }
}
