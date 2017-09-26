using System;
namespace Business.Entities
{
    public class Manufacturer:Generic
    {
        public long ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
    }
}
