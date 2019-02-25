using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MultiValueConverter
{
    public class NameMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int day = 1;
            int month = 1;
            int year = 1;

            int.TryParse(values[0].ToString(), out day);
            int.TryParse(values[1].ToString(), out month);
            int.TryParse(values[2].ToString(), out year);

            if (day == 0)
                day = 1;
            if (month == 0)
                month = 1;
            if (year == 0)
                year = 1;

            try
            {
                var result = new DateTime(year, month, day);
                return String.Concat(result.Date);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                return argumentOutOfRangeException.Message;
            }      
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value as string).Split(' ');
        }
    }
}
