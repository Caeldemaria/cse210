using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_Name= Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string Last_Name=Console.ReadLine();
        
        Console.WriteLine($"Your name is {Last_Name},{first_Name} {Last_Name}");
        
    }
}