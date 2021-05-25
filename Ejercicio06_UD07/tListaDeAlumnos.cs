using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio06_UD07
{
    public class tListaDeAlumnos
    {
        private ArrayList listaAlumnos;

        public tListaDeAlumnos()
        {
            listaAlumnos = new ArrayList();
        }

        public int buscarAlumno(string nombre)
        {
            bool encontrado = false;

            int i = 0, pos = -1;

            tAlumno alumno;

            while (i < listaAlumnos.Count && encontrado == false)
            {
                alumno = (tAlumno)listaAlumnos[i];

                if (alumno.Nombre == nombre)
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

        public void anyadirAlumno(string nombre, string dni, int telefono, int codigo)
        {
            tAlumno alumno = new tAlumno();

            alumno.Nombre = nombre;
            alumno.DNI = dni;
            alumno.Telefono = telefono;
            alumno.CodigoCurso = codigo;

            listaAlumnos.Add(alumno);
        } 

        public bool anyadirNota(string nombre, double nota)
        {
            bool anyadido = false;
            int pos = buscarAlumno(nombre);
            tAlumno alu;

            if (pos >= 0)
            {
                if (nota >= 0 && nota <= 10)
                {

                    alu = (tAlumno)listaAlumnos[pos];
                    alu.anyadirNota(nota);
                    anyadido = true;
                }
            }

            return anyadido;
        }

        public string mostrarAlumno(string nombre)
        {
            string res = "";
            int pos = buscarAlumno(nombre);
            tAlumno alu;

            if (pos >= 0)
            {
                alu = (tAlumno)listaAlumnos[pos];

                res = res + alu.mostrarAlumno();
            }
            if (res.Length == 0)
            {
                res = "No se ha encontrado el alumno.";
            }

            return res;
        }

        public string mostrarListaAlumnos()
        {
            string texto = "La lista de alumnos es: \n\n";

            foreach (tAlumno alu in listaAlumnos)
            {
                texto += alu.mostrarAlumno();
            }

            return texto;
        } 

        public bool eliminarAlumno(string nombre)
        {
            bool eliminado = false;

            int pos = buscarAlumno(nombre);

            if (pos >= 0)
            {
                listaAlumnos.RemoveAt(pos);
                eliminado = true;
            }

            return eliminado;
        } 

        public bool eliminarNotas(string nombre)
        {
            bool eliminado = false;
            int pos = buscarAlumno(nombre);
            tAlumno alu;

            if (pos >= 0)
            {
                alu = (tAlumno)listaAlumnos[pos];
                alu.eliminarNotas();
                eliminado = true;
            }

            return eliminado;
        } 

        public string mostrarAlumnosMediaAprobado()
        {
            string res = "La lista de alumnos aprobados es: \n\n";

            tAlumno alu;

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                alu = (tAlumno)listaAlumnos[i];

                if (alu.notaMedia() >= 5)
                {
                    res += alu.mostrarAlumno();
                }
            }
            if (res.Length == 36)
            {
                res = "No hay alumnos aprobados.";
            }

            return res;
        } 

        public string mostrarAlumnoaMediaSuspenso()
        {
            string res = "La lista de alumnos suspensos es: \n\n";
            tAlumno alu;

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                alu = (tAlumno)listaAlumnos[i];

                if (alu.notaMedia() < 5)
                {
                    res += alu.mostrarAlumno();
                }
            }
            if (res.Length == 36)
            {
                res = "No hay alumnos suspensos.";
            }

            return res;
        } 

        public bool ordenarAlfabeticamente()
        {
            bool ordenado = false;
            tAlumno alu_i, alu_j;

            for (int i = 0; i < listaAlumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < listaAlumnos.Count; j++)
                {
                    alu_i = (tAlumno)listaAlumnos[i];
                    alu_j = (tAlumno)listaAlumnos[j];

                    if (String.Compare(alu_i.Nombre, alu_j.Nombre) > 0)
                    {
                        listaAlumnos[i] = alu_j;
                        listaAlumnos[j] = alu_i;
                        ordenado = true;
                    }
                }
            }

            return ordenado;
        } 

        public string mostrarAlumnosCurso(int codigo)
        {
            string res = "";

            foreach (tAlumno alumno in listaAlumnos)
            {
                if (codigo == alumno.CodigoCurso)
                {
                    res += "El alumno " + alumno.Nombre + " pertenece al curso " + alumno.CodigoCurso + "\n\n";
                }
            }
            if (res.Length == 0)
            {
                res = "No se encuentran alumnos matriculados en el curso o no existe el mismo.";
            }

            return res;
        } 
    }
}
