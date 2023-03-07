using System.Collections.ObjectModel;
using Adapter.Entities;

namespace Adapter.Adapters;

public class LineToPointAdapter : Collection<Adapter.Entities.Point>
{
    private static int count = 0;

    public LineToPointAdapter(Line line)
    {
        Console.WriteLine($"{++count}: Generating points for line [{line.Start.X},{line.Start.Y}]-[{line.End.X},{line.End.Y}] (no caching)");

        int left = Math.Min(line.Start.X, line.End.X);
        int right = Math.Max(line.Start.X, line.End.X);
        int top = Math.Min(line.Start.Y, line.End.Y);
        int bottom = Math.Max(line.Start.Y, line.End.Y);
        int dx = right - left;
        int dy = line.End.Y - line.Start.Y;

        if (dx == 0)
        {
            for (int y = top; y <= bottom; ++y)
            {
                Add(new Adapter.Entities.Point(left, y));
            }
        }
        else if (dy == 0)
        {
            for (int x = left; x <= right; ++x)
            {
                Add(new Adapter.Entities.Point(x, top));
            }
        }
    }
}

