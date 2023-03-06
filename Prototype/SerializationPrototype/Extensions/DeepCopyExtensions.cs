using System.Text.Json;

namespace Prototype.Extensions;

public static class DeepCopyExtensions
{
    public static T DeepCopy<T>(this T self)
      where T : new()
    {
        var serializedCopy = JsonSerializer.Serialize(self);
        var copy = JsonSerializer.Deserialize<T>(serializedCopy);
        return copy!;
    }
}
