using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfApp7.ListFold
{
    public class WorkSubmitionDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parametr, CultureInfo culture)
        {
            if (value != null)
            {
                DateTime workSubDate = (DateTime)value;


                if (workSubDate == new DateTime(0001, 1, 1))
                {
                    return string.Empty;
                }
                else
                {
                    return workSubDate.ToString("dd.MM.yyyy");
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parametr, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}