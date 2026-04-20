namespace ReproductorMusica
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
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.progresoCancion = new System.Windows.Forms.ProgressBar();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlbum
            // 
            this.pbAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbAlbum.BackColor = System.Drawing.Color.DarkGray;
            this.pbAlbum.Location = new System.Drawing.Point(90, 20);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(200, 200);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 235);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 25);
            this.lblTitulo.Text = "Nombre de la Canción";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArtista
            // 
            this.lblArtista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(12, 260);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(360, 20);
            this.lblArtista.Text = "Artista de la Pista";
            this.lblArtista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progresoCancion
            // 
            this.progresoCancion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progresoCancion.Location = new System.Drawing.Point(30, 300);
            this.progresoCancion.Name = "progresoCancion";
            this.progresoCancion.Size = new System.Drawing.Size(320, 15);
            this.progresoCancion.Value = 45;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAnterior.Location = new System.Drawing.Point(75, 335);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 40);
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlay.Location = new System.Drawing.Point(150, 335);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 40);
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSiguiente.Location = new System.Drawing.Point(255, 335);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(50, 40);
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.progresoCancion);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbAlbum);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "Form1";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.ProgressBar progresoCancion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

