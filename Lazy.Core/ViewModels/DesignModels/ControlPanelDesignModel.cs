namespace Lazy.Core.ViewModels.DesignModels
{
    using Lazy.Core.ViewModels.UserControls;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ControlPanelDesignModel : ControlPanelViewModel
    {
        public static ControlPanelDesignModel Instane => new ControlPanelDesignModel();

        public ControlPanelDesignModel()
        {
            base.Elements = new List<ElementViewModel>
            {
                new ElementViewModel
                {
                    ElementID = "123456",
                    Name = "Масово прехвърляне на случаи",
                    Status = Enums.ElementStatus.Awaiting,
                },

                new ElementViewModel
                {
                    ElementID = "123678",
                    Name = "Автоматизация за перхвърляне на агенти",
                    Status = Enums.ElementStatus.Developing,
                },

                new ElementViewModel
                {
                    ElementID = "123890",
                    Name = "Оптимизация на база данни",
                    Status = Enums.ElementStatus.Free,
                },
            };
        }
    }
}
