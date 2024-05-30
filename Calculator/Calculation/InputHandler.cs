using TestSolution.Extensions;

namespace TestSolution.Calculation;

public class InputHandler : IInputHandler
{
    public List<string> Problem { get; } = [];


    public List<string> HandleProblem()
    {
        var problem = StringExtensions.GetLine();
        problem += " ";

        var number = string.Empty;
        
        foreach (var t in problem)
        {
            if (!char.IsWhiteSpace(t))
                number += t;
            else if (char.IsWhiteSpace(t) && !number.Equals(string.Empty))
            {
                Problem.Add(number);
                number = string.Empty;
            }
        }
        
        return Problem;
    }

    public void ClearCurrentList()
    {
        Problem.Clear();
    }
}