namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.Enums;
    using Lazy.Core.IoCContainer;
    using Lazy.Core.ViewModels.Base;
    using System;
    using System.Windows.Input;

    public class ControlBarViewModel : BaseViewModel
    {
        public ControlBarViewModel()
        {
            this.OpenAssignmentsCommand = new RelayCommand(() => OpenAssignments());
            this.OpenFixesCommand = new RelayCommand(() => OpenFixes());
            this.OpenBugsCommand = new RelayCommand(() => OpenBugs());
            this.OpenOthersCommand = new RelayCommand(() => OpenOthers());
        }

        public ICommand OpenAssignmentsCommand { get; set; }

        public ICommand OpenFixesCommand { get; set; }

        public ICommand OpenBugsCommand { get; set; }

        public ICommand OpenOthersCommand { get; set; }

        public bool AssignmentsSelected { get; set; }

        public bool FixsesSelected { get; set; }

        public bool BugsSelected { get; set; }

        public bool OthersSelected { get; set; }

        //TODO: Implement functionality to improve the sh*ts below
        public void OpenAssignments()
        {
            this.AssignmentsSelected = !this.AssignmentsSelected;
            this.FixsesSelected = false;
            this.BugsSelected = false;
            this.OthersSelected = false;

            if (this.AssignmentsSelected)
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.Assignments;
            else
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.None;
        }

        public void OpenFixes()
        {
            this.FixsesSelected = !this.FixsesSelected;
            this.AssignmentsSelected = false;
            this.BugsSelected = false;
            this.OthersSelected = false;

            if (this.FixsesSelected)
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.Fixes;
            else
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.None;
            
        }

        public void OpenBugs()
        {
            this.BugsSelected = !this.BugsSelected;
            this.AssignmentsSelected = false;
            this.FixsesSelected = false;
            this.OthersSelected = false;

            if (this.BugsSelected)
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.Bugs;
            else
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.None;
        }

        public void OpenOthers()
        {
            this.OthersSelected = !this.OthersSelected;
            this.AssignmentsSelected = false;
            this.FixsesSelected = false;
            this.BugsSelected = false;

            if (this.OthersSelected)
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.Others;
            else
                IoC.Get<ApplicationViewModel>().ContainerContent = ContainerContentType.None;
        }

        private void DeselectAll()
        {
            this.OthersSelected = false;
            this.AssignmentsSelected = false;
            this.FixsesSelected = false;
            this.BugsSelected = false;
        }
    }
}
