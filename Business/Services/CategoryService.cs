using System;
using Business.Entities;

namespace Business.Services
{
    public class CategoryService:GenericService<Category>
    {
        public CategoryService():base(new Repositories.CategoryRepository())
        {
        }
    }
}
