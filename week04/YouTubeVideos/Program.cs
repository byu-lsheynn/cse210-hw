using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> trackList = new List<Video>();

        // ---- Video Track 1 ---
        Video track1 = new Video();
        track1._title = "Coming Closer to Jesus Christ | President Dallin H. Oaks";
        track1._author = "BYU Speeches";
        track1._lenghtInSeconds = 1331;

        Comment t1c1 = new Comment();
        t1c1._commenterName = "Having_fun_everyday";
        t1c1._text = "I stand as a witness in Jesus Christ that you can trust the Holy Spirit. I stand as a witness that you can trust the spirit of revelation.";
        Comment t1c2 = new Comment();
        t1c2._commenterName = "dfausti66";
        t1c2._text = "I believe the power of the priesthood used offense/defense against Satan is necessary.";
        Comment t1c3 = new Comment();
        t1c3._commenterName = "matthewure9533";
        t1c3._text = "Nor shall they fiddle with the dead, for that realm belongs to me. Matthew 1.1";

        track1._comments.AddRange(new[] { t1c1, t1c2, t1c3 });
        trackList.Add(track1);

        // ---- Video Track 2 ---
        Video track2 = new Video();
        track2._title = "Jesus Heals a Man Born Blind | John 9";
        track2._author = "The Church of Jesus Christ of Latter - day Saints";
        track2._lenghtInSeconds = 467;

        Comment t2c1 = new Comment();
        t2c1._commenterName = "buddyclayton789";
        t2c1._text = "'As I have loved you, so must you love others.' ~ Jesus";
        Comment t2c2 = new Comment();
        t2c2._commenterName = "jetswim3327";
        t2c2._text = "But he said, 'the things which are impossible with men are possible with God' Luke 18:27";
        Comment t2c3 = new Comment();
        t2c3._commenterName = "emjaekyute7971";
        t2c3._text = "Jesus if you heal the blind man. Heal me too. Touch me to ease the pain. I pray for you and I believe in you.";

        track2._comments.AddRange(new[] { t2c1, t2c2, t2c3 });
        trackList.Add(track2);

        // --- Video Track 3 ---
        Video track3 = new Video();
        track3._title = "I Will Trust in the Lord | 2 Nephi 4";
        track3._author = "Book of Mormon: Another Testament of Jesus Christ";
        track3._lenghtInSeconds = 166;

        Comment t3c1 = new Comment();
        t3c1._commenterName = "jh-nt9ws";
        t3c1._text = "Every major mistake I have ever made, came from just trusting in myself!";
        Comment t3c2 = new Comment();
        t3c2._commenterName = "MariaCorazonAbuan-t1e";
        t3c2._text = "If we trust  in God we can't feel any worries in life and we live with peaceful mind and heart";
        Comment t3c3 = new Comment();
        t3c3._commenterName = "Dallinbn";
        t3c3._text = "Very powerful to hear these college age students speak of what matters most - Jesus Christ - in a candid, campus setting. Thank you!";
        Comment t3c4 = new Comment();
        t3c4._commenterName = "CatchTheBuzz1";
        t3c4._text = "Beautiful. Thank you very much";

        track3._comments.AddRange(new[] { t3c1, t3c2, t3c3, t3c4, });
        trackList.Add(track3);

        // --- Display Loop ---
        Console.WriteLine("=================================");
        Console.WriteLine("      YOUTUBE VIDEO TRACKER      ");
        Console.WriteLine("=================================\n");

        foreach (Video video in trackList)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lenghtInSeconds} seconds");
            Console.WriteLine($"Number of CommentsL: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"> @{comment._commenterName}:\n{comment._text}\n");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}