using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Calendar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PresetItems
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PresetItemsView : Page
    {
        public PresetItemsView()
        {
            this.InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            DateTimeOffset todayDate = DateTimeOffset.Now;

            if (listBox.SelectedItem.ToString() == "This Week")
            {
                DateTimeOffset startdate = todayDate.AddDays(-(todayDate.DayOfWeek - sfCalendarDateRangePicker.FirstDayOfWeek));
                sfCalendarDateRangePicker.SelectedRange = new DateTimeOffsetRange(startdate, startdate.AddDays(6));
            }
            else if (listBox.SelectedItem.ToString() == "This Month")
            {
                DateTimeOffset startdate = todayDate.AddDays(-(todayDate.Date.Day - 1));
                int daysToAdd = DateTime.DaysInMonth(startdate.Year, startdate.Month) - 1;
                DateTimeOffset lastDateInMonth = startdate.AddDays(daysToAdd);
                sfCalendarDateRangePicker.SelectedRange = new DateTimeOffsetRange(startdate, lastDateInMonth);
            }
            else if (listBox.SelectedItem.ToString() == "Last Month")
            {
                DateTimeOffset startdate = todayDate.AddMonths(-1).AddDays(-(todayDate.Date.Day - 1));
                int daysToAdd = DateTime.DaysInMonth(startdate.Year, startdate.Month) - 1;
                DateTimeOffset lastDateInMonth = startdate.AddDays(daysToAdd);
                sfCalendarDateRangePicker.SelectedRange = new DateTimeOffsetRange(startdate, lastDateInMonth);
            }
            else if (listBox.SelectedItem.ToString() == "This Year")
            {
                DateTimeOffset startdate = todayDate.AddMonths(-(todayDate.Month - 1)).AddDays(-(todayDate.Date.Day - 1));
                int daysToAdd = DateTime.DaysInMonth(startdate.Year, startdate.Month) - 1;
                DateTimeOffset lastDateInLastMonth = startdate.AddMonths(11).AddDays(daysToAdd);
                sfCalendarDateRangePicker.SelectedRange = new DateTimeOffsetRange(startdate, lastDateInLastMonth);
            }
            else
            {
                sfCalendarDateRangePicker.SelectedRange = null;
            }
        }
    }
}
