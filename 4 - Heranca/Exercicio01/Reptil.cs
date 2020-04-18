using System;

namespace Exercicio01
{
    public abstract class Reptil : Animal
    {
        public void TrocarPele() 
        {
            Console.Write("{0} pode trocar de pele!", Nome);
        }
    }
}