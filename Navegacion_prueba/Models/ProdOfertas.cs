using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
    public class ProdOfertas
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string imagenProducto { get; set; }
    }

    public class GestionOfertas
    {
        public static List<ProdOfertas> GetOfertas()
        {
            var productosApp = new List<ProdOfertas>();

            productosApp.Add(new ProdOfertas { Nombre = "Hamburguesas", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Pizzas", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Entrantes", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Postres", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Entrantes", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Postres", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Hamburguesas", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Pizzas", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Entrantes", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Postres", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Entrantes", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });
            productosApp.Add(new ProdOfertas { Nombre = "Postres", Descripcion = "Incluye 2 hamburguesas de pollo y queso, 2 patatas pequeñas y bebida.", Precio = 4.50, imagenProducto = "Assets/Hamburguesa1.png" });

            return productosApp;
        }
    }
}
