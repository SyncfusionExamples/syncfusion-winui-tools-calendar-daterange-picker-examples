using Syncfusion.UI.Xaml.Calendar;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restriction
{
    class CalendarDatePickerViewModel : NotificationObject
    {
        private DateTimeOffset minDate = new DateTimeOffset(new DateTime(2000, 1, 1));
        private DateTimeOffset maxDate = new DateTimeOffset(new DateTime(3000, 1, 1));
        private DateTimeOffset? selectedDate = new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
        private CalendarDisplayMode minDisplayMode = CalendarDisplayMode.Month;
        private CalendarDisplayMode maxDisplayMode = CalendarDisplayMode.Century;
        private OutOfScopeVisibility outOfScopeVisibility = OutOfScopeVisibility.Hidden;
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

        public OutOfScopeVisibility OutOfScopeVisibility
        {
            get
            {
                return outOfScopeVisibility;
            }
            set
            {
                outOfScopeVisibility = value;
                this.RaisePropertyChanged(nameof(this.OutOfScopeVisibility));

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

        public DateTimeOffset? SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    this.RaisePropertyChanged(nameof(this.SelectedDate));
                }
            }
        }
    }
}
