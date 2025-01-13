using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

// Converter 어떤 데이터를 View에 보여질 때만 변경 시켜서 보이지게 하는 것
namespace MyFirstWPFApp.Converters
{
    public class BoolToGender : IValueConverter
    {
        // ViewModel -> View
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool boolean))
            {
                // DependencyProperty.UnsetValue 바인딩 시, 값이 잘못된 값일 때 반환값 설정이 되어있다면, 설정된 값으로 반환시키는 역할
                return DependencyProperty.UnsetValue;
            }

            return boolean ? "남자" : "여자";
        }

        // View -> ViewModel
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
