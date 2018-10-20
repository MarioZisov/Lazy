namespace Lazy.Core.IoCContainer
{
    using Lazy.Core.ViewModels.Base;
    using Lazy.Core.ViewModels.UserControls;
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IoC
    {
        public static IKernel Kernel { get; } = new StandardKernel();

        public static void Setup()
        {
            BindViewModels();
        }

        private static void BindViewModels()
        {
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());

            Kernel.Bind<AssignmentContainerViewModel>().ToConstant(new AssignmentContainerViewModel());
            Kernel.Bind<FixContainerViewModel>().ToConstant(new FixContainerViewModel());
            Kernel.Bind<BugContainerViewModel>().ToConstant(new BugContainerViewModel());
            Kernel.Bind<OtherContainerViewModel>().ToConstant(new OtherContainerViewModel());
        }        

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}