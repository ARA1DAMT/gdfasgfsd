using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06_UD07
{
    public class tListaDeCursos
    {
        private ArrayList listaCursos;

        public tListaDeCursos()
        {
            listaCursos = new ArrayList();
        }

        public void anyadirCurso(string nombre, int codigo)
        {
            tCurso curso = new tCurso();

            curso.Nombre = nombre;
            curso.Codigo = codigo;

            listaCursos.Add(curso);
        }

        public int buscarCurso(string nombre)
        {
            int i = 0, pos = -1;
            bool encontrado = false;
            tCurso curso;

            while (i < listaCursos.Count && !encontrado)
            {
                curso = (tCurso)listaCursos[i];

                if (curso.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
           
            return pos;
        }

        public bool eliminarCurso(string nombre)
        {
            bool eliminado = false;

            int pos = buscarCurso(nombre);

            if (pos >= 0)
            {
                listaCursos.RemoveAt(pos);
                eliminado = true;
            }

            return eliminado;
        }

        public string mostrarCursos()
        {
            string res = "Lista de cursos: \n\n";

            foreach (tCurso curso in listaCursos)
            {
                res += curso.mostrarCursos();
            }

            return res;
        }

        public bool comprobarCursoExiste(int codigo)
        {
            bool ok = false;

            foreach (tCurso curso in listaCursos)
            {
                if (curso.Codigo == codigo)
                {
                    ok = true;
                }
            }

            return ok;
        }
    }
}
