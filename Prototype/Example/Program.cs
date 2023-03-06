using System;

/*
Given the definitions above, 
you are asked to implement Line.DeepCopy()  
to perform a deep copy of the current Line  object.
*/

namespace Example;

public class Point
{
    public int X, Y;

    public Point DeepCopy()
    {
        return new Point { X = X, Y = Y };
    }
}

public class Line
{
    public Point Start, End;

    public Line DeepCopy()
    {
        return new Line
        {
            Start = Start.DeepCopy(),
            End = End.DeepCopy()
        };
    }

    public override string? ToString()
    {
        return $"{nameof(Start)}: ({Start.X}, {Start.Y}), {nameof(End)}: ({End.X}, {End.Y})";
    }
}

public static class Example
{
    public static void Main(string[] args)
    {
        var line = new Line
        {
            Start = new() { X = 5, Y = 6 },
            End = new() { X = 7, Y = 8 }
        };

        var copy = line.DeepCopy();
        copy.Start.X++;
        copy.Start.Y++;

        Console.WriteLine(line);
        Console.WriteLine(copy);
    }
}