using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayaBeautyStore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        //  Foreign Key 
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public int Quantity { get; set; }

        [NotMapped]
        public double TotalPrice => Product != null ? Product.Price * Quantity : 0;
    }
}
