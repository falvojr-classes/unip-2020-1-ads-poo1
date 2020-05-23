using System;

namespace Exercicio04
{
    public class Carro 
    {
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public double VelocidadeAtual { get; set; }
        public double VelocidadeMaxima { get; set; }
        public Motor Motor { get; set; }

        public Carro()
        {
            // Construtor padrão (vazio).
        }

        public Carro(Motor motor)
        {
            this.Motor = motor;
        }

        public void Ligar() 
        {
            Console.WriteLine("Carro ligado e pronto para acelerar");
        }

        public void Acelerar(double quantidade = 10) 
        {
            VelocidadeAtual += quantidade;
        }

        public void Acelerar() 
        {
            Acelerar(10);
        }
    }
}