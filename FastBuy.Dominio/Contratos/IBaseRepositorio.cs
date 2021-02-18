using System;
using System.Collections.Generic;

namespace FastBuy.Dominio.Contratos
{
    //Metodos basicos dos contratos e dizendo que o TEntity e uma class
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
