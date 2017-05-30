using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Usuarios
    {
        string usuario;
        string password;

        public Usuarios() { }

        public Usuarios(string usuario, string password)
        {
            Usuario = usuario;
            Password = password;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        public bool Create()
        {
            return true;
        }

        public Usuarios Read()
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
