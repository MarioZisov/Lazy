using Lazy.Core.ViewModels.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy.Core.ViewModels.DesignModels
{
    public class ElementDesignModel : ElementViewModel
    {
        public static ElementDesignModel Instance => new ElementDesignModel();

        public ElementDesignModel()
        {
            this.ElementID = "123456";
            this.Name = "Име на заданието, фикса или грешката";
            this.Status = Enums.ElementStatus.Developing;
        }
    }
}
