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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navegacion_prueba
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Pizzas : Page
    {

        public Pizzas()
        {
            ProductosApp z1 = new ProductosApp("Margarita", "Ingredientes: sobre nuestra masa de la casa se incluye tomate, mozzarella y orégano.", 7.50, "ms-appx:///Assets/pizzamargarita.png");
            UControlProducto uc1 = new UControlProducto(z1);
            uc1.Height = 250;
            uc1.Width = 250;
            uc1.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp z2 = new ProductosApp("4 quesos", "Ingredientes: sobre nuestra masa de la casa se incluye 4 quesos importados de diferentes nacionalidades.", 9.50, "ms-appx:///Assets/pizza4quesos.png");
            UControlProducto uc2 = new UControlProducto(z2);
            uc2.Height = 250;
            uc2.Width = 250;
            uc2.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp z3 = new ProductosApp("Cabramelizada", "Ingredientes: sobre nuestra masa de la casa ponemos delicioso quesos de cabra junto con cebolla caramelizada.", 9.50, "ms-appx:///Assets/pizzacabramlizada.jpg");
            UControlProducto uc3 = new UControlProducto(z3);
            uc3.Height = 250;
            uc3.Width = 250;
            uc3.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp z4 = new ProductosApp("Carbonara", "Ingredientes: sobre nuestra masa de la casa incluimos una mezcla de nata, champiñones y bacon.", 8.50, "ms-appx:///Assets/pizzacarbonara.png");
            UControlProducto uc4 = new UControlProducto(z4);
            uc4.Height = 250;
            uc4.Width = 250;
            uc4.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp z5 = new ProductosApp("Barbacoa", "Ingredientes: sobre nuestra masa de la casa incluimos un conjunto de carnes que se compone de bacon, jamon, pollo y por encima salsa de barbacoa.", 10.00, "ms-appx:///Assets/pizzaBarbacoa.png");
            UControlProducto uc5 = new UControlProducto(z5);
            uc5.Height = 250;
            uc5.Width = 250;
            uc5.Margin = new Thickness(10, 10, 10, 10);

            ProductosApp z6 = new ProductosApp("Campiña", "Ingredientes: sobre nuestra masa de la casa incluimos una mezcla de verdura para crear una pizzas más fresca.", 8.00, "ms-appx:///Assets/pizzacampina.png");
            UControlProducto uc6 = new UControlProducto(z6);
            uc6.Height = 250;
            uc6.Width = 250;
            uc6.Margin = new Thickness(10, 10, 10, 10);


            this.InitializeComponent();

            gridView.Items.Add(uc1);
            gridView.Items.Add(uc2);
            gridView.Items.Add(uc3);
            gridView.Items.Add(uc4);
            gridView.Items.Add(uc5);
            gridView.Items.Add(uc6);
        }

        private void irCesta3(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio3(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        private void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var producto = (UControlProducto)e.ClickedItem;

            Frame.Navigate(typeof(PaginaDetalle), producto);
        }

        private void animacionLogo(object sender, PointerRoutedEventArgs e)
        {

            Storyboard sbaux = (Storyboard)this.Resources["giroLogo8"];
            sbaux.Begin();
        }
    }
}
