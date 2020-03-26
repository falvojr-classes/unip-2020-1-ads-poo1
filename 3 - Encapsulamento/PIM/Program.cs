using System;
using System.Collections.Generic;

namespace PIM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria os objetos (instâncias) e atribui os valores mínimos
            
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Venilton";
            
            Endereco endereco1 = new Endereco();
            endereco1.Cep = "14835-000";

            Endereco endereco2 = new Endereco();
            endereco2.Cep = "14801-788";

            // Instancia a lista de enderecos e adiciona as instancias criadas acima

            pf.Enderecos = new List<Endereco>();
            pf.Enderecos.Add(endereco1);
            pf.Enderecos.Add(endereco2);

            // Percorre os enderecos imprimindo seus respectivos CEPs

            foreach (Endereco item in pf.Enderecos)
            {
                Console.WriteLine(item.Cep);
            }
        }
    }
}
