using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Models
{
    public class Order:BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        [MaxLength(40)]
        public string ShipName { get; set; }

        [MaxLength(60)]
        public string ShipAddress { get; set; }

        [MaxLength(15)]
        public string ShipCity { get; set; }

        [MaxLength(15)]
        public string ShipRegion { get; set; }

        [MaxLength(15)]
        public string ShipCountry { get; set; }


        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }


        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual Customer  Customer { get; set; }

        public virtual Employee  Employee { get; set; }
    }
}
