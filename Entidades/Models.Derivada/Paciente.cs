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

        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, int nroHistoriaClinica):base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public Paciente() { }

    }
}
