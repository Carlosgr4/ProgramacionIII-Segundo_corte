using System;
using System.Windows.Forms;

namespace SistemaPerfil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios.");
                return;
            }

            string genero = "";
            if (rbMasculino.Checked) genero = "Masculino";
            else if (rbFemenino.Checked) genero = "Femenino";
            else if (rbOtro.Checked) genero = "Otro";

            if (string.IsNullOrEmpty(genero))
            {
                MessageBox.Show("Debe seleccionar un género.");
                return;
            }

            MessageBox.Show($"Cambios guardados con éxito para {txtNombre.Text} {txtApellido.Text}.\nGénero: {genero}");
        }
    }
}