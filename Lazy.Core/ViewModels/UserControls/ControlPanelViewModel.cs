namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.ViewModels.Base;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class ControlPanelViewModel : BaseViewModel
    {
        public ControlPanelViewModel()
        {
            this.OpenAssignmentsCommand = new RelayCommand(() => OpenAssignments());
            this.OpenFixesCommand = new RelayCommand(() => OpenFixes());
            this.OpenBugsCommand = new RelayCommand(() => OpenBugs());
            this.OpenOthersCommand = new RelayCommand(() => OpenOthers());
        }

        public List<ElementViewModel> Elements { get; set; }

        public ICommand OpenAssignmentsCommand { get; set; }

        public ICommand OpenFixesCommand { get; set; }

        public ICommand OpenBugsCommand { get; set; }

        public ICommand OpenOthersCommand { get; set; }

        public void OpenAssignments()
        {
        }

        public void OpenFixes()
        {           
        }

        public void OpenBugs()
        {
            this.Elements = null;
        }

        public void OpenOthers()
        {
            this.Elements = null;
        }
    }
}
