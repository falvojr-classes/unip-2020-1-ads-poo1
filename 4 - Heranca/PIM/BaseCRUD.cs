using System.Collections.Generic;

namespace PIM
{
    public interface BaseCRUD<T>
    {
        void Incluir();
        void Alterar();
        void Excluir();
        List<T> Listar();
    }
}