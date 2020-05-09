using System;

namespace Exercicio03
{
    public class Empresa
    {
        public string Nome { get; set; }

        public double CalcularSalario(Funcionario funcionario) 
        {
            return funcionario.CalcularSalario();
        }

        public void RegistrarEntrada(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, true);
        }

        public void RegistrarSaida(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, false);
        }

        private void ImprimirComprovante(Funcionario funcionario, bool ehEntrada)
        {
            string label = ehEntrada ? "Entrada" : "Saída";
            
            // Alternativa 1: Usando IF e ELSE IF
            string tipo = "Não Identificado";
            if (funcionario is Consultor) 
            {
                tipo = "Consultor de Vendas";
            }
            else if (funcionario is Gerente) 
            {
                tipo = "Gerente de Vendas";
            }
            else if (funcionario is Vendedor) 
            {
                tipo = "Vendedor";
            }

            // Alternativa 2: Usando Switch Case.
            // Cada case faz o cast automatico para o tipo específico, como se fizessen o uso do termo "as":
            // Consultor c = funcionario as Consultor;
            switch (funcionario)
            {
                case Consultor c:
                    tipo = "Consultor de Vendas";
                    break;
                case Gerente g:
                    tipo = "Gerente de Vendas";
                    break;
                case Vendedor v:
                    tipo = "Vendedor";
                    break;
                default:
                    tipo = "Não Identificado";
                    break;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Nome: {0}", funcionario.Nome);
            Console.WriteLine("Tipo: {0}", tipo);
            Console.WriteLine("Data {0}: {1:dd/MM/yyyy HH:mm:ss.fff}", label, DateTime.Now);
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }
    }
}