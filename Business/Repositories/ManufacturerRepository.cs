using System;
using Business.Entities;

namespace Business.Repositories
{
    public class ManufacturerRepository:GenericRepository<Manufacturer>
    {
        public ManufacturerRepository():base(new Contexts.GenericContext())
        {
        }
    }
}
