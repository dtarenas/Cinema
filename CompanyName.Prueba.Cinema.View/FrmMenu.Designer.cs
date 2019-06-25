namespace CompanyName.Prueba.Cinema.View
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdCiudades = new System.Windows.Forms.Button();
            this.cmdPeliculas = new System.Windows.Forms.Button();
            this.cmdSillas = new System.Windows.Forms.Button();
            this.cmdDetalle = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCiudades
            // 
            this.cmdCiudades.Location = new System.Drawing.Point(26, 25);
            this.cmdCiudades.Name = "cmdCiudades";
            this.cmdCiudades.Size = new System.Drawing.Size(75, 23);
            this.cmdCiudades.TabIndex = 0;
            this.cmdCiudades.Text = "Ciudades";
            this.cmdCiudades.UseVisualStyleBackColor = true;
            this.cmdCiudades.Click += new System.EventHandler(this.cmdCiudades_Click);
            // 
            // cmdPeliculas
            // 
            this.cmdPeliculas.Location = new System.Drawing.Point(135, 25);
            this.cmdPeliculas.Name = "cmdPeliculas";
            this.cmdPeliculas.Size = new System.Drawing.Size(75, 23);
            this.cmdPeliculas.TabIndex = 1;
            this.cmdPeliculas.Text = "Peliculas";
            this.cmdPeliculas.UseVisualStyleBackColor = true;
            this.cmdPeliculas.Click += new System.EventHandler(this.cmdPeliculas_Click);
            // 
            // cmdSillas
            // 
            this.cmdSillas.Location = new System.Drawing.Point(239, 25);
            this.cmdSillas.Name = "cmdSillas";
            this.cmdSillas.Size = new System.Drawing.Size(75, 23);
            this.cmdSillas.TabIndex = 2;
            this.cmdSillas.Text = "Sillas";
            this.cmdSillas.UseVisualStyleBackColor = true;
            this.cmdSillas.Click += new System.EventHandler(this.cmdSillas_Click);
            // 
            // cmdDetalle
            // 
            this.cmdDetalle.Location = new System.Drawing.Point(356, 25);
            this.cmdDetalle.Name = "cmdDetalle";
            this.cmdDetalle.Size = new System.Drawing.Size(75, 23);
            this.cmdDetalle.TabIndex = 3;
            this.cmdDetalle.Text = "Detalle";
            this.cmdDetalle.UseVisualStyleBackColor = true;
            this.cmdDetalle.Click += new System.EventHandler(this.cmdDetalle_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(186, 72);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 103);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmdDetalle);
            this.Controls.Add(this.cmdSillas);
            this.Controls.Add(this.cmdPeliculas);
            this.Controls.Add(this.cmdCiudades);
            this.Name = "FrmMenu";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCiudades;
        private System.Windows.Forms.Button cmdPeliculas;
        private System.Windows.Forms.Button cmdSillas;
        private System.Windows.Forms.Button cmdDetalle;
        private System.Windows.Forms.Button btnSalir;
    }
}