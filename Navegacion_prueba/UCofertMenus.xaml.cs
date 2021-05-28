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

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Navegacion_prueba
{
    public sealed partial class UCofertMenus : UserControl
    {
        private ProductosApp producto;
        private bool aniadido = false;

        public UCofertMenus(ProductosApp pro)
        {
            this.InitializeComponent();
            this.producto = pro;
            this.txtTit.Text = pro.Nombre;
            this.txtDesc.Text = pro.Descripcion;
            this.txtPrec.Text = Convert.ToString(pro.Precio) + "€";
            this.imgP.Source = pro.Imagen.Source;
            this.aniadido = pro.Add;
        }

        public String Nombretxt
        {
            get { return txtTit.Text; }
            set { txtTit.Text = value; }
        }

        public String Descriptxt
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public String Preciotxt
        {
            get { return txtPrec.Text; }
            set { txtPrec.Text = value; }
        }

        public Image ImagenProd
        {
            get { return imgP; }
            set { imgP = value; }
        }

        public bool Added
        {
            get { return aniadido; }
            set { aniadido = value; }
        }

        private void addCesta(object sender, RoutedEventArgs e)
        {
            if (aniadido == false)
            {
                producto.Add = true;
                aniadido = true;
                MainPage.Carrito.Add(this.producto);
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
