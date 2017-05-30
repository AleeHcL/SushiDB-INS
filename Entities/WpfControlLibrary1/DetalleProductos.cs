using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    pulic class DetalleProductos
    {
        int idDetalleProducto;
        int idProducto;
        int idIngrediente;

        public DetalleProductos() { }

        public DetalleProductos(int idProducto, int idIngrediente)
        {
            IdProducto = idProducto;
            IdIngrediente = idIngrediente;
        }

        public DetalleProductos(int idDetalleProducto, int idProducto, int idIngrediente)
        {
            this.IdDetalleProducto = idDetalleProducto;
            this.IdProducto = idProducto;
            this.IdIngrediente = idIngrediente;
        }

        public int IdDetalleProducto { get => idDetalleProducto; set => idDetalleProducto = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdIngrediente { get => idIngrediente; set => idIngrediente = value; }

        public bool Create()
        {
            return true;
        }

        public DetalleProductos Read()
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
