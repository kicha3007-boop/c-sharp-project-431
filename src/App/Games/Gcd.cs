namespace App.Games;

public static class Gcd
{
    private const string Description = "Find the greatest common divisor of given numbers.";
    private const int MinNumber = 1;
    private const int MaxNumber = 100;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static int FindGcd(int first, int second) =>
        second == 0 ? first : FindGcd(second, first % second);

    private static (string Question, string Answer) GenerateRound()
    {
        var first = Utils.GetRandomNumber(MinNumber, MaxNumber);
        var second = Utils.GetRandomNumber(MinNumber, MaxNumber);
        return ($"{first} {second}", FindGcd(first, second).ToString());
    }
}
