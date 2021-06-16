using System.Collections.Generic;

namespace CRUD.Produtos.interfaces
{
    public interface IRepository<T>
    {
        List<T> List(); 

        T ReturnId(int id); 

        void Insert(T entidade);

        void Delete(int id);

        void Update(int id, T entidade);

        int NextId();
    }
}