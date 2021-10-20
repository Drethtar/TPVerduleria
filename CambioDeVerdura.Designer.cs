namespace TPVerduleria
{
    partial class CambioDeVerdura
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
            this.cbxColores = new System.Windows.Forms.ComboBox();
            this.cbxVerduras = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCambiarComida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxColores
            // 
            this.cbxColores.FormattingEnabled = true;
            this.cbxColores.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Verde"});
            this.cbxColores.Location = new System.Drawing.Point(85, 145);
            this.cbxColores.Name = "cbxColores";
            this.cbxColores.Size = new System.Drawing.Size(121, 21);
            this.cbxColores.TabIndex = 0;
            this.cbxColores.SelectedIndexChanged += new System.EventHandler(this.cbxColores_SelectedIndexChanged);
            // 
            // cbxVerduras
            // 
            this.cbxVerduras.FormattingEnabled = true;
            this.cbxVerduras.Location = new System.Drawing.Point(85, 206);
            this.cbxVerduras.Name = "cbxVerduras";
            this.cbxVerduras.Size = new System.Drawing.Size(121, 21);
            this.cbxVerduras.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(85, 375);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCambiarComida
            // 
            this.btnCambiarComida.Location = new System.Drawing.Point(648, 374);
            this.btnCambiarComida.Name = "btnCambiarComida";
            this.btnCambiarComida.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarComida.TabIndex = 3;
            this.btnCambiarComida.Text = "Cambiar";
            this.btnCambiarComida.UseVisualStyleBackColor = true;
            this.btnCambiarComida.Click += new System.EventHandler(this.btnCambiarComida_Click);
            // 
            // CambioDeVerdura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCambiarComida);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbxVerduras);
            this.Controls.Add(this.cbxColores);
            this.Name = "CambioDeVerdura";
            this.Text = "CambioDeVerdura";
            this.Load += new System.EventHandler(this.CambioDeVerdura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxColores;
        private System.Windows.Forms.ComboBox cbxVerduras;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCambiarComida;
    }
}