using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAP_UWP_Controles.Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class A6Dialogs : Page
    {
        public A6Dialogs()
        {
            this.InitializeComponent();
        }

        private async void Aviso_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                Title = "Aviso",
                Content = "Ocorreu um erro xpto",
                SecondaryButtonText = "OK"
            };

            await dialog.ShowAsync();
        }

        private async void Confirmacao_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                Title = "Confirmação",
                Content = "Você está prestes a excluir esse registro. Você confirma a exclusão?",
                PrimaryButtonText = "Sim",
                SecondaryButtonText = "Não",
            };

            dialog.PrimaryButtonClick += customDialog_PrimaryButtonClick;

            await dialog.ShowAsync();
        }

        private async void Custom_Click(object sender, RoutedEventArgs e)
        {
            await customDialog.ShowAsync();
        }

        private void customDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //todo
        }
    }
}
