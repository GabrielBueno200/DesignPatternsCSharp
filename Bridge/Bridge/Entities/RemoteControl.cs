using Bridge.Interfaces;

namespace Bridge.Entities;

public class RemoteControl
{
    protected readonly IDevice _device;

    public RemoteControl(IDevice device)
    {
        _device = device;
    }

    public void TogglePower()
    {
        _device.Power = !_device.Power;
        Console.WriteLine($"{_device.Name} power status: {_device.Power}");
    }
}
