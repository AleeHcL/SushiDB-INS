using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comuna
    {
        int idComuna;
        string nombre;
        int idRegion;

        public Comuna() { }

        public Comuna(int idComuna, string nombre, int idRegion)
        {
            IdComuna = idComuna;
            Nombre = nombre;
            IdRegion = idRegion;
        }

        public Comuna(string nombre, int idRegion)
        {
            Nombre = nombre;
            IdRegion = idRegion;
        }

        public int IdComuna { get => idComuna; set => idComuna = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdRegion { get => idRegion; set => idRegion = value; }

        public bool Create()
        {
            return true;
        }

        public Comuna Read()
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
