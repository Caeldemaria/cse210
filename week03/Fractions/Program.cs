using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Frac1=new Fraction();
        Console.WriteLine(Frac1.GetFractionsString());
        Console.WriteLine(Frac1.GetDecimal());

        Fraction Frac2=new Fraction();
        Console.WriteLine(Frac2.GetFractionsString());
        Console.WriteLine(Frac2.GetDecimal());
        
        Fraction Frac3=new Fraction();
        Console.WriteLine(Frac3.GetFractionsString());
        Console.WriteLine(Frac3.GetDecimal());

    }
}