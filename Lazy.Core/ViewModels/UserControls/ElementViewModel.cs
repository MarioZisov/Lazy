namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.Enums;
    using Lazy.Core.IoCContainer;
    using Lazy.Core.ViewModels.Base;
    using System.Windows.Input;

    public class ElementViewModel : BaseViewModel
    {
        public ElementViewModel()
        {
            this.ClickCommand = new RelayCommand(() => Click());
            this.OpenDirectoryCommand = new RelayCommand(() => OpenDirctory());
            this.OpenUrlComand = new RelayCommand(() => OpenURL());
        }

        #region Public Properties

        public int ID { get; set; }

        public ElementStatus Status { get; set; }

        public ElementType Type { get; set; }

        public string ElementID { get; set; }

        public string Name { get; set; }

        public string Directory { get; set; }

        public string URL { get; set; }

        #endregion Public Properties

        #region Commands

        public ICommand ClickCommand { get; set; }

        public ICommand OpenDirectoryCommand { get; set; }

        public ICommand OpenUrlComand { get; set; }

        #endregion Commands

        public void Click()
        {
            IoC.Get<ApplicationViewModel>().ElementDetails = new ElementDetailsViewModel()
            {
                ID = this.ID,
                Status = this.Status,
                Type = this.Type,
                ElementID = this.ElementID,
                Name = this.Name,
                Directory = this.Directory,
                URL = this.URL,
            };
        }

        public void OpenDirctory()
        {
            //throw new NotImplementedException();
        }

        public void OpenURL()
        {
            //throw new NotImplementedException();
        }
    }
}
