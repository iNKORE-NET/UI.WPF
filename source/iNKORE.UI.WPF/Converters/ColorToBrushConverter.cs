using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace iNKORE.UI.WPF.Converters
{
    [ValueConversion(typeof(Color), typeof(SolidColorBrush))]
    public class ColorToBrushConverter : IValueConverter
    {
        public bool FreezeBrushes { get; set; } = false;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Color color)
            {
                var brush = new SolidColorBrush(color);

                if(FreezeBrushes && brush.CanFreeze)
                {
                    brush.Freeze();
                }

                return brush;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush brush)
            {
                return brush.Color;
            }

            return null;
        }

        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    Color col = (Color)value;
        //    Color c = Color.FromArgb(col.A, col.R, col.G, col.B);
        //    return new SolidColorBrush(c);
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    SolidColorBrush c = (SolidColorBrush)value;
        //    Color col = Color.FromArgb(c.Color.A, c.Color.R, c.Color.G, c.Color.B);
        //    return col;
        //}

    }
}
