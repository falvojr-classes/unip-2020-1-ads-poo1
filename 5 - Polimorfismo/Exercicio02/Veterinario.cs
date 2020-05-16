using System;
using System.Collections.Generic;

namespace Exercicio02
{
    public class Veterinario
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public void Examinar(Animal animal) 
        {
            Console.WriteLine("{0} examinando {1}...", Nome, animal.Apelido);
            animal.EmitirSom();
            Console.WriteLine();
        }

        public void Examinar(List<Animal> animais)
        {
            foreach (Animal animal in animais)
            {
                Examinar(animal);
            }
        }
    }
}