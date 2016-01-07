using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Emotible.Views
{
    public sealed partial class FlyoutBoxControl : UserControl
    {
        public FlyoutBoxControl()
        {
            this.InitializeComponent();
            this.InitializeFlyout();
        }

        protected void InitializeFlyout()
        {
            CompressFlyoutBox.Completed += OnFlyoutDestroyComplete;
            ExpandFlyoutBox.Begin();
        }

        public void DestroyFlyoutBox()
        {
            CompressFlyoutBox.Begin();
            this.IsEnabled = false;
        }

        public void OnFlyoutDestroyComplete(object sender, object args)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
