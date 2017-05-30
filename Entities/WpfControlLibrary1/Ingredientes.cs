using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Ingredientes
    {
        int idIngrediente;
        string nombre;
        int idCategoriaIngrediente;

        public Ingredientes() { }

        public Ingredientes(string nombre, int idCategoriaIngrediente)
        {
            this.Nombre = nombre;
            this.IdCategoriaIngrediente = idCategoriaIngrediente;
        }

        public Ingredientes(int idIngrediente, string nombre, int idCategoriaIngrediente)
        {
            this.IdIngrediente = idIngrediente;
            this.Nombre = nombre;
            this.IdCategoriaIngrediente = idCategoriaIngrediente;
        }

        public int IdIngrediente { get => idIngrediente; set => idIngrediente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdCategoriaIngrediente { get => idCategoriaIngrediente; set => idCategoriaIngrediente = value; }

        public bool Create()
        {
            return true;
        }

        public Ingredientes Read()
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
