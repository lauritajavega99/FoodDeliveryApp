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
    public sealed partial class UControlProducto : UserControl
    {
        private ProductosApp producto;

        public UControlProducto(ProductosApp p)
        {
            this.InitializeComponent();
            this.producto = p;
            this.txtNombreP.Text = p.Nombre;
            this.txtPrecioP.Text = Convert.ToString(p.Precio);
            this.imgProd.Source = p.Imagen.Source;
        }

        public String Nombretxt
        {
            get { return txtNombreP.Text; }
            set { txtNombreP.Text = value; }
        }

        public ProductosApp Prod
        {
            get { return producto; }
        }

        public String Preciotxt
        {
            get { return txtPrecioP.Text; }
            set { txtPrecioP.Text = value; }
        }

        public Image ImagenProd
        {
            get { return imgProd; }
            set { imgProd = value; }
        }

    }
}
