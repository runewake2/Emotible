using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emotible.Models.DataModels;

namespace Emotible.Models.ViewModels
{
    public class SearchBoxFlyoutViewModel : BaseViewModel
    {
        private string suggestionText;
        private string searchText;
        private ObservableCollection<EmoteViewModel> selectedNames;
        private ObservableCollection<EmoteViewModel> availableEmotes;

        public string SuggestionText
        {
            get { return suggestionText; }
            set
            {
                if (suggestionText != value)
                {
                    suggestionText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<EmoteViewModel> SelectedNames
        {
            get { return selectedNames; }
            set
            {
                if (selectedNames != value)
                {
                    selectedNames = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<EmoteViewModel> AvailableEmotes
        {
            get { return availableEmotes; }
            set
            {
                if (availableEmotes != value)
                {
                    availableEmotes = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
