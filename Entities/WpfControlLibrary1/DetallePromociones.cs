using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class DetallePromociones
    {
        int idDetallePromocion;
        int idPromo;
        int idProducto;

        public DetallePromociones() { }

        public DetallePromociones(int idDetallePromocion, int idPromo, int idProducto)
        {
            IdDetallePromocion = idDetallePromocion;
            IdPromo = idPromo;
            IdProducto = idProducto;
        }

        public DetallePromociones(int idPromo, int idProducto)
        {
            IdPromo = idPromo;
            IdProducto = idProducto;
        }

        public int IdDetallePromocion { get => idDetallePromocion; set => idDetallePromocion = value; }
        public int IdPromo { get => idPromo; set => idPromo = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }

        public bool Create()
        {
            return true;
        }

        public DetallePromociones Read()
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
