using System;
delegate void Message();
class Demo
{
    public void Welcome()
    {
        Console.WriteLine("WELCOME...");
    }
    public void Learn()
    {
        Console.WriteLine("Learning C# Delegates");
    }
    public void Thanks()
    {
        Console.WriteLine("Thank You");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Demo d = new Demo();
        Message m;

        m = d.Welcome;
        m += d.Learn;
        m += d.Thanks;
        m();

        Console.Write("Divyanjali T052");

    }
}

