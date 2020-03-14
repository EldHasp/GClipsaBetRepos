using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace GClipsaWPF
{
    public class NameToImageConverter : IValueConverter
    {

        Dictionary<String, String> Names = new Dictionary<string, string>()
        {
            {"nophoto","Image/nophoto.png" }
        };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Names[value.ToString()];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
