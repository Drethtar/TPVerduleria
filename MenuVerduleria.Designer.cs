
namespace TPVerduleria
{
    partial class MenuVerduleria
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
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.lbVerduraFavorita = new System.Windows.Forms.Label();
            this.btnCambiarVerdura = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxColores = new System.Windows.Forms.ComboBox();
            this.cbxVerduras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(675, 229);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(79, 29);
            this.lbNombreUsuario.TabIndex = 0;
            this.lbNombreUsuario.Text = "label1";
            // 
            // lbVerduraFavorita
            // 
            this.lbVerduraFavorita.AutoSize = true;
            this.lbVerduraFavorita.BackColor = System.Drawing.Color.Transparent;
            this.lbVerduraFavorita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerduraFavorita.Location = new System.Drawing.Point(675, 402);
            this.lbVerduraFavorita.MaximumSize = new System.Drawing.Size(200, 200);
            this.lbVerduraFavorita.Name = "lbVerduraFavorita";
            this.lbVerduraFavorita.Size = new System.Drawing.Size(79, 29);
            this.lbVerduraFavorita.TabIndex = 1;
            this.lbVerduraFavorita.Text = "label2";
            // 
            // btnCambiarVerdura
            // 
            this.btnCambiarVerdura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCambiarVerdura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarVerdura.Location = new System.Drawing.Point(223, 476);
            this.btnCambiarVerdura.Name = "btnCambiarVerdura";
            this.btnCambiarVerdura.Size = new System.Drawing.Size(121, 53);
            this.btnCambiarVerdura.TabIndex = 2;
            this.btnCambiarVerdura.Text = "Cambiar Verdura";
            this.btnCambiarVerdura.UseVisualStyleBackColor = false;
            this.btnCambiarVerdura.Click += new System.EventHandler(this.btnCambiarVerdura_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(142, 643);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "← Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxColores
            // 
            this.cbxColores.FormattingEnabled = true;
            this.cbxColores.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Amarillo"});
            this.cbxColores.Location = new System.Drawing.Point(223, 238);
            this.cbxColores.Name = "cbxColores";
            this.cbxColores.Size = new System.Drawing.Size(121, 21);
            this.cbxColores.TabIndex = 4;
            this.cbxColores.SelectedIndexChanged += new System.EventHandler(this.cbxColores_SelectedIndexChanged);
            // 
            // cbxVerduras
            // 
            this.cbxVerduras.FormattingEnabled = true;
            this.cbxVerduras.Location = new System.Drawing.Point(223, 362);
            this.cbxVerduras.Name = "cbxVerduras";
            this.cbxVerduras.Size = new System.Drawing.Size(121, 21);
            this.cbxVerduras.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(220, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿De que color es?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(220, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Que es?";
            // 
            // MenuVerduleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPVerduleria.Properties.Resources.Group_32;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxVerduras);
            this.Controls.Add(this.cbxColores);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCambiarVerdura);
            this.Controls.Add(this.lbVerduraFavorita);
            this.Controls.Add(this.lbNombreUsuario);
            this.Name = "MenuVerduleria";
            this.Text = "MenuVerduleria";
            this.Load += new System.EventHandler(this.MenuVerduleria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Label lbVerduraFavorita;
        private System.Windows.Forms.Button btnCambiarVerdura;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbxColores;
        private System.Windows.Forms.ComboBox cbxVerduras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}