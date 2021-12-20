using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.Write("Enter 1st Number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd Number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before swap");
        Console.WriteLine("a = " + a + ", b = " + b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After swap");
        Console.WriteLine("a = " + a + ", b = " + b);
    }
}