using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class TipoPago
    {
        int idTipoPago;
	    string descripcion;

        public TipoPago() { }

        public TipoPago(int idTipoPago, string descripcion)
        {
            IdTipoPago = idTipoPago;
            Descripcion = descripcion;
        }

        public TipoPago(string descripcion)
        {
            Descripcion = descripcion;
        }

        public int IdTipoPago { get => idTipoPago; set => idTipoPago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool Create()
        {
            return true;
        }

        public TipoPago Read()
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
