using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_SmashClassificator
{
    class Program
    {
        static List<Personaje> Personajes;
        static void Main(string[] args)
        {
            CargarPersonajes();
            while (true)
            {
                Console.WriteLine("Escriba una opcion:\nA) Clasificar personaje\nB) Listar Personajes\nC) Listar Personajes y Clasificaciones\nD) Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "A":
                        Console.Clear();
                        Console.WriteLine("Escribe el nombre de personaje...");
                        ClasificarPersonaje(Console.ReadLine());
                        break;
                    case "B":
                        Console.Clear();
                        ListarPersonajes();
                        break;
                    case "C":
                        Console.Clear();
                        ListarPersonajesClasificados();
                        break;
                    case "D":
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No existe dicha opcion...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        public static void CargarPersonajes()
        {
            Personajes = new List<Personaje>();

            /*Mario*/
            Personajes.Add(new Personaje("Mario", TipoArma.Puño, TipoPoder.Fisico, 999, 999));

        }

        public static void ClasificarPersonaje(string personaje)
        {
            bool aux = false;
            Personajes.ForEach(x =>
                {
                    if (x.Nombre == personaje)
                    {
                        aux = true;
                        Console.WriteLine(x.Nombre);
                        Console.WriteLine("Tipo Combate: " + ClasificadorTipoCombate(x));
                        Console.WriteLine("Altura: " + ClasificadorAltura(x));
                        Console.WriteLine("Peso: " + ClasificadorPeso(x));
                        Console.WriteLine("Velocidad: " + ClasificadorVelocidad(x)); 
                    }
                }
                );
            if (!aux)
            {
                Console.WriteLine("No existe este personaje..."); 
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void ListarPersonajes()
        { 
            Personajes.ForEach(x=>
            Console.WriteLine(x.Nombre));
            Console.ReadLine();
            Console.Clear();
        }

        public static void ListarPersonajesClasificados()
        {
            Personajes.ForEach(x =>
                {
                    Console.WriteLine(x.Nombre);
                    Console.WriteLine("Tipo Combate: " + ClasificadorTipoCombate(x));
                    Console.WriteLine("Altura: "+  ClasificadorAltura(x));
                    Console.WriteLine("Peso: " + ClasificadorPeso(x));
                    Console.WriteLine("Velocidad: " + ClasificadorVelocidad(x)); 
                }
            );
            Console.ReadLine();
            Console.Clear();
        }

        public static string ClasificadorAltura(Personaje personaje)
        {
            /*
             Alta
             Mediana
             Baja
             */
            return "YOLO";
        }

        public static string ClasificadorPeso(Personaje personaje)
        {
            /*
             Pesado
             Mediano
             Ligero
             */
            return "YOLO";
        }

        public static string ClasificadorVelocidad(Personaje personaje)
        {
            /*
             Rapido
             Normal
             Lento
             */
            return "YOLO";
        }

        public static string ClasificadorTipoCombate(Personaje personaje)
        {
            /*
             CloseRange
             LongRange
             HybridRange
             */
            return "YOLO";
        }

    }
}
