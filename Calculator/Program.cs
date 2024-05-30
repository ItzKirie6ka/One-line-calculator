using TestSolution.Calculation;

namespace TestSolution;

public static class Program
{
    private static void Main()
    {
        IProblemSolver problemSolver = new ProblemSolver();
        IInputHandler inputHandler = new InputHandler();
        
        while (true)
        {
            Console.Write("Problem: ");
            
            Console.WriteLine("Solution: " + problemSolver.PrioritySetter(inputHandler.HandleProblem() ?? []));
            inputHandler.ClearCurrentList();
        }
    }
}