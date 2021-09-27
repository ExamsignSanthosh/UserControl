using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace NewSampleControl.converter_
{
    public class Conveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string v = value.ToString();
            return v + "%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

        public class WidthConveter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                int size = (int)value;
            return size;
            }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }


        }
  
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BrushConverter bc = new BrushConverter();


            if ((int)value > 75)
            {
                return bc.ConvertFrom("Green");
            }
            else if ((int)value >= 50 && (int)value < 75)
            {
                return bc.ConvertFrom("Blue");
            }
            else if ((int)value >= 35 && (int)value < 50)
            {
                return bc.ConvertFrom("Yellow");
            }
            else
            {
                return bc.ConvertFrom("Orange");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}