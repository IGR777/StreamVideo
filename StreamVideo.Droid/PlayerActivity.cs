using Android.App;
using Android.Net;
using Android.OS;
using Android.Widget;

namespace StreamVideo.Droid
{
    [Activity(Label = "PlayerActivity")]
    public class PlayerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Player);

            VideoView vidView = (VideoView)FindViewById(Resource.Id.myVideo);
            //var vidAddress = "http://gourl.su/ud?UKROFASCHIZM.m3u8";
            var vidAddress = Intent.GetStringExtra("url"); 
            var vidUri = Uri.Parse(vidAddress);

            vidView.SetVideoURI(vidUri);
            vidView.Start();
        }
    }
}
