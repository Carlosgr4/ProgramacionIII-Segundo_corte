namespace SistemaCatalogo
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
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.pnlTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTarjeta.Controls.Add(this.btnCarrito);
            this.pnlTarjeta.Controls.Add(this.numCantidad);
            this.pnlTarjeta.Controls.Add(this.lblCantidad);
            this.pnlTarjeta.Controls.Add(this.lblPrecio);
            this.pnlTarjeta.Controls.Add(this.txtDescripcion);
            this.pnlTarjeta.Controls.Add(this.lblNombre);
            this.pnlTarjeta.Location = new System.Drawing.Point(25, 25);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(250, 320);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombre.Location = new System.Drawing.Point(10, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(228, 30);
            this.lblNombre.Text = "Monitor Gamer 24\"";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(15, 60);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(220, 60);
            this.txtDescripcion.Text = "Resolución Full HD, 144Hz de refresco y tiempo de respuesta de 1ms. Ideal para gaming competitivo.";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrecio.Location = new System.Drawing.Point(10, 140);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(228, 35);
            this.lblPrecio.Text = "$299.99";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(12, 200);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 20);
            this.lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(80, 198);
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(50, 20);
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCarrito.ForeColor = System.Drawing.Color.White;
            this.btnCarrito.Location = new System.Drawing.Point(15, 250);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(220, 45);
            this.btnCarrito.Text = "Añadir al carrito";
            this.btnCarrito.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(304, 381);
            this.Controls.Add(this.pnlTarjeta);
            this.Name = "Form1";
            this.Text = "Catálogo de Productos";
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnCarrito;
    }
}

