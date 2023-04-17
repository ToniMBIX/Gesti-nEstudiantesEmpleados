namespace GestiónEstudiantesEmpleados
{
    partial class FormPrincipal
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelSueldoBase = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelDestinoTrabajo = new System.Windows.Forms.Label();
            this.labelHorasExtra = new System.Windows.Forms.Label();
            this.labelPrecioHE = new System.Windows.Forms.Label();
            this.labelTitulación = new System.Windows.Forms.Label();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelDepartamento = new System.Windows.Forms.Label();
            this.labelJefeDepartamento = new System.Windows.Forms.Label();
            this.labelTotalTrabaCargo = new System.Windows.Forms.Label();
            this.labelProyectos = new System.Windows.Forms.Label();
            this.labelPlusJefeDepartamento = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelExamenes = new System.Windows.Forms.Label();
            this.labelNotaMedia = new System.Windows.Forms.Label();
            this.labelUniversidad = new System.Windows.Forms.Label();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellidos});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(12, 398);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(428, 40);
            this.buttonAñadir.TabIndex = 1;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(446, 398);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(470, 40);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(562, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 16);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(562, 30);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(67, 16);
            this.labelApellidos.TabIndex = 4;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelSueldoBase
            // 
            this.labelSueldoBase.AutoSize = true;
            this.labelSueldoBase.Location = new System.Drawing.Point(562, 51);
            this.labelSueldoBase.Name = "labelSueldoBase";
            this.labelSueldoBase.Size = new System.Drawing.Size(88, 16);
            this.labelSueldoBase.TabIndex = 5;
            this.labelSueldoBase.Text = "Sueldo Base:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(562, 71);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(33, 16);
            this.labelDNI.TabIndex = 6;
            this.labelDNI.Text = "DNI:";
            // 
            // labelDestinoTrabajo
            // 
            this.labelDestinoTrabajo.AutoSize = true;
            this.labelDestinoTrabajo.Location = new System.Drawing.Point(562, 90);
            this.labelDestinoTrabajo.Name = "labelDestinoTrabajo";
            this.labelDestinoTrabajo.Size = new System.Drawing.Size(107, 16);
            this.labelDestinoTrabajo.TabIndex = 7;
            this.labelDestinoTrabajo.Text = "Destino Trabajo:";
            // 
            // labelHorasExtra
            // 
            this.labelHorasExtra.AutoSize = true;
            this.labelHorasExtra.Location = new System.Drawing.Point(562, 110);
            this.labelHorasExtra.Name = "labelHorasExtra";
            this.labelHorasExtra.Size = new System.Drawing.Size(80, 16);
            this.labelHorasExtra.TabIndex = 8;
            this.labelHorasExtra.Text = "Horas Extra:";
            // 
            // labelPrecioHE
            // 
            this.labelPrecioHE.AutoSize = true;
            this.labelPrecioHE.Location = new System.Drawing.Point(562, 129);
            this.labelPrecioHE.Name = "labelPrecioHE";
            this.labelPrecioHE.Size = new System.Drawing.Size(115, 16);
            this.labelPrecioHE.TabIndex = 9;
            this.labelPrecioHE.Text = "Precio Hora Extra:";
            // 
            // labelTitulación
            // 
            this.labelTitulación.AutoSize = true;
            this.labelTitulación.Location = new System.Drawing.Point(562, 150);
            this.labelTitulación.Name = "labelTitulación";
            this.labelTitulación.Size = new System.Drawing.Size(71, 16);
            this.labelTitulación.TabIndex = 10;
            this.labelTitulación.Text = "Titulación: ";
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Location = new System.Drawing.Point(562, 172);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(36, 16);
            this.labelPlus.TabIndex = 11;
            this.labelPlus.Text = "Plus:";
            // 
            // labelDepartamento
            // 
            this.labelDepartamento.AutoSize = true;
            this.labelDepartamento.Location = new System.Drawing.Point(562, 190);
            this.labelDepartamento.Name = "labelDepartamento";
            this.labelDepartamento.Size = new System.Drawing.Size(99, 16);
            this.labelDepartamento.TabIndex = 12;
            this.labelDepartamento.Text = "Departamento: ";
            // 
            // labelJefeDepartamento
            // 
            this.labelJefeDepartamento.AutoSize = true;
            this.labelJefeDepartamento.Location = new System.Drawing.Point(562, 211);
            this.labelJefeDepartamento.Name = "labelJefeDepartamento";
            this.labelJefeDepartamento.Size = new System.Drawing.Size(165, 16);
            this.labelJefeDepartamento.TabIndex = 13;
            this.labelJefeDepartamento.Text = "Jefe de Departamento: No";
            // 
            // labelTotalTrabaCargo
            // 
            this.labelTotalTrabaCargo.AutoSize = true;
            this.labelTotalTrabaCargo.Location = new System.Drawing.Point(562, 233);
            this.labelTotalTrabaCargo.Name = "labelTotalTrabaCargo";
            this.labelTotalTrabaCargo.Size = new System.Drawing.Size(143, 16);
            this.labelTotalTrabaCargo.TabIndex = 14;
            this.labelTotalTrabaCargo.Text = "Total Trabajo a Cargo:";
            // 
            // labelProyectos
            // 
            this.labelProyectos.AutoSize = true;
            this.labelProyectos.Location = new System.Drawing.Point(562, 254);
            this.labelProyectos.Name = "labelProyectos";
            this.labelProyectos.Size = new System.Drawing.Size(71, 16);
            this.labelProyectos.TabIndex = 15;
            this.labelProyectos.Text = "Proyectos:";
            // 
            // labelPlusJefeDepartamento
            // 
            this.labelPlusJefeDepartamento.AutoSize = true;
            this.labelPlusJefeDepartamento.Location = new System.Drawing.Point(562, 276);
            this.labelPlusJefeDepartamento.Name = "labelPlusJefeDepartamento";
            this.labelPlusJefeDepartamento.Size = new System.Drawing.Size(65, 16);
            this.labelPlusJefeDepartamento.TabIndex = 16;
            this.labelPlusJefeDepartamento.Text = "Plus Jefe:";
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Location = new System.Drawing.Point(562, 314);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(55, 16);
            this.labelCarrera.TabIndex = 17;
            this.labelCarrera.Text = "Carrera:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(562, 332);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(45, 16);
            this.labelCurso.TabIndex = 18;
            this.labelCurso.Text = "Curso:";
            // 
            // labelExamenes
            // 
            this.labelExamenes.AutoSize = true;
            this.labelExamenes.Location = new System.Drawing.Point(562, 351);
            this.labelExamenes.Name = "labelExamenes";
            this.labelExamenes.Size = new System.Drawing.Size(77, 16);
            this.labelExamenes.TabIndex = 19;
            this.labelExamenes.Text = "Exámenes: ";
            // 
            // labelNotaMedia
            // 
            this.labelNotaMedia.AutoSize = true;
            this.labelNotaMedia.Location = new System.Drawing.Point(562, 373);
            this.labelNotaMedia.Name = "labelNotaMedia";
            this.labelNotaMedia.Size = new System.Drawing.Size(80, 16);
            this.labelNotaMedia.TabIndex = 20;
            this.labelNotaMedia.Text = "Nota Media:";
            // 
            // labelUniversidad
            // 
            this.labelUniversidad.AutoSize = true;
            this.labelUniversidad.Location = new System.Drawing.Point(562, 294);
            this.labelUniversidad.Name = "labelUniversidad";
            this.labelUniversidad.Size = new System.Drawing.Size(83, 16);
            this.labelUniversidad.TabIndex = 21;
            this.labelUniversidad.Text = "Universidad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.labelUniversidad);
            this.Controls.Add(this.labelNotaMedia);
            this.Controls.Add(this.labelExamenes);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.labelCarrera);
            this.Controls.Add(this.labelPlusJefeDepartamento);
            this.Controls.Add(this.labelProyectos);
            this.Controls.Add(this.labelTotalTrabaCargo);
            this.Controls.Add(this.labelJefeDepartamento);
            this.Controls.Add(this.labelDepartamento);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.labelTitulación);
            this.Controls.Add(this.labelPrecioHE);
            this.Controls.Add(this.labelHorasExtra);
            this.Controls.Add(this.labelDestinoTrabajo);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelSueldoBase);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Gestión de Estudiantes-Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelSueldoBase;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelDestinoTrabajo;
        private System.Windows.Forms.Label labelHorasExtra;
        private System.Windows.Forms.Label labelPrecioHE;
        private System.Windows.Forms.Label labelTitulación;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelDepartamento;
        private System.Windows.Forms.Label labelJefeDepartamento;
        private System.Windows.Forms.Label labelTotalTrabaCargo;
        private System.Windows.Forms.Label labelProyectos;
        private System.Windows.Forms.Label labelPlusJefeDepartamento;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelExamenes;
        private System.Windows.Forms.Label labelNotaMedia;
        private System.Windows.Forms.Label labelUniversidad;
    }
}

