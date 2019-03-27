using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador_de_palabras
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<String> parrafo = new List<string>;

            Parrafo p = new Parrafo();

            Console.WriteLine("Escribi un parrafo\n");

            p.setParrafo(Console.ReadLine());

            String parrafob = "";

            // String palabras = "";

            parrafob = p.ToString();


            Console.WriteLine(parrafob);












        }
    }
}
