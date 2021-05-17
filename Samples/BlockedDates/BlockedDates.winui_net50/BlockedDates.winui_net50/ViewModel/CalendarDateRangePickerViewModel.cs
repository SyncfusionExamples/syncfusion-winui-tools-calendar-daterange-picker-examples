using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockedDates
{
    class CalendarDateRangePickerViewModel : NotificationObject
    {
        private DateTimeOffsetCollection blackoutDates = new DateTimeOffsetCollection();
        public DateTimeOffsetCollection BlackoutDates
        {
            get
            {
                return blackoutDates;
            }
            set
            {
                if (blackoutDates != value)
                {
                    blackoutDates = value;
                    this.RaisePropertyChanged(nameof(this.BlackoutDates));
                }
            }
        }
        public CalendarDateRangePickerViewModel()
        {
            BlackoutDates = new DateTimeOffsetCollection();
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 17)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 4)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 5)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 9)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 11)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 14)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 18)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 19)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 22)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27)));
            BlackoutDates.Add(new DateTimeOffset(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 28)));
        }
    }
}
