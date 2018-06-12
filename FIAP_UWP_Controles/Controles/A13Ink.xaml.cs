using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAP_UWP_Controles.Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class A13Ink : Page
    {
        public A13Ink()
        {
            this.InitializeComponent();

            inkCanvas.InkPresenter.InputDeviceTypes =
                Windows.UI.Core.CoreInputDeviceTypes.Mouse |
                Windows.UI.Core.CoreInputDeviceTypes.Pen |
                Windows.UI.Core.CoreInputDeviceTypes.Touch;
        }

        async void OnSaveAsync(object sender, RoutedEventArgs e)
        {
            if (inkCanvas.InkPresenter.StrokeContainer.GetStrokes().Count > 0)
            {
                var savePicker = new FileSavePicker();
                savePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
                savePicker.FileTypeChoices.Add("Gif with embedded ISF", new[] { ".gif" });

                StorageFile file = await savePicker.PickSaveFileAsync();

                if (file != null)
                {
                    using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        stream.Size = 0;

                        await inkCanvas.InkPresenter.StrokeContainer.SaveAsync(stream);
                    }
                }
            }
            else
            {
                //Não tem nenhum desenho;
            }
        }

        async void OnLoadAsync(object sender, RoutedEventArgs e)
        {
            var openPicker = new FileOpenPicker();
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".gif");
            openPicker.FileTypeFilter.Add(".isf");

            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                using (var stream = await file.OpenSequentialReadAsync())
                {
                    await inkCanvas.InkPresenter.StrokeContainer.LoadAsync(stream);
                }
            }
        }

        async void OnCustomDialog1(object sender, RoutedEventArgs e)
        {
            A14ContentDialogControl dialog = new A14ContentDialogControl();

            dialog.Image = new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png"));

            await dialog.ShowAsync();
        }

        async void OnCustomDialog2(object sender, RoutedEventArgs e)
        {
            A14ContentDialogControl dialog = new A14ContentDialogControl();

            dialog.Image = new BitmapImage(new Uri("ms-appx:///Assets/SplashScreen.scale-200.png"));

            await dialog.ShowAsync();
        }
    }
}
