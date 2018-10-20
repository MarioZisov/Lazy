namespace Lazy.UI.UserControls
{
    using Lazy.UI.Animation;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Controls;
    using System.Windows;
    using System.Windows.Media;

    public class AnimatedUserControl : UserControl
    {
        public AnimatedUserControl()
        {
            //if (this.LoadAnimation != UserControlAnimation.None)
            //    this.Visibility = Visibility.Collapsed;

            this.DataContextChanged += AnimatedUserControl_DataContextChanged;
        }

        public UserControlAnimation LoadAnimation { get; set; } = UserControlAnimation.SlideAndFadeInFromLeft;

        public UserControlAnimation UnloadAnimation { get; set; } = UserControlAnimation.SlideAndFadeOutFromRight;

        public float SlideSeconds { get; set; } = 2.7f;

        private async void AnimatedUserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.DataContext == null)
                await this.AnimateOut();
            else
                await this.AnimateIn();
        }

        public async Task AnimateIn()
        {
            if (this.LoadAnimation == UserControlAnimation.None)
                return;

            switch (this.LoadAnimation)
            {
                case UserControlAnimation.SlideAndFadeInFromLeft:

                    await this.SlideAndFadeInFromLeft(this.SlideSeconds);

                    break;
            }
        }

        public async Task AnimateOut()
        {
            if (this.LoadAnimation == UserControlAnimation.None)
                return;

            switch (this.UnloadAnimation)
            {
                case UserControlAnimation.SlideAndFadeOutFromRight:

                    await this.SlideAndFadeOutFromRight(this.SlideSeconds);

                    break;
            }
        }
    }
}
