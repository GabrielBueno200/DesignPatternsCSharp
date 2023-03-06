using Prototype.Interfaces;

namespace Prototype.Extensions;

public static class DeepCopyExtensions
{
    public static T DeepCopy<T>(this IDeepCopyable<T> item)
      where T : new()
    {
        return item.DeepCopy();
    }
}
