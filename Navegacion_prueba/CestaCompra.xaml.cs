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
using Windows.UI.Xaml.Media.Animation;
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
            for (int i = 0; i < MainPage.Carrito.Count; i++)
            {
                uc1 = new UCcarrito(MainPage.Carrito.ElementAt(i));
                uc1.Margin = new Thickness(0, 10, 0, 10);
                uc1.Added = true;
                listView.Items.Add(uc1);
                MainPage.sumaCompra();

            }

            if (MainPage.Carrito.Count == 0)
            {
                txtTotal.Text = "Total: 0.0 euros.";
            }
            else
            {
                txtTotal.Text = "Total: " + MainPage.Total + " euros.";
            }
        }

        private void irInicio(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        /* private void sumaCompra(double p)
         {
             double total = 0.0;

             for (int i = 0; i < MainPage.Carrito.Count; i++)
             {
                 total += p;
                 txtTotal.Text = "Total: " + total + " euros.";
             }
         }*/


        private void Pagar(object sender, RoutedEventArgs e) {

            if (MainPage.Carrito.Count == 0)
            {
                DisplayNoPagoDialog();
            }
            else
            {
                DisplayPagoDialog();
            }
            
        }

        private async void DisplayPagoDialog()
        {
            ContentDialog PagoDialog = new ContentDialog
            {
                Title = "Pago realizado",
                Content = "¡Su compra ha sido realizada con éxito!",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await PagoDialog.ShowAsync();
            listView.Items.Clear();
            MainPage.clearList();
            txtTotal.Text = "Total: ";
        }

        private async void DisplayNoPagoDialog()
        {
            ContentDialog noPagoDialog = new ContentDialog
            {
                Title = "Carrito vacío",
                Content = "¡Ups! Parece que no hay nada en la cesta.",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noPagoDialog.ShowAsync();
            
        }

        private void limpiarCesta(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
            MainPage.clearList();
            txtTotal.Text = "Total: 0.0 euros.";
        }

        private void animacionGiro(object sender, PointerRoutedEventArgs e)
        {

            Storyboard sbaux = (Storyboard)this.Resources["giroLogo0"];
            sbaux.Begin();
        }
    }

    
}
