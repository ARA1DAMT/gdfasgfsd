using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio06_UD07
{
    public class tProfesor
    {
        //Miembros

        private string mNombre;
        private string mDNI;
        private int mTelefono;
        private int mCodigoCursoTutor;

        private ArrayList mAsignaturas = new ArrayList();

        //Propiedades
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
        }
        public int Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }
        public int CodigoCursoTutor
        {
            get { return mCodigoCursoTutor; }
            set { mCodigoCursoTutor = value; }
        }

        //Constructor
        public tProfesor()
        {
            mNombre = "";
            mDNI = "";
            mTelefono = 0;
            mCodigoCursoTutor = 0;
        }

        public string mostrarProfesor()
        {
            string res = "";

            res += "Nombre: " + mNombre + "\n";
            res += "DNI: " + mDNI + "\n";
            res += "Telefono: " + mTelefono + "\n";
            if (CodigoCursoTutor > 0)
            {
                res += "Codigo del curso en el que es tutor: " + mCodigoCursoTutor + "\n---------------------------\n";
            }
            else
            {
                res += "---------------------------\n";
            }

            return res;
        }

        public void anyadirAsignaturaProfe(string asignatura)
        {
            mAsignaturas.Add(asignatura);
        }

        public string mostrarAsignatura()
        {
            string res = "";

            if (mAsignaturas.Count > 0)
            {
                res = "Las asignaturas de " + mNombre + " son: ";

                foreach (string  asigna in mAsignaturas)
                {
                    res += asigna + ", ";
                }
            }
            res += "\n";

            return res;
        }

        public void eliminarAsignaturas()
        {
            mAsignaturas.Clear();
        }
    }
}
