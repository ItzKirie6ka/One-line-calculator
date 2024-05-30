namespace TestSolution.Calculation;

public interface IInputHandler
{
    public List<string> Problem { get; }

    public List<string>? HandleProblem();
    public void ClearCurrentList();
}