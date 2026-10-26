namespace App.Games;

public static class Progression
{
    private const string Description = "What number is missing in the progression?";
    private const string HiddenMark = "..";
    private const int MinLength = 5;
    private const int MaxLength = 10;
    private const int MinStart = 1;
    private const int MaxStart = 20;
    private const int MinStep = 1;
    private const int MaxStep = 10;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static int[] BuildProgression(int start, int step, int length)
    {
        var progression = new int[length];
        for (var index = 0; index < length; index++)
        {
            progression[index] = start + index * step;
        }

        return progression;
    }

    private static (string Question, string Answer) GenerateRound()
    {
        var length = Utils.GetRandomNumber(MinLength, MaxLength);
        var start = Utils.GetRandomNumber(MinStart, MaxStart);
        var step = Utils.GetRandomNumber(MinStep, MaxStep);
        var progression = BuildProgression(start, step, length);

        var hiddenIndex = Utils.GetRandomNumber(0, length - 1);
        var answer = progression[hiddenIndex].ToString();
        var items = progression.Select(item => item.ToString()).ToArray();
        items[hiddenIndex] = HiddenMark;

        return (string.Join(" ", items), answer);
    }
}
