using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivada
{
    public class Director: Medico
    {
        public string Posgrado { get; set; }

        public Director(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, int matricula, string posgrado) : base(id, nombre, apellido, domicilio, telefono, email, especialidad, matricula)
        {
            Posgrado = posgrado;
        }

    }
}
