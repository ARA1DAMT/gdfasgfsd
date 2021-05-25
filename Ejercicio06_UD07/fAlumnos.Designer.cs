
namespace Ejercicio06_UD07
{
    partial class fAlumnos
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
            this.bMostrarAlumnosCurso = new System.Windows.Forms.Button();
            this.bMostrarAlumno = new System.Windows.Forms.Button();
            this.OrdenarAlumnosAlfabe = new System.Windows.Forms.Button();
            this.bMostrarListaAlmunos = new System.Windows.Forms.Button();
            this.bEliminarAlumno = new System.Windows.Forms.Button();
            this.bIntroducirAlumno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bMostrarMediaInferiorCinco = new System.Windows.Forms.Button();
            this.bEliminarNotasAlumno = new System.Windows.Forms.Button();
            this.bMostrarMediaCincoOMas = new System.Windows.Forms.Button();
            this.bAnyadirNotas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bMostrarAlumnosCurso);
            this.groupBox1.Controls.Add(this.bMostrarAlumno);
            this.groupBox1.Controls.Add(this.OrdenarAlumnosAlfabe);
            this.groupBox1.Controls.Add(this.bMostrarListaAlmunos);
            this.groupBox1.Controls.Add(this.bEliminarAlumno);
            this.groupBox1.Controls.Add(this.bIntroducirAlumno);
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // bMostrarAlumnosCurso
            // 
            this.bMostrarAlumnosCurso.Location = new System.Drawing.Point(384, 93);
            this.bMostrarAlumnosCurso.Name = "bMostrarAlumnosCurso";
            this.bMostrarAlumnosCurso.Size = new System.Drawing.Size(148, 44);
            this.bMostrarAlumnosCurso.TabIndex = 6;
            this.bMostrarAlumnosCurso.Text = "Mostrar alumnos de un curso";
            this.bMostrarAlumnosCurso.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosCurso.Click += new System.EventHandler(this.bMostrarAlumnosCurso_Click);
            // 
            // bMostrarAlumno
            // 
            this.bMostrarAlumno.Location = new System.Drawing.Point(207, 93);
            this.bMostrarAlumno.Name = "bMostrarAlumno";
            this.bMostrarAlumno.Size = new System.Drawing.Size(148, 44);
            this.bMostrarAlumno.TabIndex = 5;
            this.bMostrarAlumno.Text = "Mostrar datos de un alumno";
            this.bMostrarAlumno.UseVisualStyleBackColor = true;
            this.bMostrarAlumno.Click += new System.EventHandler(this.bMostrarAlumno_Click);
            // 
            // OrdenarAlumnosAlfabe
            // 
            this.OrdenarAlumnosAlfabe.Location = new System.Drawing.Point(32, 93);
            this.OrdenarAlumnosAlfabe.Name = "OrdenarAlumnosAlfabe";
            this.OrdenarAlumnosAlfabe.Size = new System.Drawing.Size(148, 44);
            this.OrdenarAlumnosAlfabe.TabIndex = 4;
            this.OrdenarAlumnosAlfabe.Text = "Ordenar alumnos alfabeticamente";
            this.OrdenarAlumnosAlfabe.UseVisualStyleBackColor = true;
            this.OrdenarAlumnosAlfabe.Click += new System.EventHandler(this.OrdenarAlumnosAlfabe_Click);
            // 
            // bMostrarListaAlmunos
            // 
            this.bMostrarListaAlmunos.Location = new System.Drawing.Point(384, 28);
            this.bMostrarListaAlmunos.Name = "bMostrarListaAlmunos";
            this.bMostrarListaAlmunos.Size = new System.Drawing.Size(148, 44);
            this.bMostrarListaAlmunos.TabIndex = 3;
            this.bMostrarListaAlmunos.Text = "Mostrar lista de alumnos";
            this.bMostrarListaAlmunos.UseVisualStyleBackColor = true;
            this.bMostrarListaAlmunos.Click += new System.EventHandler(this.bMostrarListaAlmunos_Click);
            // 
            // bEliminarAlumno
            // 
            this.bEliminarAlumno.Location = new System.Drawing.Point(207, 28);
            this.bEliminarAlumno.Name = "bEliminarAlumno";
            this.bEliminarAlumno.Size = new System.Drawing.Size(148, 44);
            this.bEliminarAlumno.TabIndex = 2;
            this.bEliminarAlumno.Text = "Eliminar alumno";
            this.bEliminarAlumno.UseVisualStyleBackColor = true;
            this.bEliminarAlumno.Click += new System.EventHandler(this.bEliminarAlumno_Click);
            // 
            // bIntroducirAlumno
            // 
            this.bIntroducirAlumno.Location = new System.Drawing.Point(32, 28);
            this.bIntroducirAlumno.Name = "bIntroducirAlumno";
            this.bIntroducirAlumno.Size = new System.Drawing.Size(148, 44);
            this.bIntroducirAlumno.TabIndex = 1;
            this.bIntroducirAlumno.Text = "Introducir alumno";
            this.bIntroducirAlumno.UseVisualStyleBackColor = true;
            this.bIntroducirAlumno.Click += new System.EventHandler(this.bIntroducirAlumno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bMostrarMediaInferiorCinco);
            this.groupBox2.Controls.Add(this.bAnyadirNotas);
            this.groupBox2.Controls.Add(this.bEliminarNotasAlumno);
            this.groupBox2.Controls.Add(this.bMostrarMediaCincoOMas);
            this.groupBox2.Location = new System.Drawing.Point(28, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // bMostrarMediaInferiorCinco
            // 
            this.bMostrarMediaInferiorCinco.Location = new System.Drawing.Point(308, 88);
            this.bMostrarMediaInferiorCinco.Name = "bMostrarMediaInferiorCinco";
            this.bMostrarMediaInferiorCinco.Size = new System.Drawing.Size(183, 46);
            this.bMostrarMediaInferiorCinco.TabIndex = 3;
            this.bMostrarMediaInferiorCinco.Text = "Mostrar alumnos con nota media menor que 5";
            this.bMostrarMediaInferiorCinco.UseVisualStyleBackColor = true;
            this.bMostrarMediaInferiorCinco.Click += new System.EventHandler(this.bMostrarMediaInferiorCinco_Click);
            // 
            // bEliminarNotasAlumno
            // 
            this.bEliminarNotasAlumno.Location = new System.Drawing.Point(53, 88);
            this.bEliminarNotasAlumno.Name = "bEliminarNotasAlumno";
            this.bEliminarNotasAlumno.Size = new System.Drawing.Size(183, 46);
            this.bEliminarNotasAlumno.TabIndex = 2;
            this.bEliminarNotasAlumno.Text = "Eliminar notas de un alumno";
            this.bEliminarNotasAlumno.UseVisualStyleBackColor = true;
            this.bEliminarNotasAlumno.Click += new System.EventHandler(this.bEliminarNotasAlumno_Click);
            // 
            // bMostrarMediaCincoOMas
            // 
            this.bMostrarMediaCincoOMas.Location = new System.Drawing.Point(308, 25);
            this.bMostrarMediaCincoOMas.Name = "bMostrarMediaCincoOMas";
            this.bMostrarMediaCincoOMas.Size = new System.Drawing.Size(183, 46);
            this.bMostrarMediaCincoOMas.TabIndex = 1;
            this.bMostrarMediaCincoOMas.Text = "Mostrar alumnos con nota media de 5 o mayor";
            this.bMostrarMediaCincoOMas.UseVisualStyleBackColor = true;
            this.bMostrarMediaCincoOMas.Click += new System.EventHandler(this.bMostrarMediaCincoOMas_Click);
            // 
            // bAnyadirNotas
            // 
            this.bAnyadirNotas.Location = new System.Drawing.Point(53, 25);
            this.bAnyadirNotas.Name = "bAnyadirNotas";
            this.bAnyadirNotas.Size = new System.Drawing.Size(183, 46);
            this.bAnyadirNotas.TabIndex = 0;
            this.bAnyadirNotas.Text = "Añadir notas a un alumno";
            this.bAnyadirNotas.UseVisualStyleBackColor = true;
            this.bAnyadirNotas.Click += new System.EventHandler(this.bAnyadirNotas_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumnos";
            this.Text = "Gestión de alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bMostrarAlumnosCurso;
        private System.Windows.Forms.Button bMostrarAlumno;
        private System.Windows.Forms.Button OrdenarAlumnosAlfabe;
        private System.Windows.Forms.Button bMostrarListaAlmunos;
        private System.Windows.Forms.Button bEliminarAlumno;
        private System.Windows.Forms.Button bIntroducirAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarMediaInferiorCinco;
        private System.Windows.Forms.Button bEliminarNotasAlumno;
        private System.Windows.Forms.Button bMostrarMediaCincoOMas;
        private System.Windows.Forms.Button bAnyadirNotas;
    }
}