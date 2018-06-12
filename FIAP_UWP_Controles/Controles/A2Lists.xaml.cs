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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FIAP_UWP_Controles.Controles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class A2Lists : Page
    {
        public A2Lists()
        {
            this.InitializeComponent();

            var lista = new List<string>()
            {
                "texto1",
                "texto2",
                "texto3",
                "texto4",
            };

            lista1.ItemsSource = lista;
            lista3.ItemsSource = lista;


            var novaLista = new List<Teste>()
            {
                new Teste { Nome = "Nome1" },
                new Teste { Nome = "Nome2" },
                new Teste { Nome = "Nome3" },
                new Teste { Nome = "Nome4" },
                new Teste { Nome = "Nome5" },
            };

            lista2.ItemsSource = novaLista;

        }

        public class Teste
        {
            public string Nome { get; set; }
        }
    }
}
