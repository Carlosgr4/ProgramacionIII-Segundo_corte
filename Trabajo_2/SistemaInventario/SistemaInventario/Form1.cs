using System;
using System.Windows.Forms;

namespace SistemaInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (!txtCodigo.Text.StartsWith("PROD-"))
            {
                MessageBox.Show("El código debe comenzar con 'PROD-'", "Error de Código");
                return;
            }

            if (numStockInicial.Value < numStockMinimo.Value)
            {
                MessageBox.Show("El stock inicial no puede ser menor al mínimo.", "Error de Stock");
                return;
            }

            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de IVA.", "Error de IVA");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Complete el nombre y la categoría.", "Campos vacíos");
                return;
            }

            MessageBox.Show("Producto registrado correctamente en el sistema.", "Éxito");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
