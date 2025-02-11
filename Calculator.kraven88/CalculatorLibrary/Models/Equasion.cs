﻿namespace CalculatorLibrary.Models;

public class Equation
{
    required public double A { get; set; }
    required public double B { get; set; }
    required public string Operation { get; set; }
    public double Result { get; set; } = double.NaN;

    public override string ToString()
    {
        var sign = Operation switch
        {
            "Add" => "+",
            "Subtract" => "-",
            "Multiply" => "*",
            "Divide" => "/",
            "Power" => "^",
            "Root" => "√",
            "Sine" => "sin",
            "Cosine" => "cos",
            "Tangent" => "tg",
            "Cotangent" => "ctg"
        };

        if (sign.Length > 1)
            return $"{sign} {A}° = {Result:0.##}";

        return $"{A} {sign} {B} = {Result:0.##}";
    }
}
