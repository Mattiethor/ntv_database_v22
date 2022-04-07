using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntv_database.Models
{
    public class Sale
    {
        public Sale()
        {
            ItemOrders = new List<ItemOrder>();
        }

        
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Employee Employee { get; set; }

        public List<ItemOrder> ItemOrders { get; set; }

    }

}
