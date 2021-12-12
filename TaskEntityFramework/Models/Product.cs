using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Models
{
    public class Product:BaseEntity
    {
        [MaxLength(40),Required]
        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }

        public short UnitsOnOrder { get; set; }

        public short ReorderLevel { get; set; }


        public int CategoryId { get; set; }


        public virtual List<OrderDetail>  OrderDetails { get; set; }

        public virtual Category  Category { get; set; }
    }
}
