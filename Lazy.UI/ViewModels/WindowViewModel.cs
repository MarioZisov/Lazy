namespace Lazy.UI.ViewModels
{
    using Lazy.Core.Enums;
    using Lazy.UI.Utils;
    using Lazy.Core.ViewModels.Base;
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    public class WindowViewModel : BaseViewModel
    {
        private Window window;
        private WindowResizer resizer;
        private WindowDockPosition dockPosition = WindowDockPosition.Undocked;

        public WindowViewModel(Window window)
        {
            this.window = window;

            this.window.StateChanged += (sender, e) =>
            {
                this.WindowResized();
            };

            this.MinimizeCommand = new RelayCommand(() => this.window.WindowState = WindowState.Minimized);
            this.MaximizeCommand = new RelayCommand(() => this.window.WindowState ^= WindowState.Maximized);
            this.CloseCommand = new RelayCommand(() => this.window.Close());

            resizer = new WindowResizer(window);
            resizer.WindowDockChanged += (dock) =>
            {
                this.dockPosition = dock;

                this.WindowResized();
            };
        }

        public ApplicationPage MainPage => ApplicationPage.Workspace;

        public double WindowMinimumHeight => 400;

        public double WindowMinimumWidth => 400;

        public int OuterMarginSize => this.Borderless() ? 0 : 10;

        public Thickness OutherMarginSizeThickness => new Thickness(OuterMarginSize);

        public double ResizeBorder => this.Borderless() ? 0 : 5;

        public Thickness ResizeBorderThickness => new Thickness(this.ResizeBorder + this.OuterMarginSize);

        public double CaptionHeight => 30;

        public GridLength TitleRowLenght => new GridLength(this.CaptionHeight + ResizeBorder);

        public int WindowRadius => this.Borderless() ? 0 : 5;

        public CornerRadius WindowCornerRadius => new CornerRadius(this.WindowRadius);

        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Dertmines whether the outer border should be cleared
        /// </summary>
        /// <returns>True if the window is docked or maximized</returns>
        private bool Borderless()
        {
            bool isDockedOrMaximized = this.window.WindowState == WindowState.Maximized || this.dockPosition != WindowDockPosition.Undocked;

            return isDockedOrMaximized;
        }

        private void WindowResized()
        {
            base.OnProperyChanged(nameof(ResizeBorderThickness));
            base.OnProperyChanged(nameof(OuterMarginSize));
            base.OnProperyChanged(nameof(OutherMarginSizeThickness));
            base.OnProperyChanged(nameof(TitleRowLenght));
            base.OnProperyChanged(nameof(WindowRadius));
            base.OnProperyChanged(nameof(WindowCornerRadius));
        }
    }
}