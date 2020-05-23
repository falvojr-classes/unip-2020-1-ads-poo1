using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 4:

            // a) As entidades/classes seriam Carro e Motor. 

            // b) Carro teria os atributos cor, modelo, velocidade atual, velocidade máxima e motor encapsulados (getters e setters).
            //    Motor teria os atributos tipo e potência encapsulados (getters e setters).

            // c) Os métodos Ligar e Acelerar (recebendo uma quantidade) devem ser criados na classe Carro.

            // d) Criar uma método com o nome Acelerar (sem parâmetros) que acrescente sempre 10 a velocidade máxima.

            // e) Criar uma sobrecarga de construtores (um padrão e outro recebendo um Motor).

            // f) Codigo a seguir:

            Motor motor1 = new Motor();
            motor1.Tipo = "1.0";

            Carro carro1 = new Carro(motor1);
            carro1.Ligar();
            carro1.Acelerar();
            carro1.Acelerar(10);

            Motor motor2 = new Motor();
            motor2.Tipo = "2.0";

            Carro carro2 = new Carro();
            carro2.Motor = motor2;
            carro2.Ligar();
            carro2.Acelerar();
            carro2.Acelerar(100);

            double velocidadeCarro1 = carro1.VelocidadeAtual;
            double velocidadeCarro2 = carro2.VelocidadeAtual;

            Console.WriteLine("Carro 1: {0}", velocidadeCarro1);
            Console.WriteLine("Carro 2: {0}", velocidadeCarro2);

            // Exercicio 2:

            Motor motor = new Motor();
            motor.Potencia = 150;

            Carro carro = new Carro();
            carro.Modelo = "VW Gol 1.0";
            carro.Cor = "Branco";

            // NullReferenceException: pois o carro não possui motor associado.
			// (a) O código em questão compila, mas apresenta uma exceção em tempo de execução.
            Console.WriteLine("Potencia do Carro: {0}", carro.Motor.Potencia);
        }
    }
}
