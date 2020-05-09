using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            empresa.Nome = "UNIP";

            // Exercicio 03 (Herança):
            Gerente gerente = new Gerente();
            gerente.Nome = "João";

            Vendedor vendedor = new Vendedor();
            vendedor.Nome = "José";
            vendedor.Comissao = 50;
            vendedor.NumeroVendas = 100;

            Consultor consultor = new Consultor();
            consultor.Nome = "Maria";
            consultor.ValorHora = 20;
            consultor.HorasTrabalhadas = 160;
            
            // Foram implementadas duas formas de calculo de salário:
            // 1. Através dos funcionário (linhas 29 e 30);
            // 2. Através da empresa (linha 31).
            double salarioGerente = gerente.CalcularSalario();
            double salarioVendedor = vendedor.CalcularSalario();
            double salarioConsultor = empresa.CalcularSalario(consultor);

            Console.WriteLine("Salário Gerente: {0:0,0.00}", salarioGerente);
            Console.WriteLine("Salário Vendedor: {0:0,0.00}", salarioVendedor);
            Console.WriteLine("Salário Consultor: {0:0,0.00}", salarioConsultor);
            Console.WriteLine();

            // Exercicio 01 (Polimorfismo):

            empresa.RegistrarEntrada(gerente);
            empresa.RegistrarEntrada(vendedor);

            empresa.RegistrarSaida(vendedor);
            empresa.RegistrarSaida(gerente);
        }
    }
}
