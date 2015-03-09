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
            Personajes.Add(new Personaje("Mario", TipoArma.Puño, TipoPoder.Fisico, 35896572, 100));
            /*Pikachu*/
            Personajes.Add(new Personaje("Pikachu", TipoArma.Otra, TipoPoder.Elemental, 37051189, 80));
            /*Bowser*/
            Personajes.Add(new Personaje("Bowser", TipoArma.Puño, TipoPoder.Fisico, 36927977, 117));
            /*Peach*/
            Personajes.Add(new Personaje("Peach", TipoArma.Otra, TipoPoder.Magico, 36872929, 90));
            /*Yoshi*/
            Personajes.Add(new Personaje("Yoshi", TipoArma.Otra, TipoPoder.Fisico, 37789646, 108));
            /*Donkey Kong*/
            Personajes.Add(new Personaje("Donkey Kong", TipoArma.Puño, TipoPoder.Fisico, 38561139, 114));
            /*Captain Falcon*/
            Personajes.Add(new Personaje("Captain Falcon", TipoArma.Puño, TipoPoder.Fisico, 38749874, 104));
            /*Fox*/
            Personajes.Add(new Personaje("Fox", TipoArma.Pistola, TipoPoder.Fisico, 36851957, 75));
            /*Falco*/
            Personajes.Add(new Personaje("Falco", TipoArma.Pistola, TipoPoder.Fisico, 42152505, 80));
            /*Kirby*/
            Personajes.Add(new Personaje("Kirby", TipoArma.Puño, TipoPoder.Magico, 34323707, 70));
            /*Dr. Mario*/
            Personajes.Add(new Personaje("Dr. Mario", TipoArma.Puño, TipoPoder.Fisico, 35896572, 100));
            /*Luigi*/
            Personajes.Add(new Personaje("Luigi", TipoArma.Puño, TipoPoder.Fisico, 39909867, 100));
            /*Pichu*/
            Personajes.Add(new Personaje("Pichu", TipoArma.Otra, TipoPoder.Elemental, 37051189, 55));
            /*Ganondorf*/
            Personajes.Add(new Personaje("Ganondorf", TipoArma.Puño, TipoPoder.Magico, 35005283, 109));
            /*Samus*/
            Personajes.Add(new Personaje("Samus", TipoArma.Pistola, TipoPoder.Elemental, 37686626, 110));
            /*Zelda*/
            Personajes.Add(new Personaje("Zelda", TipoArma.Puño, TipoPoder.Magico, 36847244, 90));
            /*Sheik*/
            Personajes.Add(new Personaje("Sheik", TipoArma.Puño, TipoPoder.Magico, 37585964, 90));
            /*Link*/
            Personajes.Add(new Personaje("Link", TipoArma.Espada, TipoPoder.Fisico, 36247855, 104));
            /*Young Link*/
            Personajes.Add(new Personaje("Young Link", TipoArma.Espada, TipoPoder.Fisico, 37177018, 85));
            /*Mr. Game & Watch*/
            Personajes.Add(new Personaje("Mr. Game & Watch", TipoArma.Puño, TipoPoder.Magico, 35896572, 60));
            /*Marth*/
            Personajes.Add(new Personaje("Marth", TipoArma.Espada, TipoPoder.Fisico, 37850723, 87));
            /*Roy*/
            Personajes.Add(new Personaje("Roy", TipoArma.Espada, TipoPoder.Elemental, 36767546, 85));
            /*Ness*/
            Personajes.Add(new Personaje("Ness", TipoArma.Puño, TipoPoder.Psiquico, 38084036, 94));
            /*Mewtwo*/
            Personajes.Add(new Personaje("Mewtwo", TipoArma.Otra, TipoPoder.Psiquico, 37409797, 85));
            /*Ice Climbers*/
            Personajes.Add(new Personaje("Ice Climbers", TipoArma.Otra, TipoPoder.Elemental, 37853349, 88));
            /*Jigglypuff*/
            Personajes.Add(new Personaje("Jigglypuff", TipoArma.Otra, TipoPoder.Fisico, 31597415, 60));

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
