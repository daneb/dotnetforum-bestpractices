namespace DotnetBestPractices.Code.SampleFour.PossibleSolution;

public class Ostrich : IFlyable
{
    public void Fly()
    {
        throw new InvalidOperationException("Ostriches can't fly."); 
    }
}