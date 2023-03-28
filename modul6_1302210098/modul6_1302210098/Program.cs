using System;
using System.Runtime.Serialization.Formatters;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        id = random.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public int getPlayCount()
    {
        return this.playCount;   
    }

    public void PrintVideoDetails()
    {
        Console.Write("ID: " + id + " ");
        Console.Write("Title: " + title + " ");
        Console.WriteLine("Play Count: " + playCount);
    }
}
public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string nama)
    {
        Random random = new Random();
        id = random.Next(10000, 99999);
        this.Username = nama;
        uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        for(int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].getPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
       uploadedVideos.Add(video);
    }

    public void PrintAllVideo()
    {
        Console.WriteLine("User: " + Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.Write("Video " + (i + 1) + " judul: ");
            uploadedVideos[i].PrintVideoDetails();
        }
    }
}

class program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo v1 = new SayaTubeVideo("Malin Kundang");
        SayaTubeVideo v2 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v3 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v4 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v5 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v6 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v7 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v8 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v9 = new SayaTubeVideo("Avengers");
        SayaTubeVideo v10 = new SayaTubeVideo("Avengers");

        v1.IncreasePlayCount(20);
        v2.IncreasePlayCount(30);
        v3.IncreasePlayCount(30);
        v4.IncreasePlayCount(30);
        v5.IncreasePlayCount(30);
        v6.IncreasePlayCount(30);
        v7.IncreasePlayCount(30);
        v8.IncreasePlayCount(30);
        v9.IncreasePlayCount(30);
        v10.IncreasePlayCount(30);

        SayaTubeUser user = new SayaTubeUser("Alif");
        user.AddVideo(v1);
        user.AddVideo(v2);
        user.AddVideo(v3);
        user.AddVideo(v4);
        user.AddVideo(v5);
        user.AddVideo(v6);
        user.AddVideo(v7);
        user.AddVideo(v8);
        user.AddVideo(v9);
        user.AddVideo(v10);
        user.PrintAllVideo();
        Console.WriteLine("Total Video: " + user.GetTotalVideoPlayCount());
    }
}
