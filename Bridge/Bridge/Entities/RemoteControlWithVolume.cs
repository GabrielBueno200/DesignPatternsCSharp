using Bridge.Interfaces;

namespace Bridge.Entities;

public class RemoteControlWithVolume : RemoteControl
{
    public RemoteControlWithVolume(IDevice device) : base(device) { }

    public void VolumeUp()
    {
        int oldVolume = _device.Volume;
        _device.Volume = _device.Volume + 10;
        Console.WriteLine(
            $"{_device.Name} tinha o volume {oldVolume} agora tem {_device.Volume}"
        );
    }

    public void VolumeDown()
    {
        int oldVolume = _device.Volume;
        _device.Volume = _device.Volume - 10;
        Console.WriteLine(
            $"{_device.Name} tinha o volume {oldVolume} agora tem {_device.Volume}"
        );
    }
}
