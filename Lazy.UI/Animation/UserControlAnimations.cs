namespace Lazy.UI.Animation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;

    public static class UserControlAnimations
    {
        public static async Task SlideAndFadeInFromLeft(this UserControl userControl, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideFromLeft(seconds, 400);

            sb.AddFadeIn(seconds);

            sb.Begin(userControl);

            //userControl.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }

        public static async Task SlideAndFadeOutFromRight(this UserControl userControl, float seconds)
        {
            var sb = new Storyboard();

            sb.AddSlideToLeft(seconds, userControl.ActualWidth);

            sb.AddFadeOut(seconds);

            sb.Begin(userControl);

            //userControl.Visibility = Visibility.Visible;

            await Task.Delay((int)(seconds * 1000));
        }
    }
}
