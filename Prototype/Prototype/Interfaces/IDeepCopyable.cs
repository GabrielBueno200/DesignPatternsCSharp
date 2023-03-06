namespace Prototype.Interfaces;

public interface IDeepCopyable<T> where T : new()
{
    void CopyTo(T target);

    public T DeepCopy()
    {
        var T = new T();
        CopyTo(T);
        return T;
    }
}
