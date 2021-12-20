using System;

class Program
{
    static void Main(string[] args)
    {
        int num, sum = 0;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            int rem = num % 10;
            sum += rem;
            num /= 10;
        }
        Console.WriteLine("Sum of Digits: " + sum);
    }
}