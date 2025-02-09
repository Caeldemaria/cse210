using System;

public class ListingActivity : Activity  
{  
    private List<string> _prompts = new List<string>  
    {  
        "Who are people that you appreciate?",  
        "What are personal strengths of yours?",  
        "Who are people that you have helped this week?",  
        "When have you felt the Holy Ghost this month?",  
        "Who are some of your personal heroes?"  
    };  

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }  

    public void Run()  
    {  
        DisplayStartingMmessege();  
        string prompt = GetRandomPrompt();  
        Console.WriteLine(prompt);  
        ShowCountDown(5);  
        List<string> userResponses = new List<string>();  
        DateTime endTime = DateTime.Now.AddSeconds(_duration);  

        while (DateTime.Now < endTime)  
        {  
            Console.Write("Enter an item (or type 'done' to finish): ");  
            string response = Console.ReadLine();  
            if (response.ToLower() == "done") break;  
            userResponses.Add(response);  
        }  

        Console.WriteLine($"You listed {userResponses.Count} items.");  
        DisplayEndingMessege();  
    }  

    private string GetRandomPrompt()  
    {  
        Random rand = new Random();  
        int index = rand.Next(_prompts.Count);  
        return _prompts[index];  
    }  
} 