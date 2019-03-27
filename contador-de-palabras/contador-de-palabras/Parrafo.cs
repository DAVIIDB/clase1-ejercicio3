using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_de_palabras
{
    class Parrafo
    {
        private String palabras;
        public void setParrafo(String n)
        {

            palabras = n;

        }
        public String getParrafo()
        {

            return palabras;

        }

        public static implicit operator string(Parrafo v)
        {
            throw new NotImplementedException();
        }
    }
}
