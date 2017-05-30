using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Productos
    {
        int idProducto;
        string nombre;
        int precio;
        int idSucursal;

        public Productos() { }

        public Productos(int idProducto, string nombre, int precio, int idSucursal)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Precio = precio;
            IdSucursal = idSucursal;
        }

        public Productos(string nombre, int precio, int idSucursal)
        {
            Nombre = nombre;
            Precio = precio;
            IdSucursal = idSucursal;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }

        public bool Create()
        {
            return true;
        }

        public Productos Read()
        {
            return this;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }
    }
}
