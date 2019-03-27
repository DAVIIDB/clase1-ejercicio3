using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> gente = new Dictionary<String, int>();

            gente.Add("Juan", 55423412);
            gente.Add("Ernesto", 56985623);
            gente.Add("Mariana", 54787451);


            if (gente.ContainsKey("Juan"))
                Console.WriteLine("El valor es" + gente["Juan"]);
            if (gente.ContainsKey("Pedro"))
                Console.WriteLine("El valor de Pedro es:" + gente["Pedro"]);
            else
                Console.WriteLine("El nombre no existe");
            foreach (var item in gente)
            {
                Console.WriteLine(item);
            }
            gente.Remove("Mariana");

            gente.Add("Mariana", 58251425);

            Console.WriteLine("El nuevo valor de Mariana es" + gente["Mariana"]);





        }
    }
}
