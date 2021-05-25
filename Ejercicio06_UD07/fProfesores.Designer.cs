
namespace Ejercicio06_UD07
{
    partial class fProfesores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOrdenarProfesAlfabeticamente = new System.Windows.Forms.Button();
            this.bMostrarListaProfes = new System.Windows.Forms.Button();
            this.bEliminarProfesor = new System.Windows.Forms.Button();
            this.bAnyadirProfesor = new System.Windows.Forms.Button();
            this.bMostrarDatosProfesores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAnyadirAsignaturaProfesor = new System.Windows.Forms.Button();
            this.bMostrarProfesoresAsignatura = new System.Windows.Forms.Button();
            this.bEliminarAsignaturaProfesor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bOrdenarProfesAlfabeticamente);
            this.groupBox1.Controls.Add(this.bMostrarListaProfes);
            this.groupBox1.Controls.Add(this.bEliminarProfesor);
            this.groupBox1.Controls.Add(this.bAnyadirProfesor);
            this.groupBox1.Controls.Add(this.bMostrarDatosProfesores);
            this.groupBox1.Location = new System.Drawing.Point(37, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // bOrdenarProfesAlfabeticamente
            // 
            this.bOrdenarProfesAlfabeticamente.Location = new System.Drawing.Point(84, 87);
            this.bOrdenarProfesAlfabeticamente.Name = "bOrdenarProfesAlfabeticamente";
            this.bOrdenarProfesAlfabeticamente.Size = new System.Drawing.Size(151, 41);
            this.bOrdenarProfesAlfabeticamente.TabIndex = 4;
            this.bOrdenarProfesAlfabeticamente.Text = "Ordenar profesores por orden alfabético";
            this.bOrdenarProfesAlfabeticamente.UseVisualStyleBackColor = true;
            this.bOrdenarProfesAlfabeticamente.Click += new System.EventHandler(this.bOrdenarProfesAlfabeticamente_Click);
            // 
            // bMostrarListaProfes
            // 
            this.bMostrarListaProfes.Location = new System.Drawing.Point(372, 30);
            this.bMostrarListaProfes.Name = "bMostrarListaProfes";
            this.bMostrarListaProfes.Size = new System.Drawing.Size(151, 41);
            this.bMostrarListaProfes.TabIndex = 3;
            this.bMostrarListaProfes.Text = "Mostrar lista profesores";
            this.bMostrarListaProfes.UseVisualStyleBackColor = true;
            this.bMostrarListaProfes.Click += new System.EventHandler(this.bMostrarListaProfes_Click);
            // 
            // bEliminarProfesor
            // 
            this.bEliminarProfesor.Location = new System.Drawing.Point(195, 30);
            this.bEliminarProfesor.Name = "bEliminarProfesor";
            this.bEliminarProfesor.Size = new System.Drawing.Size(151, 41);
            this.bEliminarProfesor.TabIndex = 2;
            this.bEliminarProfesor.Text = "Eliminar profesor";
            this.bEliminarProfesor.UseVisualStyleBackColor = true;
            this.bEliminarProfesor.Click += new System.EventHandler(this.bEliminarProfesor_Click);
            // 
            // bAnyadirProfesor
            // 
            this.bAnyadirProfesor.Location = new System.Drawing.Point(20, 30);
            this.bAnyadirProfesor.Name = "bAnyadirProfesor";
            this.bAnyadirProfesor.Size = new System.Drawing.Size(151, 41);
            this.bAnyadirProfesor.TabIndex = 1;
            this.bAnyadirProfesor.Text = "Introducir profesor";
            this.bAnyadirProfesor.UseVisualStyleBackColor = true;
            this.bAnyadirProfesor.Click += new System.EventHandler(this.bAnyadirProfesor_Click);
            // 
            // bMostrarDatosProfesores
            // 
            this.bMostrarDatosProfesores.Location = new System.Drawing.Point(277, 87);
            this.bMostrarDatosProfesores.Name = "bMostrarDatosProfesores";
            this.bMostrarDatosProfesores.Size = new System.Drawing.Size(151, 41);
            this.bMostrarDatosProfesores.TabIndex = 0;
            this.bMostrarDatosProfesores.Text = "Mostrar datos de los profesores";
            this.bMostrarDatosProfesores.UseVisualStyleBackColor = true;
            this.bMostrarDatosProfesores.Click += new System.EventHandler(this.bMostrarDatosProfesores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bAnyadirAsignaturaProfesor);
            this.groupBox2.Controls.Add(this.bMostrarProfesoresAsignatura);
            this.groupBox2.Controls.Add(this.bEliminarAsignaturaProfesor);
            this.groupBox2.Location = new System.Drawing.Point(37, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // bAnyadirAsignaturaProfesor
            // 
            this.bAnyadirAsignaturaProfesor.Location = new System.Drawing.Point(37, 29);
            this.bAnyadirAsignaturaProfesor.Name = "bAnyadirAsignaturaProfesor";
            this.bAnyadirAsignaturaProfesor.Size = new System.Drawing.Size(158, 50);
            this.bAnyadirAsignaturaProfesor.TabIndex = 3;
            this.bAnyadirAsignaturaProfesor.Text = "Añadir asignatura a un profesor";
            this.bAnyadirAsignaturaProfesor.UseVisualStyleBackColor = true;
            this.bAnyadirAsignaturaProfesor.Click += new System.EventHandler(this.bAnyadirAsignaturaProfesor_Click);
            // 
            // bMostrarProfesoresAsignatura
            // 
            this.bMostrarProfesoresAsignatura.Location = new System.Drawing.Point(188, 97);
            this.bMostrarProfesoresAsignatura.Name = "bMostrarProfesoresAsignatura";
            this.bMostrarProfesoresAsignatura.Size = new System.Drawing.Size(158, 50);
            this.bMostrarProfesoresAsignatura.TabIndex = 2;
            this.bMostrarProfesoresAsignatura.Text = "Mostrar profesores que imparten una asignatura";
            this.bMostrarProfesoresAsignatura.UseVisualStyleBackColor = true;
            this.bMostrarProfesoresAsignatura.Click += new System.EventHandler(this.bMostrarProfesoresAsignatura_Click);
            // 
            // bEliminarAsignaturaProfesor
            // 
            this.bEliminarAsignaturaProfesor.Location = new System.Drawing.Point(332, 29);
            this.bEliminarAsignaturaProfesor.Name = "bEliminarAsignaturaProfesor";
            this.bEliminarAsignaturaProfesor.Size = new System.Drawing.Size(158, 50);
            this.bEliminarAsignaturaProfesor.TabIndex = 1;
            this.bEliminarAsignaturaProfesor.Text = "Eliminar las asignaturas de un profesor";
            this.bEliminarAsignaturaProfesor.UseVisualStyleBackColor = true;
            this.bEliminarAsignaturaProfesor.Click += new System.EventHandler(this.bEliminarAsignaturaProfesor_Click);
            // 
            // fProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fProfesores";
            this.Text = "Gestión de profesores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarDatosProfesores;
        private System.Windows.Forms.Button bMostrarProfesoresAsignatura;
        private System.Windows.Forms.Button bEliminarAsignaturaProfesor;
        private System.Windows.Forms.Button bOrdenarProfesAlfabeticamente;
        private System.Windows.Forms.Button bMostrarListaProfes;
        private System.Windows.Forms.Button bEliminarProfesor;
        private System.Windows.Forms.Button bAnyadirProfesor;
        private System.Windows.Forms.Button bAnyadirAsignaturaProfesor;
    }
}