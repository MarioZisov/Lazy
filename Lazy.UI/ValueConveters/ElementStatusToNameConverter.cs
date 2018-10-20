using Lazy.Core.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.UI.ValueConveters
{
    class ElementStatusToNameConverter : BaseValueConverter<ElementStatusToNameConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ElementStatus)
            {
                return ((ElementStatus)value).ToString();
            }
            else
            {
                return "Unknown";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
