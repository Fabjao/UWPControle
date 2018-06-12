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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FIAP_UWP_Controles.Controles
{
    public sealed partial class U15UserControl : UserControl
    {


        public string CampoTexto
        {
            get { return (string)GetValue(CampoTextoProperty); }
            set { SetValue(CampoTextoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CampoTexto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CampoTextoProperty =
            DependencyProperty.Register("CampoTexto", typeof(string), typeof(U15UserControl), new PropertyMetadata(""));



        public U15UserControl()
        {
            this.InitializeComponent();
        }
    }
}
