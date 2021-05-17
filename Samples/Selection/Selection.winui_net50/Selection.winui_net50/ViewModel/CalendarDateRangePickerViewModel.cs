using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class CalendarDateRangePickerViewModel : NotificationObject
    {
        private DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
        private UInt64 maxdaysCountInRange = 8;
        private UInt64 mindaysCountInRange = 4;
        private string placeHolderText = "No Date is Selected";

        public UInt64 MinDaysCountInRange
        {
            get
            {
                return mindaysCountInRange;
            }
            set
            {
                if (mindaysCountInRange != value)
                {
                    mindaysCountInRange = value;
                    this.RaisePropertyChanged(nameof(this.MinDaysCountInRange));
                }
            }
        }
        public UInt64 MaxDaysCountInRange
        {
            get
            {
                return maxdaysCountInRange;
            }
            set
            {
                if (maxdaysCountInRange != value)
                {
                    maxdaysCountInRange = value;
                    this.RaisePropertyChanged(nameof(this.MaxDaysCountInRange));
                }
            }
        }

        public string PlaceHolderText
        {
            get
            {
                return placeHolderText;
            }
            set
            {
                if (placeHolderText != value)
                {
                    placeHolderText = value;
                    this.RaisePropertyChanged(nameof(this.PlaceHolderText));
                }
            }
        }

        public DayOfWeek FirstDayOfWeek
        {
            get
            {
                return firstDayOfWeek;
            }
            set
            {
                firstDayOfWeek = value;
                this.RaisePropertyChanged(nameof(FirstDayOfWeek));
            }
        }

    }
}
