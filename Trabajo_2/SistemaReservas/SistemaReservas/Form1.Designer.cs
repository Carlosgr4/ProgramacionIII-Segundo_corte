namespace SistemaReservas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();

            this.lbl1.Text = "Cliente:";
            this.lbl1.Location = new System.Drawing.Point(20, 20);
            this.txtCliente.Location = new System.Drawing.Point(120, 17);
            this.txtCliente.Size = new System.Drawing.Size(230, 20);

            this.lbl2.Text = "Entrada:";
            this.lbl2.Location = new System.Drawing.Point(20, 55);
            this.dtpEntrada.Location = new System.Drawing.Point(120, 52);
            this.dtpEntrada.Size = new System.Drawing.Size(230, 20);

            this.lbl3.Text = "Salida:";
            this.lbl3.Location = new System.Drawing.Point(20, 90);
            this.dtpSalida.Location = new System.Drawing.Point(120, 87);
            this.dtpSalida.Size = new System.Drawing.Size(230, 20);

            this.lbl4.Text = "Personas:";
            this.lbl4.Location = new System.Drawing.Point(20, 125);
            this.numPersonas.Location = new System.Drawing.Point(120, 122);
            this.numPersonas.Minimum = 1;
            this.numPersonas.Maximum = 4;

            this.lbl5.Text = "Servicios adicionales:";
            this.lbl5.Location = new System.Drawing.Point(20, 160);
            this.clbServicios.Location = new System.Drawing.Point(20, 180);
            this.clbServicios.Size = new System.Drawing.Size(330, 79);
            this.clbServicios.Items.AddRange(new object[] { "WiFi Premium", "Desayuno Buffet", "Estacionamiento", "Spa" });

            this.rtbResumen.Location = new System.Drawing.Point(20, 310);
            this.rtbResumen.Size = new System.Drawing.Size(330, 150);
            this.rtbResumen.ReadOnly = true;

            this.btnCalcularReserva.Location = new System.Drawing.Point(110, 270);
            this.btnCalcularReserva.Size = new System.Drawing.Size(150, 30);
            this.btnCalcularReserva.Text = "Calcular Reserva";
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);

            this.ClientSize = new System.Drawing.Size(380, 480);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lbl1, this.lbl2, this.lbl3, this.lbl4, this.lbl5,
                this.txtCliente, this.dtpEntrada, this.dtpSalida, this.numPersonas,
                this.clbServicios, this.rtbResumen, this.btnCalcularReserva
            });
            this.Text = "Reserva de Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4, lbl5;
    }
}


