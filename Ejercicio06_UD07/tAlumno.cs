using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio06_UD07
{
    public class tAlumno
    {
        //Miembros
        private string mNombre;
        private string mDNI;
        private int mTelefono;
        private int mCodigoCurso;

        private ArrayList mNotas = new ArrayList();

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
        public int CodigoCurso
        {
            get { return mCodigoCurso; }
            set { mCodigoCurso = value; }
        }

        //Constructor
        public tAlumno()
        {
            mNombre = "";
            mDNI = "";
            mTelefono = 0;
            mCodigoCurso = 0;
        }

        //Metodos
        public string mostrarAlumno()
        {
            string texto = "";

            texto += "- Nombre: " + mNombre + "\n";
            texto += "- DNI: " + mDNI + "\n";
            texto += "- Telefono: " + mTelefono + "\n";
            texto += "- Código curso: " + mCodigoCurso + "\n";
            if (mNotas.Count > 0)
            {
                texto += "- Notas: " + mostrarNotas() + "\n--------------------------\n";
            }
            else
            {
                texto += "-------------------------\n";
            }

            return texto;
        }

        public void anyadirNota(double nota)
        {
            if (nota >= 0 && nota <= 10)
            {
                mNotas.Add(nota);
            }
        }  

        public string mostrarNotas()
        {
            string res = "";

            if (mNotas.Count >= 0)
            {
                foreach (double nota in mNotas)
                {
                    res += nota + " + ";
                }
            }

            return res;
        }

        public void eliminarNotas()
        {
            mNotas.Clear();
        } 

        public double notaMedia()
        {
            double media = 0;
            int count = 0;

            foreach (double nota in mNotas)
            {
                media += nota;
                count++;
            }

            media = media / count;

            return media;
        }
    }
}
