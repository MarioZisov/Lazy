namespace Lazy.Core.ViewModels.UserControls
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FixContainerViewModel : ElementContainerViewModel
    {
        public override ElementContainerViewModel Update()
        {
            this.Elements = new List<ElementViewModel>
            {
                new ElementViewModel
                {
                    ElementID = "123456",
                    Name = this.GetType().Name,
                    Status = Enums.ElementStatus.Ready,
                },
            };

            return this;
        }
    }
}
