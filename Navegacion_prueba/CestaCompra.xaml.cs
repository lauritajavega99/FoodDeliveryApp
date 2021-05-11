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

namespace FoodDeliveryApp
{
   

    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class CestaCompra : Page
    {
        //Creamos la Lista de productos para el datagrid
        public List<Producto> Productos;

        public CestaCompra()
        {
            this.InitializeComponent();
            Productos = ValoresEjemplo.GetValores();
            sumaPrecio(Productos);

        }

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }


        private void sumaPrecio(List<Producto> listproductos)
        {
            double total = 0;

            foreach (Producto p in listproductos)
            {
                total += p.Precio;
            }

            txtTotal.Text = "Total: " + total + " euros.";
        }

        private void irAboutUS(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SobreNosotros));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgProductos.ItemsSource = null;

        }

        private void Pagar(object sender, RoutedEventArgs e)
        {
            DisplayNoWifiDialog();
        }

        private async void DisplayNoWifiDialog()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "Pago realizado",
                Content = "¡Su compra ha sido realizada con éxito!",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();

            dgProductos.ItemsSource = null;

        }
    }

    
}
