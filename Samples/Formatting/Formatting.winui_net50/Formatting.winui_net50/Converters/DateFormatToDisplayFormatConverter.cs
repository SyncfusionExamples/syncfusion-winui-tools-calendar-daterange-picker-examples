using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    public class DateFormatToDisplayFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var option = value.ToString();
            var abb = "Abbreviated";
            var full = "Full";
            var num = "Number";


            switch (parameter.ToString())
            {
                case "day":
                    if (option == abb)
                    {
                        return "{day.integer}";
                    }
                    else if (option == full)
                    {
                        return "{day.integer(2)}";
                    }
                    break;

                case "month":
                    if (option == abb)
                    {
                        return "{month.abbreviated}";
                    }
                    else if (option == full)
                    {
                        return "{month.full}";
                    }
                    else if (option == num)
                    {
                        return "{month.integer}";
                    }
                    break;

                case "dayofweek":
                    if (option == "Abbreviated - 2 char")
                    {
                        return "{dayofweek.abbreviated(2)}";
                    }
                    else if (option == "Abbreviated - 3 char")
                    {
                        return "{dayofweek.abbreviated(3)}";
                    }
                    else if (option == "Full")
                    {
                        return "{dayofweek.full}";
                    }
                    break;

                case "header":
                    if (option == abb)
                    {
                        return "{month.abbreviated} {year.abbreviated}‎";
                    }
                    else if (option == full)
                    {
                        return "month year";
                    }
                    break;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
