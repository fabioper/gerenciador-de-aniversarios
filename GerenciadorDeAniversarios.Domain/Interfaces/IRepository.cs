using GerenciadorDeAniversarios.Domain.Entities;
using System.Collections.Generic;

namespace GerenciadorDeAniversarios.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Remove(int id);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByKeyword(string query);
    }
}
