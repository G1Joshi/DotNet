using System;

class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter Number of Terms: ");
        n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c;
        Console.WriteLine("Fibonacci series");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}