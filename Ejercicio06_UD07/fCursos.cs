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
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        public tListaDeCursos listaCursos;
        public tListaDeAlumnos listaAlumnos;
        public tListaDeProfesores listaProfes;

        private void bAnyadirCurso_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Interaction.InputBox("Introduce el nombre del curso.");
                int codigo = int.Parse(Interaction.InputBox("Introduce el codigo."));

                bool cursoExiste = listaCursos.comprobarCursoExiste(codigo);

                if (!cursoExiste)
                {
                    listaCursos.anyadirCurso(nombre, codigo);
                    MessageBox.Show("El curso se ha añadido correctamente.");
                }
                else
                {
                    MessageBox.Show("El curso no se ha añadido porque el codigo ya está siendo utilizado.");
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:\n\n" + fEx.Message);
            }
        } 

        private void bEliminarCurso_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del curso que quieres eliminar.");

            bool eliminado = listaCursos.eliminarCurso(nombre);

            if (eliminado)
            {
                MessageBox.Show("El curso se ha eliminado correctamente. ");
            }
            else
            {
                MessageBox.Show("El curso no se ha eliminado.");
            }

        } 

        private void bMostrarCursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaCursos.mostrarCursos());
        } 

        private void bMostrarAlumnosCurso_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(Interaction.InputBox("Introduce el codigo de un curso."));

                MessageBox.Show(listaAlumnos.mostrarAlumnosCurso(codigo));
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:\n\n" + fEx.Message);
            }
        } 
    }
}
