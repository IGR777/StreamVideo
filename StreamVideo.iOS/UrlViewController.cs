using UIKit;

namespace StreamVideo.iOS
{
    public partial class UrlViewController : UIViewController
    {
        public UrlViewController() : base("UrlViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationController.NavigationBar.Translucent = false;
            UrlTextField.ClearButtonMode = UITextFieldViewMode.WhileEditing;

            UrlTextField.Text = "http://192.241.250.62:1935/live/wb.stream/playlist.m3u8";

            NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Play, (sender, e) =>
            {
                var url = Foundation.NSUrl.FromString(UrlTextField.Text);
                if (url != null)
                {
                    PresentViewController(new PlayerViewController { Url = url }, true, null);
                }
            });
        }
    }
}
