namespace App;

public static class Cli
{
    public static string Greet()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.Write("May I have your name? ");
        var name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Hello, {name}!");
        return name;
    }
}
