namespace SistemaPerfil
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
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbPrincipal.SuspendLayout();
            this.pnlGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.lblGenero);
            this.gbPrincipal.Controls.Add(this.pnlGenero);
            this.gbPrincipal.Controls.Add(this.mtbTelefono);
            this.gbPrincipal.Controls.Add(this.lblTelefono);
            this.gbPrincipal.Controls.Add(this.txtEmail);
            this.gbPrincipal.Controls.Add(this.lblEmail);
            this.gbPrincipal.Controls.Add(this.txtApellido);
            this.gbPrincipal.Controls.Add(this.lblApellido);
            this.gbPrincipal.Controls.Add(this.txtNombre);
            this.gbPrincipal.Controls.Add(this.lblNombre);
            this.gbPrincipal.Location = new System.Drawing.Point(12, 12);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(360, 280);
            this.gbPrincipal.Text = "Información Personal";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(20, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 72);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(20, 155);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(100, 23);
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(140, 152);
            this.mtbTelefono.Mask = "(999) 000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(200, 20);
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(20, 195);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(100, 23);
            this.lblGenero.Text = "Género:";
            // 
            // pnlGenero
            // 
            this.pnlGenero.Controls.Add(this.rbOtro);
            this.pnlGenero.Controls.Add(this.rbFemenino);
            this.pnlGenero.Controls.Add(this.rbMasculino);
            this.pnlGenero.Location = new System.Drawing.Point(140, 195);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(200, 70);
            // 
            // rbMasculino
            // 
            this.rbMasculino.Location = new System.Drawing.Point(5, 5);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(100, 17);
            this.rbMasculino.Text = "Masculino";
            // 
            // rbFemenino
            // 
            this.rbFemenino.Location = new System.Drawing.Point(5, 25);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(100, 17);
            this.rbFemenino.Text = "Femenino";
            // 
            // rbOtro
            // 
            this.rbOtro.Location = new System.Drawing.Point(5, 45);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(100, 17);
            this.rbOtro.Text = "Otro";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbPrincipal);
            this.Name = "Form1";
            this.Text = "Mi Cuenta";
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.pnlGenero.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnGuardar;
    }
}

