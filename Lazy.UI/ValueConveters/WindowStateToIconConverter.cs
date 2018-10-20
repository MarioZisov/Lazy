namespace Lazy.UI.ValueConveters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// Converts the <see cref="WindowState"/> to corresponding icon
    /// </summary>
    public class WindowStateToIconConverter : BaseValueConverter<WindowStateToIconConverter>
    {
        /// <summary>
        /// Represents maximize window button icon as vector
        /// </summary>
        private readonly Geometry WindowMaximize = Geometry.Parse("M4,4H20V20H4V4M6,8V18H18V8H6Z");

        /// <summary>
        /// Represents restore window button icon as vector
        /// </summary>
        private readonly Geometry WindowRestore = Geometry.Parse("M4,8H8V4H20V16H16V20H4V8M16,8V14H18V6H10V8H16M6,12V18H14V12H6Z");

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((WindowState)value)
            {
                case WindowState.Maximized:
                    return WindowRestore;
                case WindowState.Normal:
                    return WindowMaximize;
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
