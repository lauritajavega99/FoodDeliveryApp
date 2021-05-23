using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
   public class ProductosApp
    {
        public String nombre;
        public String descripcion;
        public int cantidad;
        public double precio;
        public bool add;
        public Image imagen = new Image();
  
        public ProductosApp()
        {

        }

        public ProductosApp(String nombre, String descripcion, int cantidad, double precio, String pathImagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        //constructor productos
        public ProductosApp(String nombre, double precio, String pathImagen)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        //constructor detalle productos
        public ProductosApp(String nombre, String descripcion, double precio, String pathImagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        //constructor menus y ofertas
        public ProductosApp(String nombre,String descripcion, double precio, bool add, String pathImagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.add = add;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        //constructor carrito
        public ProductosApp(String nombre, int cantidad, double precio,bool add, String pathImagen)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.add = add;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        public ProductosApp(String nombre, int cantidad, double precio, bool add, Image img)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.add = add;
            this.imagen.Source = img.Source;
        }



        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public bool Add
        {
            get { return this.add; }
            set { this.add = value; }
        }

        public Image Imagen
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }

    }

}
