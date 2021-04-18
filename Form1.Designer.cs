
namespace DisneyFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSesion = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSesion
            // 
            this.btnSesion.Location = new System.Drawing.Point(210, 163);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(115, 23);
            this.btnSesion.TabIndex = 0;
            this.btnSesion.Text = "INICIAR SESION";
            this.btnSesion.UseVisualStyleBackColor = true;
            this.btnSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(444, 163);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(98, 23);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "REGISTRARSE";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Button btnRegistro;
    }
}

