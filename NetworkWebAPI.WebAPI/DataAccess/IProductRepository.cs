using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkWebAPI.WebAPI.Entities;

namespace NetworkWebAPI.WebAPI.DataAccess
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        List<Product> GetProductWithCategory();
    }
}


