namespace GestiónEstudiantesEmpleados
{
    partial class FormEmpleadoCualificado
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
            this.textBoxSueldoBase = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelSueldoBase = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSueldoBase
            // 
            this.textBoxSueldoBase.Location = new System.Drawing.Point(15, 81);
            this.textBoxSueldoBase.Name = "textBoxSueldoBase";
            this.textBoxSueldoBase.Size = new System.Drawing.Size(100, 22);
            this.textBoxSueldoBase.TabIndex = 14;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(15, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 12;
            // 
            // labelSueldoBase
            // 
            this.labelSueldoBase.AutoSize = true;
            this.labelSueldoBase.Location = new System.Drawing.Point(12, 62);
            this.labelSueldoBase.Name = "labelSueldoBase";
            this.labelSueldoBase.Size = new System.Drawing.Size(88, 16);
            this.labelSueldoBase.TabIndex = 10;
            this.labelSueldoBase.Text = "Sueldo Base:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(184, 81);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(177, 22);
            this.textBoxDNI.TabIndex = 18;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(184, 28);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(257, 22);
            this.textBoxApellidos.TabIndex = 17;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(181, 62);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(33, 16);
            this.labelDNI.TabIndex = 16;
            this.labelDNI.Text = "DNI:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(181, 9);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(67, 16);
            this.labelApellidos.TabIndex = 15;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // FormEmpleadoCualificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textBoxSueldoBase);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelSueldoBase);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormEmpleadoCualificado";
            this.Text = "Cualificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSueldoBase;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelSueldoBase;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelApellidos;
    }
}