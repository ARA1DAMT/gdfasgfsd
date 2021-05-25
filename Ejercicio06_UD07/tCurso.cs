using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06_UD07
{
    public class tCurso
    {
        //Miembros
        private string mNombre;
        private int mCodigo;

        //Propiedades
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        public int Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        //Constructor
        public tCurso()
        {
            Nombre = "";
            Codigo = 0;
        }

        public string mostrarCursos()
        {
            string res = "";

            res += "- Curso: " + mNombre + "\n";
            res += "- Codigo: " + mCodigo + "\n--------------------------\n";

            return res;
        }

    }
}
