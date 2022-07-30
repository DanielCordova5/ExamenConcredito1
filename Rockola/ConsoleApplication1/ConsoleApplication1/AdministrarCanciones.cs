using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AdministrarCanciones
    {
        public List<Rockola> ListCancion = new List<Rockola>();

        public void MenuRockola(List<Rockola> ListOpciones)
        {
            ListadeCanciones(ListOpciones);
            Console.Clear();
            int opc = 0;
            do
            {
                try
                {
                    Console.WriteLine("                Rockola");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("                Canciones  ");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("¿CUAL DESEA REPRODUCIR?");
                    TodasLasCanciones(ListOpciones);

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo números\n");
                }

                switch (opc)
                {
                    case 1:
                        ReproducirCancion(ListOpciones, 1);
                        break;
                    case 2:
                        ReproducirCancion(ListOpciones, 2);
                        break;
                    case 3:
                        ReproducirCancion(ListOpciones, 3);
                        break;
                    case 4:
                        ReproducirCancion(ListOpciones, 4);
                        break;
                    case 5:
                        Console.Clear();
                        ListOpciones.Clear();
                        break;
                }
            } while (opc != 5);
        }

        public void TodasLasCanciones(List<Rockola> ListOpciones)
        {
            int cont = 0;
            foreach (Rockola r in ListOpciones)
            {
                if (r.album == "")
                {
                    Console.WriteLine("Todavía no hay canciones en la rockola, vuelva mas tarde.");
                    break;
                }
                cont++;
                Console.WriteLine("({0}).- " + "Cancion: {1} | Artista: {2} | Album: {3} | Duracion: {4}", cont, r.cancion, r.artista, r.album, r.duracion);
            }
            Console.WriteLine("Para salir del menú actual pulse 5");
            Console.WriteLine();
        }

        public void ListadeCanciones(List<Rockola> ListOpciones)
        {
            Rockola cancion1 = new Rockola("Asgaror", "Mi propia magia", "Invicto", "4:50", "Folk Metal");
            Rockola cancion2 = new Rockola("Asgaror", "Mi propia magia", "Mi propia magia", "4:33", "Folk Metal");
            Rockola cancion3 = new Rockola("Asgaror", "Mi propia magia", "Sin mi", "5:40", "Melodic Metal Ballad");
            Rockola cancion4 = new Rockola("Asgaror", "Mi propia magia", "En el más allá", "7:40", "Folk Metal");

            ListOpciones.Add(cancion1);
            ListOpciones.Add(cancion2);
            ListOpciones.Add(cancion3);
            ListOpciones.Add(cancion4);
        }

        public void ReproducirCancion(List<Rockola> ListOpciones, int contador)
        {
            int opc = 0;
            int cont = 0;
            Console.Clear();
            foreach (Rockola r in ListOpciones)
            {
                cont++;
                if (cont == contador){
                    Console.WriteLine("Usted está escuchando: {0} - {1}", r.cancion, r.artista);
                    Console.WriteLine("Para parar la reproducción, pulse 1");
                    do
                    {
                        opc = Convert.ToInt32(Console.ReadLine());
                        switch (opc)
                        {
                            case 1:
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Teclea una opción correcta");
                                break;
                        }
                    } while (opc != 1);

                }

            }
        }
    }
}
