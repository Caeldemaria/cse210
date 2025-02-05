using System;

class Program
{
    static void Main(string[] args)
    {
        Math StudentMath=new Math("Pedro","Fractions","7.3","3-10, 20-21");
        string summary=StudentMath.GetSummary();
        string  HomeWork=StudentMath.GetHomework();
        Console.WriteLine(summary);
        Console.WriteLine(HomeWork);

        Writing StudentWriting= new Writing("Micael","European History","The Causes of World War II");
        string Summary=StudentWriting.GetSummary();
        string WritingInfo=StudentWriting.GetWritingInformation();
        Console.WriteLine(Summary);
        Console.WriteLine(WritingInfo);
    }
}