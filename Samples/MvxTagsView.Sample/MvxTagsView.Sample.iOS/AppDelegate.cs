using MvvmCross.Platforms.Ios.Core;
using MvxTagsView_Sample.Core;
using Foundation;
using UIKit;
using MvvmCross;
using MvvmCross.ViewModels;

namespace MvxTagsView_Sample.iOS
{
    [Register("AppDelegate")]
	public partial class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
		public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
			var result = base.FinishedLaunching(application, launchOptions);

            return result;
        }
    }
}
