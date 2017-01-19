using Foundation;
using MediaPlayer;

namespace StreamVideo.iOS
{
    public class MoviePlayerViewController : MPMoviePlayerViewController
    {
        public NSUrl Url { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MoviePlayer.ContentUrl = Url;
            MoviePlayer.SourceType = MPMovieSourceType.Streaming;
            MoviePlayer.RepeatMode = MPMovieRepeatMode.One;
                    
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (!MoviePlayer.IsPreparedToPlay)
            {
                MoviePlayer.PrepareToPlay();
            }

            MoviePlayer.Play();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            MoviePlayer.Stop();
        }
    }
}
