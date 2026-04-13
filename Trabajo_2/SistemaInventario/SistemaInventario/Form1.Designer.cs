namespace SistemaInventario
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.numStockInicial = new System.Windows.Forms.NumericUpDown();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.grpIva = new System.Windows.Forms.GroupBox();
            this.rbExento = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbReducido = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblStockI = new System.Windows.Forms.Label();
            this.lblStockM = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.grpIva.SuspendLayout();
            this.SuspendLayout();

            // Labels descriptivos
            this.lblCod.Text = "Código:";
            this.lblCod.Location = new System.Drawing.Point(30, 33);

            this.lblNom.Text = "Nombre:";
            this.lblNom.Location = new System.Drawing.Point(30, 73);

            this.lblCat.Text = "Categoría:";
            this.lblCat.Location = new System.Drawing.Point(30, 113);

            this.lblStockI.Text = "Stock Inicial:";
            this.lblStockI.Location = new System.Drawing.Point(30, 153);

            this.lblStockM.Text = "Stock Mínimo:";
            this.lblStockM.Location = new System.Drawing.Point(30, 193);

            this.lblFecha.Text = "Vencimiento:";
            this.lblFecha.Location = new System.Drawing.Point(150, 330);

            // Inputs
            this.txtCodigo.Location = new System.Drawing.Point(150, 30);
            this.txtCodigo.Size = new System.Drawing.Size(150, 20);
            this.txtCodigo.Text = "PROD-";

            this.txtNombreProducto.Location = new System.Drawing.Point(150, 70);
            this.txtNombreProducto.Size = new System.Drawing.Size(150, 20);

            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Electrónica", "Alimentos", "Ropa" });
            this.cmbCategoria.Location = new System.Drawing.Point(150, 110);
            this.cmbCategoria.Size = new System.Drawing.Size(150, 21);

            this.numStockInicial.Location = new System.Drawing.Point(150, 150);
            this.numStockMinimo.Location = new System.Drawing.Point(150, 190);

            // GroupBox e IVA
            this.grpIva.Controls.Add(this.rbExento);
            this.grpIva.Controls.Add(this.rbGeneral);
            this.grpIva.Controls.Add(this.rbReducido);
            this.grpIva.Location = new System.Drawing.Point(30, 230);
            this.grpIva.Size = new System.Drawing.Size(340, 60);
            this.grpIva.Text = "Seleccione el IVA";

            this.rbExento.Location = new System.Drawing.Point(10, 25);
            this.rbExento.Text = "Exento";
            this.rbGeneral.Location = new System.Drawing.Point(100, 25);
            this.rbGeneral.Text = "General (19%)";
            this.rbReducido.Location = new System.Drawing.Point(220, 25);
            this.rbReducido.Text = "Reducido (5%)";

            // Perecedero y Fecha
            this.chkEsPerecedero.Location = new System.Drawing.Point(30, 300);
            this.chkEsPerecedero.Text = "¿Es perecedero?";
            this.chkEsPerecedero.CheckedChanged += new System.EventHandler(this.chkEsPerecedero_CheckedChanged);

            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(150, 300);
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);

            // Botón
            this.btnProcesar.Location = new System.Drawing.Point(130, 370);
            this.btnProcesar.Size = new System.Drawing.Size(120, 35);
            this.btnProcesar.Text = "Registrar Producto";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);

            // Form Config
            this.ClientSize = new System.Drawing.Size(400, 440);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblCod, this.lblNom, this.lblCat, this.lblStockI, this.lblStockM, this.lblFecha,
                this.txtCodigo, this.txtNombreProducto, this.cmbCategoria, this.numStockInicial,
                this.numStockMinimo, this.grpIva, this.chkEsPerecedero, this.dtpFechaVencimiento, this.btnProcesar
            });
            this.Text = "Gestión de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown numStockInicial;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.GroupBox grpIva;
        private System.Windows.Forms.RadioButton rbExento;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbReducido;
        private System.Windows.Forms.CheckBox chkEsPerecedero;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblCod, lblNom, lblCat, lblStockI, lblStockM, lblFecha;
    }
}

