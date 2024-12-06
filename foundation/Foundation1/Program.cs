using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Dan Brown", "This video is awesome!"),
            new Comment("Jose Johnson", "This video was terrible!"),
            new Comment("Jack Jones", "What?")

        };
        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Dan Brown", "This video is awesome!"),
            new Comment("Jose Johnson", "This video was terrible!"),
            new Comment("Jack Jones", "What?")

        };
        List<Comment> comments3 = new List<Comment>
        {
            new Comment("Dan Brown", "This video is awesome!"),
            new Comment("Jose Johnson", "This video was terrible!"),
            new Comment("Jack Jones", "What?")

        };
        List<Video> videos = new List<Video>
        {

           new Video("How to Make a Cake", "Drew Stanley", 60, comments1),
           new Video("How to Make a Fried Egg", "Joshua Howard", 90, comments2),
           new Video("How to Make a Pancake", "Jordan Keller", 120, comments3)
        };
        foreach (var v in videos)
        {
            v.DisplayVideo();
        }
    }
}