namespace App.Games;

public static class Prime
{
    private const string Description =
        "Answer 'yes' if given number is prime. Otherwise answer 'no'.";
    private const int MinNumber = 1;
    private const int MaxNumber = 100;
    private const int SmallestPrime = 2;

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static bool IsPrime(int number)
    {
        if (number < SmallestPrime)
        {
            return false;
        }

        for (var divisor = SmallestPrime; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    private static (string Question, string Answer) GenerateRound()
    {
        var number = Utils.GetRandomNumber(MinNumber, MaxNumber);
        return (number.ToString(), Utils.ToYesNo(IsPrime(number)));
    }
}
