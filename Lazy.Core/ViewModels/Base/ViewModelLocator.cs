namespace Lazy.Core.ViewModels.Base
{
    using IoCContainer;
    using Lazy.Core.ViewModels.UserControls;

    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { get; } = new ViewModelLocator();

        public ApplicationViewModel ApplicationViewModel { get; } = IoC.Get<ApplicationViewModel>();
    }
}
