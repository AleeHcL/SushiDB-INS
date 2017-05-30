using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Despacho
    {
        int idDespacho;
        int idEmpleado;
        int detalleVenta;

        public Despacho() { }

        public Despacho(int idDespacho, int idEmpleado, int detalleVenta)
        {
            IdDespacho = idDespacho;
            IdEmpleado = idEmpleado;
            DetalleVenta = detalleVenta;
        }

        public Despacho(int idEmpleado, int detalleVenta)
        {
            IdEmpleado = idEmpleado;
            DetalleVenta = detalleVenta;
        }

        public int IdDespacho { get => idDespacho; set => idDespacho = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int DetalleVenta { get => DetalleVenta; set => DetalleVenta = value; }

        public bool Create()
        {
            return true;
        }

        public Despacho Read()
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
