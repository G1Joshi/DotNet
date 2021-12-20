using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        int rev = 0, n = num;
        while (n > 0)
        {
            int rem = n % 10;
            rev = rev * 10 + rem;
            n /= 10;
        }
        if (num == rev)
        {
            Console.Write("Number is Palindrome");
        }
        else
        {
            Console.Write("Number is not Palindrome");
        }
    }
}