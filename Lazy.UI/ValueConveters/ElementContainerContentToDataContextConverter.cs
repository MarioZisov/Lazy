namespace Lazy.UI.ValueConveters
{
    using Lazy.Core.Enums;
    using Lazy.Core.IoCContainer;
    using Lazy.Core.ViewModels.UserControls;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ElementContainerContentToDataContextConverter : BaseValueConverter<ElementContainerContentToDataContextConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ContainerContentType)value)
            {
                case ContainerContentType.Assignments:                     
                    return IoC.Get<AssignmentContainerViewModel>().Update();
                case ContainerContentType.Fixes:
                    return IoC.Get<FixContainerViewModel>().Update();
                case ContainerContentType.Bugs:
                    return IoC.Get<BugContainerViewModel>().Update();
                case ContainerContentType.Others:
                    return IoC.Get<OtherContainerViewModel>().Update();
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
