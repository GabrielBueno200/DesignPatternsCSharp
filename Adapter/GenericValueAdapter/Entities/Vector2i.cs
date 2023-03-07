namespace GenericValueAdapter.Entities;

public class Vector2i : VectorOfInt<Dimensions.Two>
{
    public Vector2i()
    {
    }

    public Vector2i(params int[] values) : base(values)
    {
    }
}