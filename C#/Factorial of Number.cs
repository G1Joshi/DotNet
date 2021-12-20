using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        int fact = num;
        for (int i = num - 1; i >= 1; i--)
        {
            fact *= i;
        }
        Console.Write("Factorial: " + fact);
    }
}