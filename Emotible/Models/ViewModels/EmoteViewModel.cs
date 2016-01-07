using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotible.Models.ViewModels
{
    public class EmoteViewModel : BaseViewModel
    {
        private string name;
        private string emoteText;
        private DateTime createdOn;
        private DateTime lastUsedOn;
        private int timesUsed;
        private string[] keywords;
        private DimensionsViewModel dimensions;
    }
}
