using System;

namespace Exercicio01
{
    public abstract class Mamifero : Animal
    {
        public void Amamentar() 
        {
            if ("F".Equals(Genero)) 
            {
                Console.WriteLine("{0} pode amamentar!", Nome);
            } 
            else 
            {
                Console.WriteLine("{0} NÃO pode amamentar!", Nome);
            }
        }
    }
}