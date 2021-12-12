using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Models
{
    public class OrderDetail:BaseEntity
    {
        public decimal? UnitPrice { get; set; }

        public short? Quantity { get; set; }


        public int? OrderId { get; set; }

        public int? ProductId { get; set; }


        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
