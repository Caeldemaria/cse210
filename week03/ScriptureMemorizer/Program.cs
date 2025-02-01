using System;

class Program 
    {  
        public static void Main(string[] args)  
        {  
            var reference = new Reference("João", 3, 16);  
            var scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");  

            while (true)  
            {  
                Console.Clear();  
                Console.WriteLine(reference.GetDisplayText());  
                Console.WriteLine(scripture.GetDisplayText());  
                Console.WriteLine("\n Press Enter to Hide words or Write 'quit' to exit.");  

                var input = Console.ReadLine();  
                if (input?.ToLower() == "quit")  
                {  
                    break;  
                }  

                scripture.HideRandomWords(1);  

                if (scripture.IsCompletelyHidden())  
                {  
                    Console.Clear();  
                    Console.WriteLine(reference.GetDisplayText());  
                    Console.WriteLine(scripture.GetDisplayText());  
                    Console.WriteLine("\nTodas as palavras estão ocultas. Saindo...");  
                    break;  
                }  
            }  
        }  
    }  
