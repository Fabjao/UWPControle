using FIAP_UWP_Controles.Controles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FIAP_UWP_Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            switch (((Button)sender).Tag)
            {
                case "A0ButtonTextbox":
                    Frame.Navigate(typeof(A0ButtonTextbox));
                    break;
                case "A1AppBar":
                    Frame.Navigate(typeof(A1AppBar));
                    break;
                case "A2Lists":
                    Frame.Navigate(typeof(A2Lists));
                    break;
                case "A5PickerControls":
                    Frame.Navigate(typeof(A5PickerControls));
                    break;
                case "A6Dialogs":
                    Frame.Navigate(typeof(A6Dialogs));
                    break;
                case "A7Flyout":
                    Frame.Navigate(typeof(A7Flyout));
                    break;
                case "A8MenuFlyout":
                    Frame.Navigate(typeof(A8MenuFlyout));
                    break;
                case "A9ColorPicker":
                    Frame.Navigate(typeof(A9ColorPicker));
                    break;
                case "A13Ink":
                    Frame.Navigate(typeof(A13Ink));
                    break;
                case "A14ContentDialogControl":
                    Frame.Navigate(typeof(A14ContentDialogControl));
                    break;
                case "A15UserControl":
                    Frame.Navigate(typeof(A15UserControl));
                    break;
            }
        }
    }
}