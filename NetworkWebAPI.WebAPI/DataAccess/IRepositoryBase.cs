using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkWebAPI.WebAPI.Entities;

namespace NetworkWebAPI.WebAPI.DataAccess
{
    public interface IRepositoryBase <T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
