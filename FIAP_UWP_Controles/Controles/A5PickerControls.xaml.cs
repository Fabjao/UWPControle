using System;
using System.Collections.Generic;
using System.Globalization;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAP_UWP_Controles.Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class A5PickerControls : Page
    {
        public A5PickerControls()
        {
            this.InitializeComponent();
        }
    }
}


namespace FIAP_UWP_Controles.Controles.Converters5
{
    public class DateTimeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                var data = (DateTimeOffset)value;

                return data.ToString("dd/MM/yyyy");
            }
            catch
            {
                return "01/01/0001";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            try
            {
                return DateTimeOffset.ParseExact((string)value, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch 
            {
                return DateTimeOffset.MinValue;
            }
        }
    }
}

