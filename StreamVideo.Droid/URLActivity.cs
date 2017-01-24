using Android.App;
using Android.Widget;
using Android.OS;
using Android.Net;
using Android.Content;

namespace StreamVideo.Droid
{
    [Activity(Label = "StreamVideo.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class URLActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.URL);

            // Get our button from the layout resource,
            // and attach an event to it

            var streamURL = FindViewById<EditText>(Resource.Id.streamURL);
            var button = FindViewById<Button>(Resource.Id.playButton);

            streamURL.Text = "http://192.241.250.62:1935/live/wb.stream/playlist.m3u8";

            button.Click += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(streamURL.Text))
                {
                    var intent = new Intent(this, typeof(PlayerActivity));
                    intent.PutExtra("url", streamURL.Text);
                    StartActivity(intent);
                }
                else {
                    Toast.MakeText(this, "Enter stream url first!", ToastLength.Long);
                }
            };
        }
    }
}

