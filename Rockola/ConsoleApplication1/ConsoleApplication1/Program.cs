using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        AdministrarCanciones AC = new AdministrarCanciones();

        static void Main(string[] args)
        {
            Program p = new Program();

            int opc = 0;
            do
            {
                try
                {
                    Console.WriteLine("                 Rockola");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("           Selecciona una opción ");
                    Console.WriteLine("__________________________________________\n");
                    Console.WriteLine(" (1)  Ver lista de canciones ");
                    Console.WriteLine(" (2)  Salir\n");
                    Console.WriteLine("SELECCIONE UNA OPCIÓN");

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo se aceptan números\n");
                }

                switch (opc)
                {
                    case 1:
                        p.AC.MenuRockola(p.AC.ListCancion);
                        break;
                    case 2:
                        break;
                }
            } while (opc != 2);
        }
    }
}
