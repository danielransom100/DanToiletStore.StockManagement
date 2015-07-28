using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DanToiletStore.StockManagement.UI.Converter
{
    public class ImageConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(ImageSource))
                throw new Exception("Must be a Media Type");

            try
            {
                var img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("", UriKind.RelativeOrAbsolute);
                return img;

            }
            catch (Exception)
            {
                {
                    return DependencyProperty.UnsetValue;
                }
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
