using System;

class Program
{
    static void Main(string[] args)
    {
        FileInfo file = new FileInfo("Program.cs");
        Console.WriteLine("File Creation Time:");
        Console.WriteLine(file.CreationTime);
        Console.WriteLine("File Last Access Time:");
        Console.WriteLine(file.LastAccessTime);
        Console.WriteLine("File Last Write Time:");
        Console.WriteLine(file.LastWriteTime);
    }
}