using System;
using System.Collections.Generic;  


public class Activity{
    protected string _name;
    protected string _descrpition;
    protected int _duration;

public Activity(string name, string descrption){
_name=name;
_descrpition=descrption;

}
public  void DisplayStartingMmessege(){
Console.WriteLine($"Starting: {_name}");  
        Console.WriteLine(_descrpition);  
        Console.Write("Enter the duration of the activity in seconds: ");  
        _duration = int.Parse(Console.ReadLine());  
        Console.WriteLine("Get ready to begin...");  
        ShowSpinner(3);  
}
public void DisplayEndingMessege(){
    Console.WriteLine("you did it!Good Job");  
        ShowSpinner(3);  
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");  
        ShowSpinner(3); 
}
   protected void ShowSpinner(int seconds)  
    {  
        for (int i = 0; i < seconds; i++)  
        {  
            Console.Write(". ");  
            Thread.Sleep(1000); // Pause de 1 segundo  
        }  
        Console.WriteLine();  
    }  

    protected void ShowCountDown(int seconds)  
    {  
        for (int i = seconds; i > 0; i--)  
        {  
            Console.WriteLine(i);  
            Thread.Sleep(1000); // Pause de 1 segundo  
        }  
    }  
}  

