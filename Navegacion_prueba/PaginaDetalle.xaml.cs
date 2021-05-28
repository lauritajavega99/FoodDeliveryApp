using FoodDeliveryApp;
using FoodDeliveryApp.Models;
using Newtonsoft.Json;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navegacion_prueba
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PaginaDetalle : Page
    {
        public ProductosApp producto;
        private bool aniadido = false;

        public PaginaDetalle()
        {
            this.InitializeComponent();
            
            
        }

        private void irCesta6(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CestaCompra));
        }

        private void irInicio6(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Inicio));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var param = (UControlProducto)e.Parameter;
            ucProducto.Nombretxt = param.Prod.Nombre;
            ucProducto.Descripciontxt = param.Prod.Descripcion;
            ucProducto.Preciotxt = Convert.ToString(param.Prod.Precio);
            ucProducto.ImagenProd.Source = param.Prod.Imagen.Source;
            
           
            base.OnNavigatedTo(e);
        }

        private void btnAniadirCarro_Click(object sender, RoutedEventArgs e)
        {
            producto = new ProductosApp(ucProducto.Nombretxt ,1, Convert.ToDouble(ucProducto.Preciotxt), false, ucProducto.ImagenProd);
            
            if (aniadido == false)
            {
                producto.Add = true;
                aniadido = true;
                MainPage.Carrito.Add(this.producto);
                MainPage.sumaCompra();
            }
            else
            {
                producto.Add = false;
                aniadido = false;

                var prod = MainPage.Carrito.SingleOrDefault(x => x.Nombre == this.producto.Nombre);

                if (prod != null)
                {
                    MainPage.Carrito.Remove(prod);
                }
            }

            

        }
    }
}
