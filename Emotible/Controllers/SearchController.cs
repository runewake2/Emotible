using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Emotible.Models.ViewModels;

namespace Emotible.Controllers
{
    public class SearchController
    {
        private static readonly string[] searchSuggestions = new string[]{
            "TableFlip",
            "Rage",
            "Cat",
            "Meh",
            "Shrug",
            "Dancing",
            "Surprise"
        };

        private DispatcherTimer timer = null;
        private SearchBoxFlyoutViewModel search;

        public SearchController(SearchBoxFlyoutViewModel searchVM) {
            search = searchVM;
            UpdateSuggestion();
        }

        public void UpdateSuggestion()
        {
            Random random = new Random();
            var suggestion = "Try: " + searchSuggestions[random.Next(searchSuggestions.Length)];
            search.SuggestionText = suggestion;
        }

        public void BeginTimedSearchSuggestionUpdate(TimeSpan interval)
        {
            if (timer != null)
            {
                throw new InvalidOperationException("Attempting to restart a timer by overriding it. This will cause bad behavior. Kill the old timer first.");
            }

            timer = new DispatcherTimer {
                Interval = interval
            };

            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, object e)
        {
            UpdateSuggestion();
        }
    }
}
