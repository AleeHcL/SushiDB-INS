﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class DetalleVentas
    {
        int idDetalleVentas;
        int idPromo;
        int idProducto;
        int idVenta;

        public DetalleVentas() { }

        public DetalleVentas(int idDetalleVentas, int idPromo, int idProducto, int idVenta)
        {
            IdDetalleVentas = idDetalleVentas;
            IdPromo = idPromo;
            IdProducto = idProducto;
            IdVenta = idVenta;
        }

        public DetalleVentas(int idPromo, int idProducto, int idVenta)
        {
            IdPromo = idPromo;
            IdProducto = idProducto;
            IdVenta = idVenta;
        }

        public int IdDetalleVentas { get => idDetalleVentas; set => idDetalleVentas = value; }
        public int IdPromo { get => idPromo; set => idPromo = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }

        public bool Create()
        {
            return true;
        }

        public DetalleVentas Read()
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
