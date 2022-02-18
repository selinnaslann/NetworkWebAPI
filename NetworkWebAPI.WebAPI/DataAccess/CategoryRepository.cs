using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetworkWebAPI.WebAPI.Entities;

namespace NetworkWebAPI.WebAPI.DataAccess
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly ProductDbContext _context;

        public CategoryRepository(ProductDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.SingleOrDefault(c => c.Id == id);
        }

        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
