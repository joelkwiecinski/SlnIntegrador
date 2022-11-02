using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivada
{
    public class Enfermero: Persona
    {
        public string CUIL { get; set; }

        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email, string cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            CUIL = cuil;
        }

    }
}
