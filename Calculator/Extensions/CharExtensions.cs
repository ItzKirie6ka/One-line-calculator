namespace TestSolution.Extensions;

public static class CharExtensions
{
    public static bool Compare<T>(this char character, T[] characters)
    {
        foreach (var c in characters)
        {
            if (character.Equals(c)) return true;
        }

        return false;
    }
}