using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video vid1 = new Video("Vid1", "Naomi Wolf", 600);
        vid1.addComment("leeryseason", "Your video is good!");
        vid1.addComment("unkemtsteal", "Your video is bad!");
        vid1.addComment("granularfoundation", "Please make more videos!");
        videos.Add(vid1);
        Video vid2 = new Video("Vid2", "Londyn Pace", 500);
        vid2.addComment("drowsywitness", "Your video is good!");
        vid2.addComment("certainability", "Your video is bad!");
        vid2.addComment("edibledrawer", "Please make more videos!");
        videos.Add(vid2);
        Video vid3 = new Video("Vid3", "Carl Booth", 800);
        vid3.addComment("resoluteaccident", "Your video is good!");
        vid3.addComment("tensetruck", "Your video is bad!");
        vid3.addComment("tiredebt", "Please make more videos!");
        videos.Add(vid3);
        Video vid4 = new Video("Vid4", "Max Pitts", 900);
        vid4.addComment("crispgirlfriend", "Your video is good!");
        vid4.addComment("easystorage", "Your video is bad!");
        vid4.addComment("marrieddrawing", "Please make more videos!");
        videos.Add(vid4);

        for (int i = 0; i < videos.Count(); i++)
        {
            Console.WriteLine(videos[i].getTitle());
            Console.WriteLine(videos[i].getAuthor());
            Console.WriteLine($"{videos[i].getLength()} seconds");
            Console.WriteLine($"Number of Comments: {videos[i].getComments().Count()}");
            Console.WriteLine("Comments:");
            for (int j = 0; j < videos[i].getComments().Count(); j++)
            {
                Console.WriteLine(videos[i].getComments()[j].getCommenter() + ": " + videos[i].getComments()[j].getComment());
            }
            Console.WriteLine("");
        }
    }
}