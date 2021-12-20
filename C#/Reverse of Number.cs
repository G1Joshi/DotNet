using System;

class Program
{
    static void Main(string[] args)
    {
        int num, rev = 0;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        while (num > 0)
        {
            int rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }
        Console.Write("Reversed Number: " + rev);
    }
}