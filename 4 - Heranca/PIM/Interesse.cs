using System;
using System.Collections.Generic;

namespace PIM
{
    public class Interesse : BaseCRUD<Interesse>
    {
        public string Descricao { get; set; }   

        public void Incluir()
        {
            Console.WriteLine("Incluindo Interesse " + Descricao);
        }

        public void Alterar()
        {
            Console.WriteLine("Alterando Interesse " + Descricao);
        }

        public void Excluir()
        {

        }

        public List<Interesse> Listar()
        {
            return null;
        }
    }
}