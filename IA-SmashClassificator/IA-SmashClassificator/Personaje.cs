using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_SmashClassificator
{
    public class Personaje
    {
        public string Nombre {get; set;}
        public TipoArma Arma { get; set; }
        public TipoPoder Poder {get;set;}
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }

        public Personaje()
        {

        }
        public Personaje(string nombre, TipoArma arma, TipoPoder poder, decimal altura, decimal peso)
        {
            Nombre = nombre;
            Arma = arma;
            Poder = poder;
            Altura = altura;
            Peso = peso;
        }
    }
}
