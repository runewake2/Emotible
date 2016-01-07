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
using Emotible.Controllers;
using Emotible.Models.ViewModels;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Emotible.Views
{
    public sealed partial class SearchBoxFlyoutControl : UserControl
    {
        private SearchBoxFlyoutViewModel viewModel;
        private SearchController controller;

        public SearchBoxFlyoutControl()
        {
            this.InitializeComponent();
            viewModel = new SearchBoxFlyoutViewModel();
            controller = new SearchController(viewModel);
            ContentPanel.DataContext = viewModel;

            controller.BeginTimedSearchSuggestionUpdate(TimeSpan.FromSeconds(5));
        }

        public static void InstantiateSearchFlyout(Panel parentPanel, object dataContext)
        {
            FlyoutBoxControl box = new FlyoutBoxControl();
            var content = new SearchBoxFlyoutControl();
            content.DataContext = dataContext;
            box.Content = content;

            parentPanel.Children.Add(box);
        }
    }
}
