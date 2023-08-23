namespace DotnetBestPractices.PartOneCode.SectionOne.SampleTwo;

public class Switch
{
    private readonly LightBulb _bulb;

    public Switch()
    {
        _bulb = new LightBulb();
    }

    public void Toggle()
    {
        if (_bulb.IsOn)
            _bulb.TurnOff();
        else
            _bulb.TurnOn();
    }
}