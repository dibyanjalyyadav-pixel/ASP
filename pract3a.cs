using System;
delegate void Operation(int a, int b);
class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Additon = " + (a + b));
    }
    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }
    public void Mul(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }
    public void Div(int a, int b)
    {
        Console.WriteLine("Division = " + (a / b));
    }
}
class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Operation obj;

        obj = c.Add;
        obj(20, 10);

        obj = c.Sub;
        obj(20, 10);

        obj = c.Mul;
        obj(20, 10);

        obj = c.Div;
        obj(20, 10);

        Console.WriteLine("Divyanjali T052");
    }
}

