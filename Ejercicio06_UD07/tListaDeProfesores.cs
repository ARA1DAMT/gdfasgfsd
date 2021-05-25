using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06_UD07
{
    public class tListaDeProfesores
    {

        private ArrayList mListaProfes;

        public tListaDeProfesores()
        {
            mListaProfes = new ArrayList();
        }

        public void anyadirProfesor(string nombre, string dni, int telefono, int codigo)  //? OK
        {
            tProfesor profe = new tProfesor();

            profe.Nombre = nombre;
            profe.DNI = dni;
            profe.Telefono = telefono;
            profe.CodigoCursoTutor = codigo;

            mListaProfes.Add(profe);
        }

        public bool eliminarProfesor(string nombre)
        {
            bool eliminado = false;
            int pos = buscarProfesor(nombre);

            if (pos >= 0)
            {
                mListaProfes.RemoveAt(pos);
                eliminado = true;
            }

            return eliminado;
        }  //? OK

        public int buscarProfesor(string nombre)
        {
            tProfesor profe;
            int pos = -1, i = 0;
            bool encontrado = false;

            while (i < mListaProfes.Count && encontrado == false)
            {
                profe = (tProfesor)mListaProfes[i];

                if (profe.Nombre == nombre)
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
        }  //? OK

        public string mostrarProfesor(string nombre)
        {
            string res = "";
            int pos = buscarProfesor(nombre);
            tProfesor profe;

            if (pos >= 0)
            {
                profe = (tProfesor)mListaProfes[pos];
                res += profe.mostrarProfesor();
            }
            if (res.Length == 0)
            {
                res = "No se ha encontrado al profesor.";
            }

            return res;
        }

        public bool ordenarAlfabeticamente()
        {
            bool ordenado = false;
            tProfesor profe_i, profe_j;

            for (int i = 0; i < mListaProfes.Count - 1; i++)
            {
                for (int j = i + 1; j < mListaProfes.Count; j++)
                {
                    profe_i = (tProfesor)mListaProfes[i];
                    profe_j = (tProfesor)mListaProfes[j];

                    if (string.Compare(profe_i.Nombre, profe_j.Nombre) > 0)
                    {
                        mListaProfes[i] = profe_j;
                        mListaProfes[j] = profe_i;
                        ordenado = true;
                    }
                }
            }

            return ordenado;
        }

        public string mostrarListaProfesores()
        {
            string res = "La lista de profesores es: \n\n";

            foreach (tProfesor profe in mListaProfes)
            {
                res += profe.mostrarProfesor();
            }

            return res;
        }

        public bool anyadirAsignatura(string nombre, string asignatura)
        {
            bool anyadido = false;
            tProfesor profe;

            int pos = buscarProfesor(nombre);

            if (pos >= 0)
            {
                profe = (tProfesor)mListaProfes[pos];
                profe.anyadirAsignaturaProfe(asignatura);
                anyadido = true;
            }

            return anyadido;
        }

        public string mostrarAsignaturas()
        {
            string res = "";

            foreach (tProfesor profesor in mListaProfes)
            {
                if (mListaProfes.Count >= 0)
                {
                    res += profesor.mostrarAsignatura();
                }
            }

            return res;
        }

        public bool eliminarAsignaturasProfesor(string nombre)
        {
            bool eliminado = false;
            int pos = buscarProfesor(nombre);
            tProfesor profe;

            if (pos >= 0)
            {
                profe = (tProfesor)mListaProfes[pos];
                profe.eliminarAsignaturas();
                eliminado = true;
            }

            return eliminado;
        }
    }
}
