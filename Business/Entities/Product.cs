using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Product:Generic
    {
        [Key]
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public long ManufacturerId { get; set; }
        public string ProductDescription { get; set; }
        public long ProductQuantity { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
