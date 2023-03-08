namespace Bridge.Interfaces;

public interface IDevice
{
    public string Name { get; }
    public bool Power { get; set; }
    public int Volume { get; set; }
}
