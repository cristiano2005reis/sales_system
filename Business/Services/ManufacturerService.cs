using System;
using Business.Entities;

namespace Business.Services
{
    public class ManufacturerService:GenericService<Manufacturer>
    {
        public ManufacturerService():base(new Repositories.ManufacturerRepository())
        {
        }
    }
}
