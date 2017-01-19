using AVKit;
using Foundation;

namespace StreamVideo.iOS
{
    public class PlayerViewController : AVPlayerViewController
    {
        public NSUrl Url { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Player = new AVFoundation.AVPlayer(Url);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            Player.Play();
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);

            Player.Pause();
        }
    }
}
