namespace App.Games;

public static class Calc
{
    private const string Description = "What is the result of the expression?";
    private const int MinNumber = 1;
    private const int MaxNumber = 25;
    private static readonly char[] Operators = ['+', '-', '*'];

    public static void Run() => Engine.Run(Description, GenerateRound);

    private static int Calculate(int left, char operation, int right) =>
        operation switch
        {
            '+' => left + right,
            '-' => left - right,
            '*' => left * right,
            _ => throw new ArgumentException($"Unknown operator: {operation}"),
        };

    private static (string Question, string Answer) GenerateRound()
    {
        var left = Utils.GetRandomNumber(MinNumber, MaxNumber);
        var right = Utils.GetRandomNumber(MinNumber, MaxNumber);
        var operation = Operators[Utils.GetRandomNumber(0, Operators.Length - 1)];
        var question = $"{left} {operation} {right}";
        return (question, Calculate(left, operation, right).ToString());
    }
}
