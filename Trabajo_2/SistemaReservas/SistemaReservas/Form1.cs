using System;
using System.Windows.Forms;
using System.Text;

namespace SistemaReservas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.");
                return;
            }

            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de entrada no puede ser anterior a hoy.");
                return;
            }

            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                MessageBox.Show("La fecha de salida debe ser posterior a la de entrada.");
                return;
            }

            TimeSpan diferencia = dtpSalida.Value.Date - dtpEntrada.Value.Date;
            int dias = diferencia.Days;

            double costoNoche = 50.0;
            double costoExtraPersona = (numPersonas.Value > 1) ? (double)(numPersonas.Value - 1) * 15.0 : 0;
            double costoServiciosDiarios = clbServicios.CheckedItems.Count * 10.0;

            double totalDiario = costoNoche + costoExtraPersona + costoServiciosDiarios;
            double montoTotal = totalDiario * dias;

            StringBuilder resumen = new StringBuilder();
            resumen.AppendLine("--- RESUMEN DE RESERVA ---");
            resumen.AppendLine($"Cliente: {txtCliente.Text}");
            resumen.AppendLine($"Estancia: {dias} noches.");
            resumen.AppendLine($"Personas: {numPersonas.Value}");

            resumen.Append("Servicios: ");
            if (clbServicios.CheckedItems.Count > 0)
            {
                string[] seleccionados = new string[clbServicios.CheckedItems.Count];
                for (int i = 0; i < clbServicios.CheckedItems.Count; i++)
                    seleccionados[i] = clbServicios.CheckedItems[i].ToString();
                resumen.AppendLine(string.Join(", ", seleccionados));
            }
            else
            {
                resumen.AppendLine("Ninguno");
            }

            resumen.AppendLine("--------------------------");
            resumen.AppendLine($"TOTAL A PAGAR: ${montoTotal:F2}");

            rtbResumen.Text = resumen.ToString();
        }
    }
}
