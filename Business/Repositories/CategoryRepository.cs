using System;
using Business.Entities;

namespace Business.Repositories
{
    public class CategoryRepository:GenericRepository<Category>
    {
        public CategoryRepository():base(new Contexts.GenericContext())
        {
        }
    }
}
