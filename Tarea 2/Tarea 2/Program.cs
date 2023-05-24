using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo_e Triangulo_equi = new Triangulo_e(7, 7, 7, "Verde");
            Triangulo_es Triangulo_esca = new Triangulo_es(4, 4, 5 ,"Azul");           
            Triangulo_i Triangulo_iso = new Triangulo_i(4, 4, 3, "Amarillo");


            Triangulo_equi.MostrarDatos();

            Triangulo_esca.MostrarDatos();

            Triangulo_iso.MostrarDatos();

            Console.ReadKey();

        }
    }
}
