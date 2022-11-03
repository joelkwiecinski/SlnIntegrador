using Entidades.Ayudantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivada
{
    public class Paciente: Persona
    {

        public int NroHistoriaClinica { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get { return UtilidadesFechas.CalcularEdad(FechaNacimiento); } }

        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, int nroHistoriaClinica, DateTime fechaNacimiento):base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            FechaNacimiento = fechaNacimiento;
        }

        public Paciente() { }

    }
}
