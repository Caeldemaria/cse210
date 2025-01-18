using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int NewNumber=-1;
        int sum=0;
        int Avarege=0;
        int  largest=int.MinValue;
        while(NewNumber!=0){
            Console.WriteLine("Enter number: ");
            NewNumber=int.Parse(Console.ReadLine());
            if(NewNumber!=0){
                numbers.Add(NewNumber);
            }
            else{
                foreach (int number in numbers)
                {
                    if(number>largest){
                        largest=number;
                    };
                    sum+=number;

                    
                };
                Avarege=sum/numbers.Count;
                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The Avarege is: {Avarege}");
                Console.WriteLine($"The largest number is: {largest}");
            }
        }
    }
}