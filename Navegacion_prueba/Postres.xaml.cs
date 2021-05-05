using FoodDeliveryApp;
using FoodDeliveryApp.Models;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navegacion_prueba
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Postres : Page
    {
        private List<ProductosApp> pApp;

        public Postres()
        {
            this.InitializeComponent();
            pApp = GestionProducto.GetPostres();
        }

        private void irCesta2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irAboutUs2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }
    }
}
