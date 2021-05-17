using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresetItems
{
    public class CalendarDateRangePickerViewModel 
    {
        private ObservableCollection<string> presetCollection;

        public ObservableCollection<string> PresetCollection
        {
            get { return presetCollection; }
            set { presetCollection = value; }
        }

        public CalendarDateRangePickerViewModel()
        {
            PresetCollection = new ObservableCollection<string>();
            PresetCollection.Add("This Week");
            PresetCollection.Add("This Month");
            PresetCollection.Add("Last Month");
            PresetCollection.Add("This Year");
            PresetCollection.Add("Custom Range");
        }
    }
}
