namespace SistemaConfiguracion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabApariencia = new System.Windows.Forms.TabPage();
            this.tabNotificaciones = new System.Windows.Forms.TabPage();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.chkAnimaciones = new System.Windows.Forms.CheckBox();
            this.chkCorreos = new System.Windows.Forms.CheckBox();
            this.chkAlertas = new System.Windows.Forms.CheckBox();
            this.chkSonidos = new System.Windows.Forms.CheckBox();
            this.numVolumen = new System.Windows.Forms.NumericUpDown();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabApariencia.SuspendLayout();
            this.tabNotificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabApariencia);
            this.tabControl1.Controls.Add(this.tabNotificaciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 261);
            // 
            // tabApariencia
            // 
            this.tabApariencia.Controls.Add(this.chkAnimaciones);
            this.tabApariencia.Controls.Add(this.cmbTema);
            this.tabApariencia.Controls.Add(this.lblTema);
            this.tabApariencia.Location = new System.Drawing.Point(4, 22);
            this.tabApariencia.Name = "tabApariencia";
            this.tabApariencia.Padding = new System.Windows.Forms.Padding(20);
            this.tabApariencia.Size = new System.Drawing.Size(376, 235);
            this.tabApariencia.Text = "Apariencia";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(20, 30);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(93, 13);
            this.lblTema.Text = "Tema del Sistema:";
            // 
            // cmbTema
            // 
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Claro",
            "Oscuro",
            "Azul Cobalto"});
            this.cmbTema.Location = new System.Drawing.Point(23, 55);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(200, 21);
            // 
            // chkAnimaciones
            // 
            this.chkAnimaciones.AutoSize = true;
            this.chkAnimaciones.Location = new System.Drawing.Point(23, 100);
            this.chkAnimaciones.Name = "chkAnimaciones";
            this.chkAnimaciones.Size = new System.Drawing.Size(168, 17);
            this.chkAnimaciones.Text = "Activar animaciones de ventana";
            // 
            // tabNotificaciones
            // 
            this.tabNotificaciones.Controls.Add(this.lblVolumen);
            this.tabNotificaciones.Controls.Add(this.numVolumen);
            this.tabNotificaciones.Controls.Add(this.chkSonidos);
            this.tabNotificaciones.Controls.Add(this.chkAlertas);
            this.tabNotificaciones.Controls.Add(this.chkCorreos);
            this.tabNotificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabNotificaciones.Name = "tabNotificaciones";
            this.tabNotificaciones.Padding = new System.Windows.Forms.Padding(20);
            this.tabNotificaciones.Size = new System.Drawing.Size(376, 235);
            this.tabNotificaciones.Text = "Notificaciones";
            // 
            // chkCorreos
            // 
            this.chkCorreos.AutoSize = true;
            this.chkCorreos.Location = new System.Drawing.Point(23, 30);
            this.chkCorreos.Name = "chkCorreos";
            this.chkCorreos.Size = new System.Drawing.Size(100, 17);
            this.chkCorreos.Text = "Recibir correos";
            // 
            // chkAlertas
            // 
            this.chkAlertas.AutoSize = true;
            this.chkAlertas.Location = new System.Drawing.Point(23, 60);
            this.chkAlertas.Name = "chkAlertas";
            this.chkAlertas.Size = new System.Drawing.Size(117, 17);
            this.chkAlertas.Text = "Alertas de escritorio";
            // 
            // chkSonidos
            // 
            this.chkSonidos.AutoSize = true;
            this.chkSonidos.Location = new System.Drawing.Point(23, 90);
            this.chkSonidos.Name = "chkSonidos";
            this.chkSonidos.Size = new System.Drawing.Size(117, 17);
            this.chkSonidos.Text = "Sonidos de sistema";
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(20, 130);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(94, 13);
            this.lblVolumen.Text = "Volumen de alerta:";
            // 
            // numVolumen
            // 
            this.numVolumen.Location = new System.Drawing.Point(23, 155);
            this.numVolumen.Name = "numVolumen";
            this.numVolumen.Size = new System.Drawing.Size(80, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Panel de Configuración";
            this.tabControl1.ResumeLayout(false);
            this.tabApariencia.ResumeLayout(false);
            this.tabApariencia.PerformLayout();
            this.tabNotificaciones.ResumeLayout(false);
            this.tabNotificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabApariencia;
        private System.Windows.Forms.TabPage tabNotificaciones;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.CheckBox chkAnimaciones;
        private System.Windows.Forms.CheckBox chkCorreos;
        private System.Windows.Forms.CheckBox chkAlertas;
        private System.Windows.Forms.CheckBox chkSonidos;
        private System.Windows.Forms.NumericUpDown numVolumen;
        private System.Windows.Forms.Label lblVolumen;
    }
}

