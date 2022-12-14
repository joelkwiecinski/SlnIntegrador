using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Models.Derivada;

namespace Negocio
{
    public static class AdmPaciente
    {

        static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id = 0, Nombre = "Alvaro", Apellido = "Benitez", Domicilio = "Mitre 2742", Telefono = "45642832", Email = "alvarobenitez@gmail.com", NroHistoriaClinica = 46316, FechaNacimiento = new DateTime(1999, 11, 05) });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Julio", Apellido = "Edificios", Domicilio = "Chile 467", Telefono = "261735824", Email = "julioedificios@gmail.com", NroHistoriaClinica = 26321, FechaNacimiento = new DateTime(1992, 05, 05) });
            pacientes.Add(new Paciente() { Id = 2, Nombre = "Jorge", Apellido = "Bastian", Domicilio = "25 de mayo 27", Telefono = "351734789", Email = "jorgebastian@gmail.com", NroHistoriaClinica = 6216, FechaNacimiento = new DateTime(2004, 08, 19) });
            pacientes.Add(new Paciente() { Id = 3, Nombre = "Julian", Apellido = "Gonzalez", Domicilio = "Perú 2328", Telefono = "2612453792", Email = "juliancapogonzalez214@gmail.com", NroHistoriaClinica = 76387, FechaNacimiento = new DateTime(1956, 02, 27) });
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return null;
        }

    }
}
