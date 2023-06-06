using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            MediaPlayer mediaPlayer=new MediaPlayer();
            ((IVideo)mediaPlayer).VideoPlayer();
            ((IAudio)mediaPlayer).AudioPlayer();
            Console.ReadLine();

            //Method 2
            IVideo video = new MediaPlayer();
            IAudio audio = new MediaPlayer();
            video.VideoPlayer();
            audio.AudioPlayer();
            Console.ReadLine();
        }
    }
}
public interface IVideo
{
    void VideoPlayer();
}

public interface IAudio
{
    void AudioPlayer();
}
public class MediaPlayer : IVideo, IAudio
{
    void IAudio.AudioPlayer()
    {
        Console.WriteLine("Audio-Player is working.");
    }
    void IVideo.VideoPlayer()
    {
        Console.WriteLine("Video-Player is working");
    }
}
