using System;
using System.Collections.Generic;

namespace PIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Interesse interesse = new Interesse();
            interesse.Descricao = "BTC";
            interesse.Incluir();

            interesse.Descricao = "ETH";
            interesse.Alterar();
        }
    }
}
