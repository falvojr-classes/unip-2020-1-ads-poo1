using System;

namespace Exercicio01
{
    public abstract class Animal 
    {
        public String Nome { get; set; }
        public String Genero { get; set; }
        public String Especie { get; set; }

        public abstract void EmitirSom();
    }
}