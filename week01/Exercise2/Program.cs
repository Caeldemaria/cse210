using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Waht is the grade percentage?");
        string Answer=Console.ReadLine();

        int percentage= int.Parse(Answer);
        string letter=" ";
        if(percentage>=90){
            letter="A";
            Console.WriteLine(letter);
        }
        else if(percentage>=80 && percentage<90){
        letter="B";
            Console.WriteLine(letter);   
        }
        else if(percentage>=70 && percentage<80){
        letter="C";
            Console.WriteLine(letter);   
        }
        else if(percentage>=60 && percentage<70){
        letter="D";
            Console.WriteLine(letter);    
        }
        else{
        letter="F";
            Console.WriteLine(letter);    
        };
        if (percentage>=70){
            Console.WriteLine("Congratulations you passed");
        }
        else{
            Console.WriteLine("Don't worry you can be better in the next time!");
        }


    }
}