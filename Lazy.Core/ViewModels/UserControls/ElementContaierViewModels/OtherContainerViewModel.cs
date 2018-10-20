namespace Lazy.Core.ViewModels.UserControls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OtherContainerViewModel : ElementContainerViewModel
    {
        public override ElementContainerViewModel Update()
        {
            this.Elements = new List<ElementViewModel>
            {
                new ElementViewModel
                {
                    ElementID = "123456",
                    Name = this.GetType().Name,
                    Status = Enums.ElementStatus.Awaiting,
                },
            };

            return this;
        }
    }
}
