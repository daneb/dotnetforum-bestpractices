namespace DotnetBestPractices.PartOneCode.SectionOne.SampleThree.PossibleSolution;

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}