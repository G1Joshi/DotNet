using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.Write("Number is Even Number");
        }
        else
        {
            Console.Write("Number is Odd Number");
        }
    }
}