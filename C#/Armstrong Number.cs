using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, n = num;
        while (n > 0)
        {
            int rem = n % 10;
            sum += rem * rem * rem;
            n /= 10;
        }
        if (sum == num)
        {
            Console.Write("Armstrong Number");
        }
        else
        {
            Console.Write("Not an Armstrong Number");
        }
    }
}