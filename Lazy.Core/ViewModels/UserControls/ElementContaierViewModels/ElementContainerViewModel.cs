namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.ViewModels.Base;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public abstract class ElementContainerViewModel : BaseViewModel
    {
        public List<ElementViewModel> Elements { get; set; }

        public abstract ElementContainerViewModel Update();
    }
}
