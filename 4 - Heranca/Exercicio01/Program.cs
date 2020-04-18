using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.Nome = "Tom";
            gato.Genero = "M";
            gato.EmitirSom();
            gato.Amamentar();

            Cachorro cao = new Cachorro();
            cao.Nome = "Lessy";
            cao.Genero = "F";
            cao.EmitirSom();
            cao.Amamentar();

            Cobra cobra = new Cobra();
            cobra.Nome = "Celeste";
            cobra.Genero = "F";
            cobra.EmitirSom();
            cobra.TrocarPele();
        }
    }
}
