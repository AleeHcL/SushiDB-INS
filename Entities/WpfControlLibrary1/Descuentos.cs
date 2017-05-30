using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Descuentos
    {
        int idDescuento;
        string descripcion;
        int porcentaje;

        public Descuentos() { }

        public Descuentos(int idDescuento, string descripcion, int porcentaje)
        {
            IdDescuento = idDescuento;
            Descripcion = descripcion;
            Porcentaje = porcentaje;
        }

        public Descuentos(string descripcion, int porcentaje)
        {
            Descripcion = descripcion;
            Porcentaje = porcentaje;
        }

        public int IdDescuento { get => idDescuento; set => idDescuento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }

        public bool Create()
        {
            return true;
        }

        public Descuentos Read()
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
