
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
            this.lbNombreUsuario.Location = new System.Drawing.Point(346, 49);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbNombreUsuario.TabIndex = 0;
            this.lbNombreUsuario.Text = "label1";
            // 
            // lbVerduraFavorita
            // 
            this.lbVerduraFavorita.AutoSize = true;
            this.lbVerduraFavorita.Location = new System.Drawing.Point(346, 77);
            this.lbVerduraFavorita.Name = "lbVerduraFavorita";
            this.lbVerduraFavorita.Size = new System.Drawing.Size(35, 13);
            this.lbVerduraFavorita.TabIndex = 1;
            this.lbVerduraFavorita.Text = "label2";
            // 
            // btnCambiarVerdura
            // 
            this.btnCambiarVerdura.Location = new System.Drawing.Point(515, 313);
            this.btnCambiarVerdura.Name = "btnCambiarVerdura";
            this.btnCambiarVerdura.Size = new System.Drawing.Size(103, 23);
            this.btnCambiarVerdura.TabIndex = 2;
            this.btnCambiarVerdura.Text = "Cambiar Verdura";
            this.btnCambiarVerdura.UseVisualStyleBackColor = true;
            this.btnCambiarVerdura.Click += new System.EventHandler(this.btnCambiarVerdura_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(104, 313);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVerduleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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