using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotible.Models.DataModels
{
    public class EmoteDataModel
    {
        public string Name { get; set; }
        public string EmoteText { get; set; }
        public string[] Keywords { get; set; }

        public int TimesUsed { get; set; }
        public DateTime LastUsedOn { get; set; }
        public DateTime CreateOn { get; set; }
        public DimensionsDataModel Dimensions { get; set; }
    }
}
