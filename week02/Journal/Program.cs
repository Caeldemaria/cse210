using System;
using System.Collections.Generic; 
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();  
        PromptGenerator promptGenerator = new PromptGenerator();  

        while (true)  
        {  
            Console.WriteLine("Menu:");  
            Console.WriteLine("1. Write a new entry");  
            Console.WriteLine("2. Display journal");  
            Console.WriteLine("3. Save journal to file");  
            Console.WriteLine("4. Load journal from file");  
            Console.WriteLine("5. Exit");  
            Console.Write("Choose an option: ");  
            string choice = Console.ReadLine();  
                if(choice=="1"){
                    string prompt = promptGenerator.GetRandomPrompt();  
                    Console.WriteLine(prompt);  
                    Console.Write("Your response: ");  
                    string entryText = Console.ReadLine();  
                    Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, entryText);  
                    journal.AddEntry(entry);  
                    
                } 

                else if(choice=="2"){

                    journal.DisplayAll();  
                }  
                else if(choice=="3"){

                    Console.Write("Enter filename to save journal: ");  
                    string saveFile = Console.ReadLine();  
                    journal.SaveToFile(saveFile);  
                    Console.WriteLine("Journal saved.");
                }

                else if(choice=="4"){

                    Console.Write("Enter filename to load journal: ");  
                    string loadFile = Console.ReadLine();  
                    journal.LoadFromFile(loadFile);  
                    Console.WriteLine("Journal loaded.");
                }
                else if(choice=="5"){

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");  
                    break;
                    
                } 
            }  
        }  
    }  


