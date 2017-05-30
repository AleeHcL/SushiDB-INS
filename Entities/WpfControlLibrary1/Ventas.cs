using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Ventas
    {
        int idVenta;
        int numeroBoleta;
        int precio;
        int descTotal;
        int precioDesc;
        string fecha;
        string hora;
        int idTPago;
        int idSucursal;
        int idCliente;

        public Ventas() { }

        public Ventas(int idVenta, int numeroBoleta, int precio, int descTotal, int precioDesc, string fecha, string hora, int idTPago, int idSucursal, int idCliente)
        {
            IdCliente = idCliente;
            NumeroBoleta = numeroBoleta;
            Precio = precio;
            DescTotal = descTotal;
            PrecioDesc = precioDesc;
            Fecha = fecha;
            Hora = hora;
            IdTPago = idTPago;
            IdSucursal = idSucursal;
            IdCliente = idCliente;
        }

        public Ventas(int numeroBoleta, int precio, int descTotal, int precioDesc, string fecha, string hora, int idTPago, int idSucursal, int idCliente)
        {
            NumeroBoleta = numeroBoleta;
            Precio = precio;
            DescTotal = descTotal;
            PrecioDesc = precioDesc;
            Fecha = fecha;
            Hora = hora;
            IdTPago = idTPago;
            IdSucursal = idSucursal;
            IdCliente = idCliente;
        }

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int NumeroBoleta { get => numeroBoleta; set => numeroBoleta = value; }
        public int Precio { get => precio; set => precio = value; }
        public int DescTotal { get => descTotal; set => descTotal = value; }
        public int PrecioDesc { get => precioDesc; set => precioDesc = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int IdTPago { get => idTPago; set => idTPago = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public bool Create()
        {
            return true;
        }

        public Ventas Read()
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
