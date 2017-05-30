using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Cargo
    {
        int idCarga;
        string nombre;

        public Cargo() { }

        public Cargo(int idCargo, string nombre)
        {
            IdCargo = idCargo;
            Nombre = nombre;
        }

        public Cargo(string nombre)
        {
            Nombre = nombre;
        }

        public int IdCargo { get => idCargo; set => idCargo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public bool Create()
        {
            return true;
        }

        public Cargo Read()
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
