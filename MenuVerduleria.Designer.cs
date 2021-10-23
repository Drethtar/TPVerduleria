
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
            this.SuspendLayout();
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(525, 176);
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
            this.lbVerduraFavorita.Location = new System.Drawing.Point(525, 285);
            this.lbVerduraFavorita.Name = "lbVerduraFavorita";
            this.lbVerduraFavorita.Size = new System.Drawing.Size(79, 29);
            this.lbVerduraFavorita.TabIndex = 1;
            this.lbVerduraFavorita.Text = "label2";
            // 
            // btnCambiarVerdura
            // 
            this.btnCambiarVerdura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCambiarVerdura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarVerdura.Location = new System.Drawing.Point(586, 475);
            this.btnCambiarVerdura.Name = "btnCambiarVerdura";
            this.btnCambiarVerdura.Size = new System.Drawing.Size(131, 53);
            this.btnCambiarVerdura.TabIndex = 2;
            this.btnCambiarVerdura.Text = "Cambiar Verdura";
            this.btnCambiarVerdura.UseVisualStyleBackColor = false;
            this.btnCambiarVerdura.Click += new System.EventHandler(this.btnCambiarVerdura_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(434, 646);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "← Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVerduleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPVerduleria.Properties.Resources.Group_3;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
    }
}