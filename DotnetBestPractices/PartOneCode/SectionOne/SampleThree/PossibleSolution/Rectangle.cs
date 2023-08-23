﻿namespace DotnetBestPractices.Code.SampleThree.PossibleSolution;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area() => Width * Height;
}