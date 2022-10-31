using DiamondLogic;

var diamondCreator = new DiamondCreator();

var result = diamondCreator.generate(args[0]);

foreach (var line in result)
    Console.WriteLine(line);
