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

namespace Formatting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormattingView : Page
    {
        public FormattingView()
        {
            this.InitializeComponent();
        }

        private void languages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedLang = languages.SelectedValue.ToString();
            if (Windows.Globalization.Language.IsWellFormed(selectedLang))
            {
                sfCalendarDatePicker.Language = selectedLang;
            }
        }

        private void Blockout_ItemPrepared(object sender, Syncfusion.UI.Xaml.Calendar.CalendarItemPreparedEventArgs e)
        {
            if (e.ItemInfo.ItemType == CalendarItemType.Day &&
                (e.ItemInfo.Date.DayOfWeek == DayOfWeek.Saturday ||
                e.ItemInfo.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                e.ItemInfo.IsBlackout = true;
            }
        }
    }
}
