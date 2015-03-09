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
            Personajes.Add(new Personaje("Mario", TipoArma.Puño, TipoPoder.Fisico, 14, 100));
            /*Pikachu*/
            Personajes.Add(new Personaje("Pikachu", TipoArma.Otra, TipoPoder.Elemental, 17, 80));
            /*Bowser*/
            Personajes.Add(new Personaje("Bowser", TipoArma.Puño, TipoPoder.Fisico, 10, 117));
            /*Peach*/
            Personajes.Add(new Personaje("Peach", TipoArma.Otra, TipoPoder.Magico, 15, 90));
            /*Yoshi*/
            Personajes.Add(new Personaje("Yoshi", TipoArma.Otra, TipoPoder.Fisico, 15, 108));
            /*Donkey Kong*/
            Personajes.Add(new Personaje("Donkey Kong", TipoArma.Puño, TipoPoder.Fisico, 11, 114));
            /*Captain Falcon*/
            Personajes.Add(new Personaje("Captain Falcon", TipoArma.Puño, TipoPoder.Fisico, 14, 104));
            /*Fox*/
            Personajes.Add(new Personaje("Fox", TipoArma.Pistola, TipoPoder.Fisico, 15, 75));
            /*Falco*/
            Personajes.Add(new Personaje("Falco", TipoArma.Pistola, TipoPoder.Fisico, 16, 80));
            /*Kirby*/
            Personajes.Add(new Personaje("Kirby", TipoArma.Puño, TipoPoder.Magico, 20, 70));
            /*Dr. Mario*/
            Personajes.Add(new Personaje("Dr. Mario", TipoArma.Puño, TipoPoder.Fisico, 14, 100));
            /*Luigi*/
            Personajes.Add(new Personaje("Luigi", TipoArma.Puño, TipoPoder.Fisico, 14, 100));
            /*Pichu*/
            Personajes.Add(new Personaje("Pichu", TipoArma.Otra, TipoPoder.Elemental, 16, 55));
            /*Ganondorf*/
            Personajes.Add(new Personaje("Ganondorf", TipoArma.Puño, TipoPoder.Magico, 12, 109));
            /*Samus*/
            Personajes.Add(new Personaje("Samus", TipoArma.Pistola, TipoPoder.Elemental, 15, 110));
            /*Zelda*/
            Personajes.Add(new Personaje("Zelda", TipoArma.Otra, TipoPoder.Magico, 18, 90));
            /*Sheik*/
            Personajes.Add(new Personaje("Sheik", TipoArma.Puño, TipoPoder.Magico, 15, 90));
            /*Link*/
            Personajes.Add(new Personaje("Link", TipoArma.Otra, TipoPoder.Fisico, 13, 104));
            /*Young Link*/
            Personajes.Add(new Personaje("Young Link", TipoArma.Otra, TipoPoder.Fisico, 14, 85));
            /*Mr. Game & Watch*/
            Personajes.Add(new Personaje("Mr. Game & Watch", TipoArma.Puño, TipoPoder.Magico, 17, 60));
            /*Marth*/
            Personajes.Add(new Personaje("Marth", TipoArma.Espada, TipoPoder.Fisico, 15, 87));
            /*Roy*/
            Personajes.Add(new Personaje("Roy", TipoArma.Espada, TipoPoder.Elemental, 15, 85));
            /*Ness*/
            Personajes.Add(new Personaje("Ness", TipoArma.Puño, TipoPoder.Psiquico, 17, 94));
            /*Mewtwo*/
            Personajes.Add(new Personaje("Mewtwo", TipoArma.Otra, TipoPoder.Psiquico, 18, 85));
            /*Ice Climbers*/
            Personajes.Add(new Personaje("Ice Climbers", TipoArma.Otra, TipoPoder.Elemental, 18, 88));
            /*Jigglypuff*/
            Personajes.Add(new Personaje("Jigglypuff", TipoArma.Puño, TipoPoder.Fisico, 18, 60));

        }

        public static void ClasificarPersonaje(string personaje)
        {
            bool aux = false;
            Personajes.ForEach(x =>
                {
                    if (x.Nombre.ToUpper() == personaje.ToUpper())
                    {
                        aux = true;
                        Console.WriteLine(x.Nombre);
                        Console.WriteLine("Tipo Combate: " + ClasificadorTipoCombate(x));
                        Console.WriteLine("Altura de saltos: " + ClasificadorAltura(x));
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

            if (personaje.Salto >= 10 && personaje.Salto <= 13)
            {
                return "Baja";
            }
            else if (personaje.Salto >= 14 && personaje.Salto <= 17)
            {
                return "Mediana";
            }
            else if (personaje.Salto >= 18)
            {
                return "Alta";
            }

            return "Error en Clasificador Altura";


            /*
             Alta
             Mediana
             Baja
             */
        }

        public static string ClasificadorPeso(Personaje personaje)
        {

            if(personaje.Peso >= 60 && personaje.Peso <= 75)
            {
                return "Ligero";
            }
            else if (personaje.Peso >= 75 && personaje.Peso <= 100)
            {
                return "Mediano";
            }
            else if (personaje.Peso > 100)
            {
                return "Pesado";
            }

            return "Error en Clasificador Peso";
        }

        public static string ClasificadorVelocidad(Personaje personaje)
        {

            if (personaje.Salto >= 10 && personaje.Salto <= 13 && personaje.Peso > 100)
            {
                return "Lento";
            }
            else if (personaje.Salto >= 14 && personaje.Salto <= 17 && personaje.Peso >= 75 && personaje.Peso <= 100)
            {
                return "Normal";
            }
            else if (personaje.Salto >= 18 && personaje.Peso >= 60 && personaje.Peso <= 75)
            {
                return "Rapido";
            }

            else if (personaje.Peso > 100)
            {
                return "Lento";
            }

            else if (personaje.Peso >= 60 && personaje.Peso <= 75)
            {
                return "Rapido";
            }

            return "Normal";

            /*
             Rapido
             Normal
             Lento
             */
           
        }

        public static string ClasificadorTipoCombate(Personaje personaje)
        {

            if (personaje.Poder == TipoPoder.Fisico && personaje.Arma == TipoArma.Puño)
            {
                return "Close Range Fighter";
            }
            else if (personaje.Poder == TipoPoder.Fisico && personaje.Arma == TipoArma.Otra)
            {
                return "Hybrid Range Fighter";
            }

            else if (personaje.Poder == TipoPoder.Fisico && personaje.Arma == TipoArma.Otra)
            {
                return "Hybrid Range Fighter";
            }

            else if (personaje.Poder == TipoPoder.Elemental && personaje.Arma == TipoArma.Pistola)
            {
                return "Long Range Fighter";
            }
            else if (personaje.Poder == TipoPoder.Fisico && personaje.Arma == TipoArma.Espada)
            {
                return "Close Range Fighter";
            }
            else if(personaje.Poder == TipoPoder.Magico && personaje.Arma == TipoArma.Otra)
            {
                return "Hybrid Range Fighter";
            }

            else if (personaje.Arma == TipoArma.Puño || personaje.Arma == TipoArma.Espada)
            {
                return "Close Range Fighter";
            }
            else if (personaje.Arma == TipoArma.Otra || personaje.Poder == TipoPoder.Elemental)
            {
                return "Hybrid Range Fighter";
            }
      
            /*
             CloseRange
             LongRange
             HybridRange
             */
            return "No tiene clasificación";
        }

    }
}
