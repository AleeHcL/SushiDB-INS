using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class DetalleDescuentos
    {
        int idDetalleDescuentos;
        int idDescuento;
        int idVenta;

        public DetalleDescuentos() { }

        public DetalleDescuentos(int idDetalleDescuentos, int idDescuento, int idVenta)
        {
            IdDetalleDescuentos = idDetalleDescuentos;
            IdDescuento = idDescuento;
            IdVenta = idVenta;
        }

        public DetalleDescuentos(int idDescuento, int idVenta)
        {
            IdDescuento = idDescuento;
            IdVenta = idVenta;
        }

        public int IdDetalleDescuentos { get => idDetalleDescuentos; set => idDetalleDescuentos = value; }
        public int IdDescuento { get => idDescuento; set => idDescuento = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }

        public bool Create()
        {
            return true;
        }

        public DetalleDescuentos Read()
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
