using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Genero
    {
        int idGenero;
        string descripcion;

        public Genero() { }

        public Genero(int idGenero, string descripcion)
        {
            IdGenero = idGenero;
            Descripcion = descripcion;
        }

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool Create()
        {
            return true;
        }

        public Genero Read()
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
