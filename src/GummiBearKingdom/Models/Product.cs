using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string product_name { get; set; }
        public int cost { get; set; }
        public string country { get; set; }
    }
}
