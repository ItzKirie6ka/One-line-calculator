using TestSolution.Extensions;

namespace TestSolution.Calculation;

public class ProblemSolver : IProblemSolver
{
    private static string[] Operators { get; } = ["+", "-", "*", "/"];
    private static string[] PriorityOperators { get; } = ["*", "/"];
    
    
    private string Solve(List<string> problem)
    {
        var result = "";

        const int step = 2;
        
        var iterations = problem.CountOf(Operators) * step;
        
        for (var i = 0; i < iterations; i += step)
        {
            result = Operations(problem[i], problem[i + 1], problem[i + 2]).ToString();

            problem[i + 2] = result;
        }
        
        return result;
    }

    public string PrioritySetter(List<string> problem)
    {
        var containsPriorityOperations = problem.CountOf(PriorityOperators) > 0;
        
        if (!containsPriorityOperations || problem.Count == 3) return Solve(problem);

        for (var index = 0; index < problem.Count; index++)
        {
            
            if (!problem[index].Has(PriorityOperators)) continue;
            
            List<string> p = [problem[index - 1], problem[index], problem[index + 1]];
            
            problem.Insert(index - 1, Solve(p));
            problem.RemoveRange(index, 3);
            
            var result =  PrioritySetter(problem);
            
            return result;
        }

        return Solve(problem);
    }
    
    private long Operations(string a, string op, string b)
    {
        var firstNumber = int.Parse(a);
        var secondNumber = int.Parse(b);

        return op switch
        {
            "+" => firstNumber + secondNumber,
            "-" => firstNumber - secondNumber,
            "*" => firstNumber * secondNumber,
            "/" => firstNumber / secondNumber,
            _ => -1
        };
    }
}