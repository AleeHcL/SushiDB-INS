using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Cliente
    {
        int idCliente;
        string rut;
        string dv;
        string nombre;
        string apPat;
        string apMat;
        string calle;
        string numero;
        string dpto;
        string block;
        string telefono;
        string celular;
        string mail;

        public Cliente() { }

        public Cliente(int idCliente, string rut, string dv, string nombre, string apPat, string apMat, string calle, string numero, string dpto, string block, string telefono, string celular, string mail)
        {
            IdCliente = idCliente;
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            ApPat = apPat;
            ApMat = apMat;
            Calle = calle;
            Numero = numero;
            Dpto = dpto;
            Block = block;
            Telefono = telefono;
            Celular = celular;
            Mail = mail;
        }

        public Cliente(string rut, string dv, string nombre, string apPat, string calle, string numero, string mail)
        {
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            ApPat = apPat;
            Calle = calle;
            Numero = numero;
            Mail = mail;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Dv { get => dv; set => dv = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPat { get => apPat; set => apPat = value; }
        public string ApMat { get => apMat; set => apMat = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Dpto { get => dpto; set => dpto = value; }
        public string Block { get => block; set => block = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Mail { get => mail; set => mail = value; }

        public bool Create()
        {
            return true;
        }

        public Cliente Read()
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
