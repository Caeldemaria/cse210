using System;

class Program
{
    static void Main(string[] args)
    {

    DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        };
        static string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            string UserName=Console.ReadLine();
            return UserName;
        };
        static int PromptUserNumber (){
            Console.WriteLine("Please enter your favorite number:");
            int number=int.Parse(Console.ReadLine());
            return number;
        };
        static int SquareNumber(int number){
            int square= number*number;
            return square;
        };

        static void DisplayResult(string UserName, int square)
    {
        Console.WriteLine($"Brother {UserName}, the square of your number is {square}");
    }


    }
}