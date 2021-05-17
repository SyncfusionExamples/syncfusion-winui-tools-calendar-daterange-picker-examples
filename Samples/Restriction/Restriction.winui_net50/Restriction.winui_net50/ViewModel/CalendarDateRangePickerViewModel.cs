using Syncfusion.UI.Xaml.Calendar;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restriction
{
    class CalendarDateRangePickerViewModel : NotificationObject
    {
        private DateTimeOffset minDate = new DateTimeOffset(new DateTime(2000, 1, 1));
        private DateTimeOffset maxDate = new DateTimeOffset(new DateTime(3000, 1, 1));
        private DateTimeOffsetRange selectedDateRange = new DateTimeOffsetRange(new DateTimeOffset(DateTime.Now), new DateTimeOffset(DateTime.Now.AddDays(1)));
        private CalendarDisplayMode minDisplayMode = CalendarDisplayMode.Month;
        private CalendarDisplayMode maxDisplayMode = CalendarDisplayMode.Century;
        public CalendarDisplayMode MinDisplayMode
        {
            get { return minDisplayMode; }
            set
            {
                if (value != minDisplayMode)
                {
                    minDisplayMode = value;
                    if (maxDisplayMode < minDisplayMode)
                    {
                        MaxDisplayMode = minDisplayMode;
                    }
                    RaisePropertyChanged(nameof(MinDisplayMode));
                }
            }
        }

        public CalendarDisplayMode MaxDisplayMode
        {
            get { return maxDisplayMode; }
            set
            {
                if (value != maxDisplayMode)
                {
                    maxDisplayMode = value;
                    if (minDisplayMode > maxDisplayMode)
                    {
                        MinDisplayMode = maxDisplayMode;
                    }
                    RaisePropertyChanged(nameof(MaxDisplayMode));
                }
            }
        }
        public DateTimeOffset MinDate
        {
            get
            {
                return minDate;
            }
            set
            {
                minDate = value;
                this.RaisePropertyChanged(nameof(this.MinDate));
            }
        }

        public DateTimeOffset MaxDate
        {
            get
            {
                return maxDate;
            }
            set
            {
                maxDate = value;
                this.RaisePropertyChanged(nameof(this.MaxDate));
            }
        }

        public DateTimeOffsetRange SelectedDateRange
        {
            get
            {
                return selectedDateRange;
            }
            set
            {
                if (selectedDateRange != value)
                {
                    selectedDateRange = value;
                    this.RaisePropertyChanged(nameof(this.SelectedDateRange));
                }
            }
        }
    }
}
