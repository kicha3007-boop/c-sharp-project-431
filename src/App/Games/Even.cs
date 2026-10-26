namespace App.Games;

public static class Even
{
    private const string Description = "Answer 'yes' if the number is even, otherwise answer 'no'.";
    private const int MinNumber = 1;
    private const int MaxNumber = 100;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static bool IsEven(int number) => number % 2 == 0;

    private static (string Question, string Answer) GenerateRound()
    {
        var number = Utils.GetRandomNumber(MinNumber, MaxNumber);
        return (number.ToString(), Utils.ToYesNo(IsEven(number)));
    }
}
