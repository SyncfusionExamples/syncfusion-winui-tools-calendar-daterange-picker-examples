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
   public class CalendarDateRangePickerViewModel : NotificationObject
    {
        private string formatString = "{0:d}-{1:d}";
        private string dateFormat = "Abbreviated";
        private string monthFormat = "Abbreviated";
        private string dayOfWeekFormat = "Abbreviated - 3 char";
        private string headerFormatInMonthView = "Full";
        private string calendarIdentifier = "GregorianCalendar";
        private FlowDirection flowDirection = FlowDirection.LeftToRight;

        public List<LanguageList.Language> Languages { get; set; }
        public ObservableCollection<string> Items { get; set; }

        public string DateFormat
        {
            get
            {
                return dateFormat;
            }
            set
            {
                if (dateFormat != value)
                {
                    dateFormat = value;
                    this.RaisePropertyChanged(nameof(this.DateFormat));
                }
            }
        }

        public string FormatString
        {
            get
            {
                return formatString;
            }
            set
            {
                if (formatString != value)
                {
                    formatString = value;
                    this.RaisePropertyChanged(nameof(this.FormatString));
                }
            }
        }

        public FlowDirection FlowDirection
        {
            get
            {
                return flowDirection;
            }
            set
            {
                if (flowDirection != value)
                {
                    flowDirection = value;
                    this.RaisePropertyChanged(nameof(this.FlowDirection));
                }
            }
        }
        public string CalendarIdentifier
        {
            get
            {
                return calendarIdentifier;
            }
            set
            {
                if (calendarIdentifier != value)
                {
                    calendarIdentifier = value;
                    this.RaisePropertyChanged(nameof(this.CalendarIdentifier));
                }
            }
        }

        public string MonthFormat
        {
            get
            {
                return monthFormat;
            }
            set
            {
                if (monthFormat != value)
                {
                    monthFormat = value;
                    this.RaisePropertyChanged(nameof(this.MonthFormat));
                }
            }
        }

        public string DayOfWeekFormat
        {
            get
            {
                return dayOfWeekFormat;
            }
            set
            {
                if (dayOfWeekFormat != value)
                {
                    dayOfWeekFormat = value;
                    this.RaisePropertyChanged(nameof(this.DayOfWeekFormat));
                }
            }
        }

        public string HeaderFormatInMonthView
        {
            get
            {
                return headerFormatInMonthView;
            }
            set
            {
                if (headerFormatInMonthView != value)
                {
                    headerFormatInMonthView = value;
                    this.RaisePropertyChanged(nameof(this.HeaderFormatInMonthView));
                }
            }
        }

        public CalendarDateRangePickerViewModel()
        {
            Items = new ObservableCollection<string>();
            Items.Add("JulianCalendar");
            Items.Add("GregorianCalendar");
            Items.Add("HebrewCalendar");
            Items.Add("HijriCalendar");
            Items.Add("JapaneseCalendar");
            Items.Add("KoreanCalendar");
            Items.Add("TaiwanCalendar");
            Items.Add("UmAlQuraCalendar");
            Items.Add("PersianCalendar");

            var lang = new LanguageList();
            Languages = lang.Languages;
        }
    }

    public class LanguageList
    {
        private List<Language> _languages;
        public List<Language> Languages
        {
            get { return _languages; }
        }

        public LanguageList()
        {
            if (_languages == null)
            {
                _languages = new List<Language>();
            }

            _languages.Add(new Language("English", "en"));
            _languages.Add(new Language("Arabic", "ar"));
            _languages.Add(new Language("Afrikaans", "af"));
            _languages.Add(new Language("Albanian", "sq"));
            _languages.Add(new Language("Amharic", "am"));
            _languages.Add(new Language("Armenian", "hy"));
            _languages.Add(new Language("Assamese", "as"));
            _languages.Add(new Language("Azerbaijani", "az"));
            _languages.Add(new Language("Basque ", "eu"));
            _languages.Add(new Language("Belarusian", "be"));
            _languages.Add(new Language("Bangla", "bn"));
            _languages.Add(new Language("Bosnian", "bs"));
            _languages.Add(new Language("Bulgarian", "bg"));
            _languages.Add(new Language("Catalan", "ca"));
            _languages.Add(new Language("Chinese (Simplified)", "zh"));
            _languages.Add(new Language("Croatian", "hr"));
            _languages.Add(new Language("Czech", "cs"));
            _languages.Add(new Language("Danish", "da"));
            _languages.Add(new Language("Dari", "prs"));
            _languages.Add(new Language("Dutch", "nl"));
            _languages.Add(new Language("Estonian", "et"));
            _languages.Add(new Language("Filipino", "fil"));
            _languages.Add(new Language("Finnish", "fi"));
            _languages.Add(new Language("French ", "fr"));
            _languages.Add(new Language("Galician", "gl"));
            _languages.Add(new Language("Georgian", "ka"));
            _languages.Add(new Language("German", "de"));
            _languages.Add(new Language("Greek", "el"));
            _languages.Add(new Language("Gujarati", "gu"));
            _languages.Add(new Language("Hausa", "ha"));
            _languages.Add(new Language("Hebrew", "he"));
            _languages.Add(new Language("Hindi", "hi"));
            _languages.Add(new Language("Hungarian", "hu"));
            _languages.Add(new Language("Icelandic", "is"));
            _languages.Add(new Language("Indonesian", "id"));
            _languages.Add(new Language("Irish", "ga"));
            _languages.Add(new Language("isiXhosa", "xh"));
            _languages.Add(new Language("isiZulu", "zu"));
            _languages.Add(new Language("Italian", "it"));
            _languages.Add(new Language("Japanese ", "ja"));
            _languages.Add(new Language("Kannada", "kn"));
            _languages.Add(new Language("Kazakh", "kk"));
            _languages.Add(new Language("Khmer", "km"));
            _languages.Add(new Language("Kinyarwanda", "rw"));
            _languages.Add(new Language("KiSwahili", "sw"));
            _languages.Add(new Language("Konkani", "kok"));
            _languages.Add(new Language("Korean", "ko"));
            _languages.Add(new Language("Lao", "lo"));
            _languages.Add(new Language("Latvian", "lv"));
            _languages.Add(new Language("Lithuanian", "lt"));
            _languages.Add(new Language("Luxembourgish", "lb"));
            _languages.Add(new Language("Macedonian", "mk"));
            _languages.Add(new Language("Malay", "ms"));
            _languages.Add(new Language("Malayalam", "ml"));
            _languages.Add(new Language("Maltese", "mt"));
            _languages.Add(new Language("Maori ", "mi"));
            _languages.Add(new Language("Marathi", "mr"));
            _languages.Add(new Language("Nepali", "ne"));
            _languages.Add(new Language("Norwegian", "nb"));
            _languages.Add(new Language("Odia", "or"));
            _languages.Add(new Language("Persian", "fa"));
            _languages.Add(new Language("Polish", "pl"));
            _languages.Add(new Language("Portuguese", "pt"));
            _languages.Add(new Language("Punjabi", "pa"));
            _languages.Add(new Language("Quechua", "quz"));
            _languages.Add(new Language("Romanian", "ro"));
            _languages.Add(new Language("Russian", "ru"));
            _languages.Add(new Language("Serbian (Latin)", "sr"));
            _languages.Add(new Language("Sesotho sa Leboa", "nso"));
            _languages.Add(new Language("Setswana", "tn"));
            _languages.Add(new Language("Sinhala", "si"));
            _languages.Add(new Language("Slovak ", "sk"));
            _languages.Add(new Language("Slovenian", "sl"));
            _languages.Add(new Language("Spanish", "es"));
            _languages.Add(new Language("Swedish", "sv"));
            _languages.Add(new Language("Tamil", "ta"));
            _languages.Add(new Language("Telugu", "te"));
            _languages.Add(new Language("Thai", "th"));
            _languages.Add(new Language("Tigrinya", "ti"));
            _languages.Add(new Language("Turkish", "tr"));
            _languages.Add(new Language("Ukrainian", "uk"));
            _languages.Add(new Language("Urdu", "ur"));
            _languages.Add(new Language("Uzbek (Latin)", "uz"));
            _languages.Add(new Language("Vietnamese", "vi"));
            _languages.Add(new Language("Welsh", "cy"));
            _languages.Add(new Language("Wolof", "wo"));
        }

        public class Language
        {
            public string Name { get; set; }
            public string Code { get; set; }

            public Language(string name, string code)
            {
                this.Name = name;
                this.Code = code;
            }
        }
    }
}
