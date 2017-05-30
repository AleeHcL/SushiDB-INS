using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class CategoriaIngredientes
    {
        int idCategoriaIngredientes;
        string descripcion;

        public CategoriaIngredientes() { }

        public CategoriaIngredientes(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        public CategoriaIngredientes(int idCategoriaIngredientes, string descripcion)
        {
            this.IdCategoriaIngredientes = idCategoriaIngredientes;
            this.Descripcion = descripcion;
        }

        public int IdCategoriaIngredientes { get => idCategoriaIngredientes; set => idCategoriaIngredientes = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public bool Create()
        {
            return true;
        }

        public CategoriaIngredientes Read()
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
