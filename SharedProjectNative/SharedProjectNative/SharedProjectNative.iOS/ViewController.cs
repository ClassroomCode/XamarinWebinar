using SharedPCL;
using SharedStdLib;
using System;

using UIKit;

namespace SharedProjectNative.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
           
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            var mc = new MyClass();
            MyLabel.Text = mc.GetMessage();

            // var moc = new MyOtherClass();
            // MyLabel.Text = moc.GetMessage();

            // var mnsc = new MyNetStdClass();
            // MyLabel.Text = mnsc.GetMessage();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

