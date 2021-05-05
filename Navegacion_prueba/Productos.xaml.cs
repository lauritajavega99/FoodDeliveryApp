using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FoodDeliveryApp.Models;
using Navegacion_prueba;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodDeliveryApp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Productos : Page
    {
        private List<ProductosApp> pApp;
        public Productos()
        {
            this.InitializeComponent();
            pApp = GestionProducto.GetTiposProductos();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var product = (ProductosApp)e.ClickedItem;

            switch (product.Nombre)
            {
                case "Hamburguesas":
                    this.Frame.Navigate(typeof(Hamburguesas));
                    break;
                case "Pizzas":
                    this.Frame.Navigate(typeof(Pizzas));
                    break;
                case "Entrantes":
                    this.Frame.Navigate(typeof(Entrantes));
                    break;
                case "Postres":
                    this.Frame.Navigate(typeof(Postres));
                    break;
            }

        }

        private void irAboutUs1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }
    }
}
