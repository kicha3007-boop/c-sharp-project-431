namespace App;

public static class Utils
{
    public static int GetRandomNumber(int min, int max) => Random.Shared.Next(min, max + 1);

    public static string ToYesNo(bool value) => value ? "yes" : "no";
}
