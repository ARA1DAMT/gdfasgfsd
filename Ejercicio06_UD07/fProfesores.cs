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
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }

        public tListaDeProfesores listaProfesores;
        public tListaDeCursos listaCursos;
        public tListaDeAlumnos listaAlumnos;

        private void bAnyadirProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, dni;
                int telefono, codigo;

                nombre = Interaction.InputBox("Introduce el nombre.");
                dni = Interaction.InputBox("Introduce el DNI.");
                 telefono = int.Parse(Interaction.InputBox("Introduce el telefono."));
                 codigo = int.Parse(Interaction.InputBox("Introduce el Codigo del curso del que es tutor.\n\nSi el profesor no es tutor introduzca un 0"));

                listaProfesores.anyadirProfesor(nombre, dni, telefono, codigo);
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: \n\n" + fEx.Message);
            }
        } 

        private void bEliminarProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre.");

            bool eliminado = listaProfesores.eliminarProfesor(nombre);

            if (eliminado)
            {
                MessageBox.Show("Se ha eliminado el profesor.");
            }
            else
            {
                MessageBox.Show("No se ha eliminado el profesor.");
            }
        } 

        private void bMostrarListaProfes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaProfesores.mostrarListaProfesores());
        } 

        private void bOrdenarProfesAlfabeticamente_Click(object sender, EventArgs e)
        {
            bool ordenado = listaProfesores.ordenarAlfabeticamente();

            if (ordenado)
            {
                MessageBox.Show(listaProfesores.mostrarListaProfesores());
            }
            else
            {
                MessageBox.Show("La lista no se ha podido ordenar.");
            }
        } 

        private void bMostrarDatosProfesores_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre.");

            MessageBox.Show(listaProfesores.mostrarProfesor(nombre));
        } 

        private void bEliminarAsignaturaProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del profesor al que se le quiere eliminar las asignaturas.");
            bool eliminado;

            eliminado = listaProfesores.eliminarAsignaturasProfesor(nombre);

            if (eliminado)
            {
                MessageBox.Show("Se han eliminado las asignaturas correctamente.");
            }
            else
            {
                MessageBox.Show("No se han podido eliminar las asignaturas.");
            }
        } 

        private void bMostrarProfesoresAsignatura_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaProfesores.mostrarAsignaturas());
        } 

        private void bAnyadirAsignaturaProfesor_Click(object sender, EventArgs e)
        {
            string nombre, asignatura;
            bool anyadido = false;

            nombre = Interaction.InputBox("Introduce el nombre del profesor.");
            asignatura = Interaction.InputBox("Introduce la asignatura");

            anyadido = listaProfesores.anyadirAsignatura(nombre, asignatura);

            if (anyadido)
            {
                MessageBox.Show("Se han guardado los cambios.");
            }
            else
            {
                MessageBox.Show("No se han guardado los cambios.");
            }
        } 
    }
}
