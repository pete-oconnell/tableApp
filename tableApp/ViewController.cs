using System;

using UIKit;

namespace tableApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //table = new UITableView(View.Bounds);
            string[] tableItems = new string[] { "test1", "test2", "test3" };
            peteTable.Source = new TableSource(tableItems, this);
            //table.Source = new TableSource(tableItems, this);
            //Add(table);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
