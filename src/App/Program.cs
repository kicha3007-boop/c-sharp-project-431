using App;
using App.Games;

Console.WriteLine("Please enter the game number and press Enter.");
Console.WriteLine("1 - Greet");
Console.WriteLine("2 - Even");
Console.WriteLine("3 - Calc");
Console.WriteLine("4 - GCD");
Console.WriteLine("5 - Progression");
Console.WriteLine("6 - Prime");
Console.WriteLine("0 - Exit");
Console.Write("Your choice: ");

var choice = (Console.ReadLine() ?? string.Empty).Trim();
Console.WriteLine();

switch (choice)
{
    case "1":
        Cli.Greet();
        break;
    case "2":
        Even.Run();
        break;
    case "3":
        Calc.Run();
        break;
    case "4":
        Gcd.Run();
        break;
    case "5":
        Progression.Run();
        break;
    case "6":
        Prime.Run();
        break;
    case "0":
        break;
    default:
        Console.WriteLine($"Unknown game number: {choice}");
        break;
}
