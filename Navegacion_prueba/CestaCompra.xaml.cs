using Navegacion_prueba;
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
        private UCcarrito uc1;

        public CestaCompra()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;


        }

        private void irCesta1(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            listView.Items.Clear();
            for(int i = 0; i<MainPage.Carrito.Count; i++)
            {
                uc1 = new UCcarrito(MainPage.Carrito.ElementAt(i));
                uc1.Margin = new Thickness(0, 10, 0, 10);
                uc1.Added = true;
                sumaCompra(MainPage.Carrito.ElementAt(i).Precio);
                listView.Items.Add(uc1);
            }
        }

        private void irInicio(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        private void sumaCompra(double p)
        {
            double total = 0.0;

            for (int i = 0; i < MainPage.Carrito.Count; i++)
            {
                total += p;
                txtTotal.Text = "Total: " + total + " euros.";
            }
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
            listView.Items.Clear();
            txtTotal.Text = "Total: ";
        }

        private void limpiarCesta(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            MainPage.clearList();
            txtTotal.Text = "Total: ";
        }
    }

    
}
