// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace tableApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView HomeScreen { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView peteTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (HomeScreen != null) {
                HomeScreen.Dispose ();
                HomeScreen = null;
            }

            if (peteTable != null) {
                peteTable.Dispose ();
                peteTable = null;
            }
        }
    }
}