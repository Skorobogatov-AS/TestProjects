using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_functionsTest.Converters
{
    class PowerToListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var power = (int)value;
            List<double> ret = new List<double>();
            for (int i = 1; i < 6; i++)
                ret.Add(i * Math.Pow(10, power - 1));
            return ret;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double ret;
            if (double.TryParse(value?.ToString(), out ret))
            {
                return ret;
            }
            return null;
        }
    }
}
