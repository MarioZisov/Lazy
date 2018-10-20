namespace Lazy.Core.ViewModels.Base
{
    using Lazy.Core.Enums;
    using Lazy.Core.ViewModels.UserControls;
    using System;

    public class ApplicationViewModel : BaseViewModel
    {
        private ContainerContentType containerContent = ContainerContentType.None;
        public ContainerContentType ContainerContent
        {
            get { return this.containerContent; }
            set
            {
                //if (this.containerContent == value)
                //    this.containerContent = ContainerContentType.None;
                //else
                    this.containerContent = value;
            }
        }

        public bool IsContainerVisible
        {
            get { return containerContent != ContainerContentType.None; }
        }

        public ElementDetailsViewModel ElementDetails { get; set; }

        public bool AreDetailsVisible
        {
            get { return this.ElementDetails != null; }
        }
    }
}
