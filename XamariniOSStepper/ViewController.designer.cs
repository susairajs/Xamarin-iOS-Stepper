// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSStepper
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIStepper stepper { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint stepper1 { get; set; }

        [Action ("ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ValueChanged (UIKit.UIStepper sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }

            if (stepper != null) {
                stepper.Dispose ();
                stepper = null;
            }

            if (stepper1 != null) {
                stepper1.Dispose ();
                stepper1 = null;
            }
        }
    }
}