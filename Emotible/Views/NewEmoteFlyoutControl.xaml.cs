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
    public sealed partial class NewEmoteFlyoutControl : UserControl
    {
        public NewEmoteFlyoutControl()
        {
            this.InitializeComponent();
        }

        public static void InstantiateNewEmoteFlyout(Panel parentPanel, object dataContext)
        {
            FlyoutBoxControl box = new FlyoutBoxControl();
            var content = new NewEmoteFlyoutControl();
            content.DataContext = dataContext;
            box.Content = content;

            parentPanel.Children.Add(box);
        }
    }
}
