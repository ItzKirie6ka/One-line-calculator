namespace TestSolution.Extensions;

public static class ListExtensions
{
    public static void PrintList<T>(this List<T> list, string? message = null)
    {
        Console.Write(message ?? "");  
        foreach (var item in list)
        {
            Console.Write(item + " ");    
        }
        Console.Write('\n');
    }

    public static int CountOf<T>(this List<T> list, T[] search)
    {
        var count = 0;

        foreach (var t in list)
        {
            foreach (var s in search)
            {
                if (t!.Equals(s)) count++;
            }
        }
        
        return count;
    }

    public static bool Has<T>(this List<T> list, T search)
    {
        foreach (var t in list)
            if (t!.Equals(search)) return true;

        return false;
    }
    
    public static bool Has<T>(this List<T> list, T[] searchs)
    {
        foreach (var t in list)
            foreach (var s in searchs)
                if (t!.Equals(s)) return true;

        return false;
    }
}