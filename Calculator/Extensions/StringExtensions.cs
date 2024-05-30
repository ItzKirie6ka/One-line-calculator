namespace TestSolution.Extensions;

public static class StringExtensions
{
    public static string? GetLine(string message = "")
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    public static bool Has<T>(this string str, T search)
    {
        foreach (var t in str)
            if (t!.Equals(search)) return true;

        return false;
    }
    
    public static bool Has<T>(this string str, T[] search)
    {
        foreach (var s in search)
            if (str.Equals(s)) return true;
        
        return false;
    }
}