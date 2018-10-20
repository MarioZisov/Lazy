namespace Lazy.UI.ValueConveters
{
    using Lazy.Core.Enums;
    using System;
    using System.Globalization;
    using System.Windows.Media;

    public class ElementStatusToBrushConverter : BaseValueConverter<ElementStatusToBrushConverter>
    {
        private readonly SolidColorBrush orangeBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF7417"));
        private readonly SolidColorBrush yellowBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFD300"));
        private readonly SolidColorBrush greenBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#1DB954"));
        private readonly SolidColorBrush whiteBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF"));
        private readonly SolidColorBrush transperant = Brushes.Transparent;

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ElementStatus)value)
            {
                case ElementStatus.Free:
                    return whiteBrush;
                case ElementStatus.Ready:
                    return greenBrush;
                case ElementStatus.Developing:
                    return orangeBrush;
                case ElementStatus.Awaiting:
                    return yellowBrush;
                case ElementStatus.None:
                    return transperant;
                default:
                    throw new NotImplementedException();
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}