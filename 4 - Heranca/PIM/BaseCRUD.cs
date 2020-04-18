using System.Collections.Generic;

namespace PIM
{
    public abstract class BaseCRUD<T>
    {
        public abstract void Incluir();
        public abstract void Alterar();
        public abstract void Excluir();
        public abstract List<T> Listar();
    }
}