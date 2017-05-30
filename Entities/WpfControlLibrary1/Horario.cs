using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControlLibrary1
{
    public class Horario
    {
        int idHorario;
        string diaSem;
        string horaInicio;
        string horaFin;
        int idSucursal;

        public Horario() { }

        public Horario(int idHorario, string diaSem, string horaInicio, string horaFin, int idSucursal)
        {
            IdHorario = idHorario;
            DiaSem = diaSem;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            IdSucursal = idSucursal;
        }

        public Horario(string diaSem, string horaInicio, string horaFin, int idSucursal)
        {
            DiaSem = diaSem;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            IdSucursal = idSucursal;
        }

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public string DiaSem { get => diaSem; set => diaSem = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFin { get => horaFin; set => horaFin = value; }
        public int IdSucursal { get => idSucursal; set => idSucursal = value; }

        public bool Create()
        {
            return true;
        }

        public Horario Read()
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
