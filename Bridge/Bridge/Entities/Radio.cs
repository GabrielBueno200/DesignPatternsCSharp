using Bridge.Interfaces;

namespace Bridge.Entities;

public class Radio : IDevice
{
    private int volume = 10;
    private bool power = false;

    public string Name => "Radio";

    public int Volume
    {
        get => volume;
        set
        {
            if (value < 0 || value > 100) return;
            volume = value;
        }
    }

    public bool Power
    {
        get => power;
        set => power = value;
    }
}
