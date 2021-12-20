using System;

class Program
{
    static bool prime(int n)
    {
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (prime(num))
        {
            Console.Write("Number is Prime");
        }
        else
        {
            Console.Write("Number is not Prime");
        }
    }
}