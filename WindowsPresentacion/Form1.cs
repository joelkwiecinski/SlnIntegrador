using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Entidades.Models.Derivada;
using Negocio;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {

        AdmMedico admMedicos = new AdmMedico();
        AdmPaciente admPacientes = new AdmPaciente();
        AdmHabitacion admHabitaciones = new AdmHabitacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerMedicos_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = admMedicos.Listar();

            lstMedicosClinicos.Items.Clear();
            foreach (Medico medico in admMedicos.Listar("Clínico"))
            {
                lstMedicosClinicos.Items.Add(medico.Nombre + " " + medico.Apellido);
            }
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = admPacientes.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in admHabitaciones.Listar())
            {
                lstHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }
    }
}
