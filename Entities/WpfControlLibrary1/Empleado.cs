using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Empleado
    {
        int idEmpleado;
        string rut;
        string dv;
        string nombre;
        string apPat;
        string apMat;
        string celular;
        string mail;
        string activo;
        int idComuna;
        int idCargo;

        public Empleado() { }

        public Empleado(int idEmpleado, string rut, string dv, string nombre, string apPat, string celular, string mail, string activo, int idComuna, int idCargo)
        {
            IdEmpleado = idEmpleado;
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            ApPat = apPat;
            Celular = celular;
            Mail = mail;
            Activo = activo;
            IdComuna = idComuna;
            IdCargo = idCargo;
        }

        public Empleado(string rut, string dv, string nombre, string apPat, string apMat, string celular, string mail, string activo, int idComuna, int idCargo)
        {
            Rut = rut;
            Dv = dv;
            Nombre = nombre;
            ApPat = apPat;
            ApMat = apMat;
            Celular = celular;
            Mail = mail;
            Activo = activo;
            IdComuna = idComuna;
            IdCargo = idCargo;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Dv { get => dv; set => dv = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPat { get => apPat; set => apPat = value; }
        public string ApMat { get => apMat; set => apMat = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Activo { get => activo; set => activo = value; }
        public int IdComuna { get => idComuna; set => idComuna = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }

        public bool Create()
        {
            return true;
        }

        public Empleado Read()
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
