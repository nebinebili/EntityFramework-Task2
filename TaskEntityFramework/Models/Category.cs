using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Models
{
    public class Category:BaseEntity
    {
        [MaxLength(15),Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }


        public virtual List<Product>  Products { get; set; }
    }
}
