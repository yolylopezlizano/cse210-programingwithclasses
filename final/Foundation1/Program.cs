using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video("Title Video 1", "Author 1", 180);
        video1.AddComment("Commenter 1", "This is a great video!");
        video1.AddComment("Commenter 2", "I love it!");
        video1.AddComment("Commenter 3", "Nice content!");

        Video video2 = new Video("Title Video 2", "Author 2", 240);
        video2.AddComment("Commenter 1", "Awesome video!");
        video2.AddComment("Commenter 2", "Interesting stuff.");
        video2.AddComment("Commenter 3", "Great job!");

        Video video3 = new Video("Title Video 3", "Author 3", 300);
        video3.AddComment("Commenter 1", "Well done!");
        video3.AddComment("Commenter 2", "I enjoyed watching this.");
        video3.AddComment("Commenter 3", "Keep it up!");
        video3.AddComment("Commenter 4", "Excellent work!");

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
