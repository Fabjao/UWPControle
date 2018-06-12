using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAP_UWP_Controles.Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class A8MenuFlyout : Page
    {
        public A8MenuFlyout()
        {
            this.InitializeComponent();
        }
        private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
        {
            if(rectangleColor.Color == Colors.Red)
            {
                rectangleColor.Color = Colors.Blue;
            }
            else
            {
                rectangleColor.Color = Colors.Red;
            }
        }
        
    }
}
