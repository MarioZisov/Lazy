using Lazy.Core.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Core.ViewModels.DesignModels
{
    public class ElementDetailsDesignModel : ElementDetailsViewModel
    {
        public static ElementDetailsDesignModel Instance { get; set; } = new ElementDetailsDesignModel();

        public ElementDetailsDesignModel()
        {
            this.Status = Enums.ElementStatus.Free;
            this.ElementID = "143647";
            this.Name = "Random Name Random Name Random Name Random Name";

            this.StatusItems = new List<StatusItemViewModel>
            {
                new StatusItemViewModel { Status = Enums.ElementStatus.Ready },
                new StatusItemViewModel { Status = Enums.ElementStatus.Free },
                new StatusItemViewModel { Status = Enums.ElementStatus.Developing },
            };

            this.SelectedStatusItem = this.StatusItems.First(x => x.Status == Enums.ElementStatus.Free);
        }
    }
}
