using System;

class Program
{
    static void Main(string[] args)
    {
         while (true)  
        {  
            Console.Clear();  
            Console.WriteLine("Choose an activity:");  
            Console.WriteLine("1. Breathing Activity");  
            Console.WriteLine("2. Listing Activity");  
            Console.WriteLine("3. Reflecting Activity");  
            Console.WriteLine("4. Exit");  
            Console.Write("Select an option: ");  
            string choice = Console.ReadLine();  

            if (choice == "1")  
            {  
                BreathingActivity breathingActivity = new BreathingActivity();  
                breathingActivity.Run();  
            }  
            else if (choice == "2")  
            {  
                ListingActivity listingActivity = new ListingActivity();  
                listingActivity.Run();  
            }  
            else if (choice == "3")  
            {  
                ReflectingActivity reflectingActivity = new ReflectingActivity();  
                reflectingActivity.Run();  
            }  
            else if (choice == "4")  
            {  
                break;  
            }  
            else  
            {  
                Console.WriteLine("Invalid choice. Please try again.");  
            }  

            Console.WriteLine("Press Enter to continue...");  
            Console.ReadLine();  
        }  
    }  
    }
