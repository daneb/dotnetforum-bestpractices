namespace DotnetBestPractices.PartOneCode.SectionOne.SampleTwo.OneSolution;

public interface ISwitchable
{
    public bool IsOn { get; set; }
    void TurnOn();
    void TurnOff();
}