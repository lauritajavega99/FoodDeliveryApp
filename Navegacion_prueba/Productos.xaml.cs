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
using Windows.UI.Xaml.Media.Animation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodDeliveryApp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Productos : Page
    {

        public Productos()
        {
            this.InitializeComponent();


        }

        private void irInicio2(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irHamburguesas(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Hamburguesas));
        }

        private void irPizzas(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pizzas));
        }

        private void irEntrantes(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Entrantes));
        }

        private void irPostres(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Postres));
        }

        private void animacionGiro(object sender, PointerRoutedEventArgs e)
        {
            Storyboard sbaux = (Storyboard)this.Resources["Storyboard1"];
            sbaux.Begin();
        }
    }
}
