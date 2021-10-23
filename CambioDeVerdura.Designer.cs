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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxColores
            // 
            this.cbxColores.FormattingEnabled = true;
            this.cbxColores.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Verde"});
            this.cbxColores.Location = new System.Drawing.Point(602, 218);
            this.cbxColores.Name = "cbxColores";
            this.cbxColores.Size = new System.Drawing.Size(121, 21);
            this.cbxColores.TabIndex = 0;
            this.cbxColores.SelectedIndexChanged += new System.EventHandler(this.cbxColores_SelectedIndexChanged);
            // 
            // cbxVerduras
            // 
            this.cbxVerduras.FormattingEnabled = true;
            this.cbxVerduras.Location = new System.Drawing.Point(602, 317);
            this.cbxVerduras.Name = "cbxVerduras";
            this.cbxVerduras.Size = new System.Drawing.Size(121, 21);
            this.cbxVerduras.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(451, 640);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "← Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCambiarComida
            // 
            this.btnCambiarComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCambiarComida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarComida.Location = new System.Drawing.Point(615, 422);
            this.btnCambiarComida.Name = "btnCambiarComida";
            this.btnCambiarComida.Size = new System.Drawing.Size(97, 43);
            this.btnCambiarComida.TabIndex = 3;
            this.btnCambiarComida.Text = "Cambiar";
            this.btnCambiarComida.UseVisualStyleBackColor = false;
            this.btnCambiarComida.Click += new System.EventHandler(this.btnCambiarComida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(602, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿De que color es?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(602, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Que fruta/verdura es?";
            // 
            // CambioDeVerdura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPVerduleria.Properties.Resources.Group_31;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambiarComida);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbxVerduras);
            this.Controls.Add(this.cbxColores);
            this.Name = "CambioDeVerdura";
            this.Text = "CambioDeVerdura";
            this.Load += new System.EventHandler(this.CambioDeVerdura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxColores;
        private System.Windows.Forms.ComboBox cbxVerduras;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCambiarComida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}