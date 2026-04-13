using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;

namespace SistemaEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtIdentificacion.Text) ||
                cmbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formato de Email incorrecto.");
                return;
            }

            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                MessageBox.Show("La identificación debe tener exactamente 10 dígitos.");
                return;
            }

            decimal sueldoNeto = numSueldoBase.Value * 0.90m;
            lblResultadoSueldo.Text = "Sueldo Neto: " + sueldoNeto.ToString("C");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            numSueldoBase.Value = 1000;
            cmbDepartamento.SelectedIndex = -1;
            lblResultadoSueldo.Text = "Sueldo Neto: $0.00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}