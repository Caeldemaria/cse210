using System;

class Program
{
    

    public static void Main(string[] args)  
    {  
        // Create videos  
        Video video1 = new Video("How to Code in C#", "John Doe", 300);  
        video1.AddComment(new Comment("Alice", "Great tutorial!"));  
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));  
        video1.AddComment(new Comment("Charlie", "I learned a lot from this."));  

        Video video2 = new Video("Understanding Algorithms", "Jane Smith", 450);  
        video2.AddComment(new Comment("David", "Awesome explanation."));  
        video2.AddComment(new Comment("Eva", "I love the examples you provided."));  

        Video video3 = new Video("Introduction to Machine Learning", "Emily Johnson", 600);  
        video3.AddComment(new Comment("Frank", "This is a game changer."));  
        video3.AddComment(new Comment("Grace", "Can you explain more about neural networks?"));  
        video3.AddComment(new Comment("Hank", "Really interesting content!"));  

        // Store videos in a list  
        List<Video> videos = new List<Video> { video1, video2, video3 };  

        // Display video information  
        foreach (var video in videos)  
        {  
            Console.WriteLine($"Title: {video.GetTitle()}");  
            Console.WriteLine($"Author: {video.GetAuthor()}");  
            Console.WriteLine($"Length: {video.GetLength()} seconds");  
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");  
            Console.WriteLine("Comments:");  
            foreach (var comment in video.GetComments())  
            {  
                Console.WriteLine(comment);  
            }  
            Console.WriteLine();  
        }  
    }  
}
    
