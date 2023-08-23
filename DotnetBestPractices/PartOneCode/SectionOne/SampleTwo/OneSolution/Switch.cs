namespace DotnetBestPractices.Code.SampleTwo.OneSolution;

public class Switch
{
    private readonly ISwitchable _device;

    public Switch(ISwitchable device)
    {
        _device = device;
    }

    public void Toggle()
    {
        if (_device.IsOn)
            _device.TurnOff();
        else
            _device.TurnOn();
    }
}