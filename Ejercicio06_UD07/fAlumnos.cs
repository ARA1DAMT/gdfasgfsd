using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06_UD07
{
    public partial class fAlumnos : Form
    {
        public fAlumnos()
        {
            InitializeComponent();
        }

        public tListaDeAlumnos listaAlumnos;
        public tListaDeCursos listaCursos;
        public tListaDeProfesores listaProfes;

        private void bIntroducirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, dni;
                int codigo = 0, telefono;
                bool codigoExiste = false;

                nombre = Interaction.InputBox("Introduce el nombre del alumno.");
                dni = Interaction.InputBox("Introduce el DNI del alumno.");
                telefono = int.Parse(Interaction.InputBox("Introduce el teléfono del alumno."));

                while (!codigoExiste)
                {
                    codigo = int.Parse(Interaction.InputBox("Introduce el código del curso."));

                    if (listaCursos.comprobarCursoExiste(codigo))
                    {
                        codigoExiste = true;
                    }
                    else
                    {
                        MessageBox.Show("El curso no existe.");
                    }
                }

                listaAlumnos.anyadirAlumno(nombre, dni, telefono, codigo);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: \n\n" + fEx.Message);
            }
        } 

        private void bEliminarAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del alumno.");
            bool eliminado;

            eliminado = listaAlumnos.eliminarAlumno(nombre);

            if (eliminado)
            {
                MessageBox.Show("El alumno se ha eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El alumno no se ha podido eliminar.");
            }
        } 

        private void bMostrarListaAlmunos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.mostrarListaAlumnos());
        } 

        private void OrdenarAlumnosAlfabe_Click(object sender, EventArgs e)
        {
            bool encontrado = listaAlumnos.ordenarAlfabeticamente();

            if (encontrado)
            {
                MessageBox.Show(listaAlumnos.mostrarListaAlumnos());
            }
            else
            {
                MessageBox.Show("La lista no se ha ordenado.");
            }
        } 

        private void bMostrarAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del alumno.");

            MessageBox.Show(listaAlumnos.mostrarAlumno(nombre));
        } 

        private void bMostrarAlumnosCurso_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(Interaction.InputBox("Introduce el codigo del curso."));

                MessageBox.Show(listaAlumnos.mostrarAlumnosCurso(codigo));
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show("Se ha producido el error: \n\n" + fEx.Message);
            }
        } 

        private void bAnyadirNotas_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = Interaction.InputBox("Introduce el nombre del alumno.");
                double nota = double.Parse(Interaction.InputBox("Introduce la nota."));


                bool anyadida = listaAlumnos.anyadirNota(nombre, nota);

                if (anyadida)
                {
                    MessageBox.Show("La nota se ha añadido correctamente.");
                }
                else
                {
                    MessageBox.Show("La nota no se ha añadido.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: \n\n" + fEx.Message);
            }
        } 

        private void bMostrarMediaCincoOMas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.mostrarAlumnosMediaAprobado());
        } 
        private void bMostrarMediaInferiorCinco_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.mostrarAlumnoaMediaSuspenso());
        } 

        private void bEliminarNotasAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del alumno.");
            bool eliminado;

            eliminado = listaAlumnos.eliminarNotas(nombre);

            if (eliminado)
            {
                MessageBox.Show("Las notas se han eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Las notas no se han eliminado.");
            }
        } 

    }
}
