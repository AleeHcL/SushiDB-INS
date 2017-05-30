using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Promociones
    {
        int idPromocion;
        string descripcion;
        int precio;
        int idSucursal;

        public Promociones() { }

        public Promociones(int idPromocion, string descripcion, int precio, int idSucursal)
        {
            IdPromocion = idPromocion;
            Descripcion = descripcion;
            Precio = precio;
            IdSucursal = idSucursal;
        }

        public int IdPromocion { get => idPromocion; set => idPromocion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }

        public bool Create()
        {
            return true;
        }

        public Promociones Read()
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
