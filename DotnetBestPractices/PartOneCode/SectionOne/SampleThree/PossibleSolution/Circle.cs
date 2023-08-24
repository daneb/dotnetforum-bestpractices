namespace DotnetBestPractices.PartOneCode.SectionOne.SampleThree.PossibleSolution;

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}