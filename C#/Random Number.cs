using System;

class Program
{
    static void Main(string[] args)
    {
        Random ran = new Random();
        int num = ran.Next();
        Console.Write("Random Number: " + num);
    }
}