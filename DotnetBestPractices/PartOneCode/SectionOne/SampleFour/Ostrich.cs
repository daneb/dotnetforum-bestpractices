namespace DotnetBestPractices.Code.SampleFour;

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new InvalidOperationException("Ostriches can't fly.");
    }
}