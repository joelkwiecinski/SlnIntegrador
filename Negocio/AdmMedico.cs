using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Models.Derivada;

namespace Negocio
{
    public static class AdmMedico
    {

        static List<Medico> medicos;

        public static List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Id=0, Nombre = "Raúl", Apellido = "Constanzo", Domicilio = "Calle Falsa 123", Telefono = "261364173", Email = "raulconstanzo@gmail.com", Especialidad = "Clínico", Matricula = 42313 });
            medicos.Add(new Medico() { Id = 1, Nombre = "Esteban", Apellido = "Quito", Domicilio = "España 2482", Telefono = "346782423", Email = "estebanquito@gmail.com", Especialidad = "Traumatólogo", Matricula = 54323 });
            medicos.Add(new Medico() { Id = 2, Nombre = "Armando", Apellido = "Casas", Domicilio = "Jujuy 342", Telefono = "354532534", Email = "armandocasas@gmail.com", Especialidad = "Clínico", Matricula = 25316 });
            medicos.Add(new Medico() { Id = 3, Nombre = "Lucas", Apellido = "Godoy", Domicilio = "Hudson 864", Telefono = "253717434", Email = "lucasgodoy@gmail.com", Especialidad = "Pediatra", Matricula = 68230 });
            return medicos;
        }

        public static List<Medico> Listar(string especialidad)
        {
            List<Medico> tempMedicos = new List<Medico> { };
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    tempMedicos.Add(medico);
                }
            }
            return tempMedicos;
        }

        public static int Insertar(Medico medico)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            return null;
        }
    }
}
