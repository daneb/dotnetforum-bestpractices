```csharp
using System;

// Shape interface
public interface IShape
{
    double CalculateArea();
}

// Rectangle class implementing IShape
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// Circle class implementing IShape
public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// AreaCalculator class
public class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var rectangle = new Rectangle { Width = 5, Height = 10 };
        var circle = new Circle { Radius = 7 };

        var calculator = new AreaCalculator();
        Console.WriteLine("Rectangle Area: " + calculator.CalculateArea(rectangle));
        Console.WriteLine("Circle Area: " + calculator.CalculateArea(circle));
    }
}
```

In this C# version of the example, the `IShape` interface represents the contract for shapes. The `Rectangle` and `Circle` classes implement this interface and provide their own implementation of the `CalculateArea` method. The `AreaCalculator` class remains the same and takes advantage of the Open-Closed Principle by accepting any object that implements the `IShape` interface.

This design allows you to add new shapes by simply implementing the `IShape` interface without modifying the existing codebase. The Open-Closed Principle is thus adhered to, as the code is open for extension (new shapes can be added) but closed for modification (existing code doesn't need to be changed when adding new shapes).