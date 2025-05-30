using System;

class Program
{
    static void Main(string[] args)
    {
        Comments video1comment1 = new Comments();
        video1comment1._nameComment = "CodeWizard21";
        video1comment1._textComment = "AI is evolving so fast, this is mind-blowing!";

        Comments video1comment2 = new Comments();
        video1comment2._nameComment = "Sara_Techie";
        video1comment2._textComment = "Great breakdown of what's coming next, thanks!";

        Comments video1comment3 = new Comments();
        video1comment3._nameComment = "NeoBot999";
        video1comment3._textComment = "Scary and exciting at the same time.";

        Video video1 = new Video();
        video1._title = "The Future of AI: What to Expect in 2030";
        video1._author = "TechFront";
        video1._length = 725;
        video1._comments.Add(video1comment1);
        video1._comments.Add(video1comment2);
        video1._comments.Add(video1comment3);

        // ****************************************************************************************

        Comments video2comment1 = new Comments();
        video2comment1._nameComment = "LunaBrushes";
        video2comment1._textComment = "Your color choices are beautiful 😍";

        Comments video2comment2 = new Comments();
        video2comment2._nameComment = "SketchyGuy";
        video2comment2._textComment = "Love how simple yet detailed this is!";

        Comments video2comment3 = new Comments();
        video2comment3._nameComment = "ArtByNina";
        video2comment3._textComment = "Can't wait to try this technique.";

        Video video2 = new Video();
        video2._title = "Painting a Cityscape with Watercolors in 5 Steps";
        video2._author = "ColorBloom Studio";
        video2._length = 486;
        video2._comments.Add(video2comment1);
        video2._comments.Add(video2comment2);
        video2._comments.Add(video2comment3);

        // ****************************************************************************************

        Comments video3comment1 = new Comments();
        video3comment1._nameComment = "TrailSeeker";
        video3comment1._textComment = "This view is unreal. I need to go!";

        Comments video3comment2 = new Comments();
        video3comment2._nameComment = "NatureNerd88";
        video3comment2._textComment = "I felt like I was there with you!";

        Comments video3comment3 = new Comments();
        video3comment3._nameComment = "Wanderlust_Jay";
        video3comment3._textComment = "Adding this to my list";

        Video video3 = new Video();
        video3._title = "Hiking the Andes: 3 Days Through the Clouds";
        video3._author = "ExploreMore";
        video3._length = 1050;
        video3._comments.Add(video3comment1);
        video3._comments.Add(video3comment2);
        video3._comments.Add(video3comment3);

        // ****************************************************************************************

        Videos videos = new Videos();
        videos._videoList.Add(video1);
        videos._videoList.Add(video2);
        videos._videoList.Add(video3);

        videos.DisplayVideos();
    }
}