using System;
using System.Collections.Generic;

namespace PIM
{
    public abstract class Cliente : BaseCRUD<Cliente>
    {
        public long Documento { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Interesse> Interesses { get; set; }
        public List<DadoBancario> DadoBancarios { get; set; } 

        public void Incluir()
        {
            
        }

        public void Alterar()
        {

        }

        public void Excluir()
        {

        }

        public List<Cliente> Listar()
        {
            return null;
        }
    }
}