using Bridge.Entities;


Action<RemoteControl> clientCode = abstraction =>
{
    abstraction.TogglePower(); // true

    if (abstraction is not RemoteControlWithVolume) return;
    ((RemoteControlWithVolume)abstraction).VolumeUp(); // 20
    ((RemoteControlWithVolume)abstraction).VolumeUp(); // 30
    ((RemoteControlWithVolume)abstraction).VolumeDown(); // 20
};

var tv = new Tv();
var radio = new Radio();

var radioRemoteControl = new RemoteControl(radio);
clientCode(radioRemoteControl);

var tvRemoteControl = new RemoteControlWithVolume(tv);
clientCode(tvRemoteControl);