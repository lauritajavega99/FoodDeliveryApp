﻿using System;
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
        private String nombre;
        private String descripcion;
        private int cantidad;
        private double precio;
        private Image imagen = new Image();
  

        public ProductosApp(String nombre, String descripcion, int cantidad, double precio, String pathImagen)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precio = precio;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
        }

        public ProductosApp(String nombre, double precio, String pathImagen)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.imagen.Source = new BitmapImage(new Uri(pathImagen));
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

       

        public Image Imagen
        {
            get { return this.imagen; }
            set { this.imagen = value; }
        }

    }

}
