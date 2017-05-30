using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Region
    {
        int idRegion;
        string codigo;
        string nombre;

        public Region() { }

        public Region(int idRegion, string codigo, string nombre)
        {
            IdRegion = idRegion;
            Codigo = codigo;
            Nombre = nombre;
        }

        public Region(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public int IdRegion { get => idRegion; set => idRegion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public bool Create()
        {
            return true;
        }

        public Region Read()
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
