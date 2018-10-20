namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.Enums;
    using Lazy.Core.ViewModels.Base;
    using Lazy.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class ElementDetailsViewModel : BaseViewModel
    {
        private static List<StatusItemViewModel> statusItems;

        public int ID { get; set; }

        public ElementStatus Status
        {
            get { return (ElementStatus)this.SelectedIndex; }
            set { this.SelectedIndex = (int)value; }
        }

        public ElementType Type { get; set; }

        public string ElementID { get; set; }

        public string Name { get; set; }

        public string Directory { get; set; }

        public string URL { get; set; }

        public List<StatusItemViewModel> StatusItems
        {
            get
            {
                if (statusItems == null)
                    this.InitializeStatusItems();

                return statusItems;
            }
            protected set
            {
                statusItems = value;
            }
        }

        public StatusItemViewModel SelectedStatusItem { get; set; }

        public int SelectedIndex { get; set; }

        private void InitializeStatusItems()
        {
            statusItems = new List<StatusItemViewModel>
            {
                new StatusItemViewModel { Status = ElementStatus.None }
            };

            using (LazyEntities context = new LazyEntities())
            {
                context.Status
                       .ToList()
                       .ForEach(status =>
                        {
                            statusItems.Add(new StatusItemViewModel { Status = (ElementStatus)status.Id });
                        });
            }

            this.SelectedIndex = (int)this.Status;
        }
    }
}