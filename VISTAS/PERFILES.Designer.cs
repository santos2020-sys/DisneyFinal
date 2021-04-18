
namespace DisneyFinal.VISTAS
{
    partial class PERFILES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCrearFormulario = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENDIDO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnCrearFormulario
            // 
            this.btnCrearFormulario.Location = new System.Drawing.Point(713, 415);
            this.btnCrearFormulario.Name = "btnCrearFormulario";
            this.btnCrearFormulario.Size = new System.Drawing.Size(75, 23);
            this.btnCrearFormulario.TabIndex = 3;
            this.btnCrearFormulario.Text = "Crear Perfil";
            this.btnCrearFormulario.UseVisualStyleBackColor = true;
            this.btnCrearFormulario.Click += new System.EventHandler(this.btnCrearFormulario_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 384);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.Location = new System.Drawing.Point(156, 381);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPerfil.TabIndex = 5;
            this.btnCrearPerfil.Text = "Crear";
            this.btnCrearPerfil.UseVisualStyleBackColor = true;
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "CERRAR SESION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cargar Mi Lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(676, 121);
            this.listBox1.TabIndex = 8;
            // 
            // PERFILES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCrearFormulario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PERFILES";
            this.Text = "PERFILES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCrearFormulario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrearPerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}