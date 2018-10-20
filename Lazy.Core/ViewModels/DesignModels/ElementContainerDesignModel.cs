using Lazy.Core.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Core.ViewModels.DesignModels
{
    public class ElementContainerDesignModel : ElementContainerViewModel
    {
        public static ElementContainerDesignModel Instance => new ElementContainerDesignModel();

        public ElementContainerDesignModel()
        {
            this.Elements = new List<ElementViewModel>
            {
                new ElementViewModel
                {
                    ElementID = "123456",
                    Name = "Масово прехвърляне на случаи",
                    Status = Enums.ElementStatus.Ready,
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

        public override ElementContainerViewModel Update()
        {
            throw new NotImplementedException();
        }
    }
}
