using Lazy.Core.Enums;
using Lazy.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Core.ViewModels.UserControls
{
    public class StatusItemViewModel : BaseViewModel
    {
        public ElementStatus Status { get; set; }
    }
}
