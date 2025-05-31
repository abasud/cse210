public class VideoLibrary
{
    public List<Video> _videoList = new List<Video>();

    public void DisplayVideos()
    {
        foreach (Video video in _videoList)
        {
            Console.WriteLine();
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}