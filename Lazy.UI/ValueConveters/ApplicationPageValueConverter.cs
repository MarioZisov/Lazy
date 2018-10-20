namespace Lazy.UI.ValueConveters
{
    using Lazy.Core.Enums;
    using Lazy.UI.Pages;
    using System;
    using System.Diagnostics;
    using System.Globalization;

    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Workspace:
                    return new MainPage();
                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
