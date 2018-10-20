namespace Lazy.UI
{
    using Lazy.UI.ViewModels;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new WindowViewModel(this);
        }

        /// <summary>
        /// HACK!
        /// When the <see cref="elementContainer's"/> DataContext becomes null
        /// this method prevents fixing the width of the 
        /// <see cref="elementContainer's"/> column (<see cref="elementContainerColumn"/>) 
        /// by resizing it with <see cref="theSplitter"/>
        /// </summary>
        private void ElementsContainer_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //if (this.elementContainer.DataContext == null)
                this.elementContainerColumn.Width = new GridLength(0, GridUnitType.Auto);
        }
    }
}