using Lazy.Core.Enums;
using Lazy.Core.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Core.ViewModels.DesignModels
{
    public class StatusItemDesignModel : StatusItemViewModel
    {
        public static StatusItemDesignModel Instance { get; set; } = new StatusItemDesignModel();

        public StatusItemDesignModel()
        {
            base.Status = ElementStatus.Ready;
        }
    }
}
