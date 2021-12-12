using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Models
{
    public class Employee:BaseEntity
    {
        [MaxLength(20), Required]
        public string LastName { get; set; }

        [MaxLength(10), Required]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        [MaxLength(60)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string Region { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        public string Country { get; set; }

        [MaxLength(24)]
        public string HomePhone { get; set; }


        public virtual List<Order>  Orders { get; set; }
    }
}
