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
    public partial class fGestionInstituto : Form
    {
        public fGestionInstituto()
        {
            InitializeComponent();
        }

        //Se crea la lista de cursos
        tListaDeCursos listaCursos = new tListaDeCursos();

        //Se crea la lista de alumnos
        tListaDeAlumnos listaAlumnos = new tListaDeAlumnos();

        //Se crea la lista de profesores
        tListaDeProfesores listaProfes = new tListaDeProfesores();

        private void bGestionCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos();

            fCur.listaCursos = listaCursos;
            fCur.listaAlumnos = listaAlumnos;
            fCur.listaProfes = listaProfes;

            fCur.ShowDialog();
        }

        private void bGestionAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlum = new fAlumnos();

            fAlum.listaAlumnos = listaAlumnos;
            fAlum.listaCursos = listaCursos;
            fAlum.listaProfes = listaProfes;

            fAlum.ShowDialog();
        }

        private void bGestionProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProf = new fProfesores();

            fProf.listaProfesores = listaProfes;
            fProf.listaCursos = listaCursos;
            fProf.listaAlumnos = listaAlumnos;

            fProf.ShowDialog();
        }
    }
}
