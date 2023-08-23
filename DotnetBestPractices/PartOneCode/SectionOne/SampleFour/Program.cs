using DotnetBestPractices.PartOneCode.SectionOne.SampleFour.PossibleSolution;

namespace DotnetBestPractices.PartOneCode.SectionOne.SampleFour;

partial class Program
{
    static void Main(string[] args)
    {
        IBird bird = new PossibleSolution.Bird();
        IBird ostrich = new PossibleSolution.Ostrich();

        PerformFlight(bird);
        PerformFlight(ostrich);
    }

    static void PerformFlight(IBird bird)
    {
        bird.Fly();
    }
}