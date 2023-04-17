namespace GestiónEstudiantesEmpleados
{
    partial class FormAñadir
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
            this.buttonObrero = new System.Windows.Forms.Button();
            this.buttonCualificado = new System.Windows.Forms.Button();
            this.buttonJefeDepartamento = new System.Windows.Forms.Button();
            this.buttonBecario = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonObrero
            // 
            this.buttonObrero.Location = new System.Drawing.Point(12, 12);
            this.buttonObrero.Name = "buttonObrero";
            this.buttonObrero.Size = new System.Drawing.Size(157, 49);
            this.buttonObrero.TabIndex = 0;
            this.buttonObrero.Text = "Obrero";
            this.buttonObrero.UseVisualStyleBackColor = true;
            this.buttonObrero.Click += new System.EventHandler(this.buttonObrero_Click);
            // 
            // buttonCualificado
            // 
            this.buttonCualificado.Location = new System.Drawing.Point(218, 12);
            this.buttonCualificado.Name = "buttonCualificado";
            this.buttonCualificado.Size = new System.Drawing.Size(157, 49);
            this.buttonCualificado.TabIndex = 1;
            this.buttonCualificado.Text = "Cualificado";
            this.buttonCualificado.UseVisualStyleBackColor = true;
            // 
            // buttonJefeDepartamento
            // 
            this.buttonJefeDepartamento.Location = new System.Drawing.Point(12, 67);
            this.buttonJefeDepartamento.Name = "buttonJefeDepartamento";
            this.buttonJefeDepartamento.Size = new System.Drawing.Size(157, 49);
            this.buttonJefeDepartamento.TabIndex = 2;
            this.buttonJefeDepartamento.Text = "Jefe Departamento";
            this.buttonJefeDepartamento.UseVisualStyleBackColor = true;
            // 
            // buttonBecario
            // 
            this.buttonBecario.Location = new System.Drawing.Point(218, 67);
            this.buttonBecario.Name = "buttonBecario";
            this.buttonBecario.Size = new System.Drawing.Size(157, 49);
            this.buttonBecario.TabIndex = 3;
            this.buttonBecario.Text = "Becario";
            this.buttonBecario.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(145, 140);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(97, 23);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 175);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBecario);
            this.Controls.Add(this.buttonJefeDepartamento);
            this.Controls.Add(this.buttonCualificado);
            this.Controls.Add(this.buttonObrero);
            this.Name = "FormAñadir";
            this.Text = "Selecciona el tipo de Empleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonObrero;
        private System.Windows.Forms.Button buttonCualificado;
        private System.Windows.Forms.Button buttonJefeDepartamento;
        private System.Windows.Forms.Button buttonBecario;
        private System.Windows.Forms.Button buttonCancelar;
    }
}