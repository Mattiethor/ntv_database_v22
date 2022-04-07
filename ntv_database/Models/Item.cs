using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntv_database.Models
{
    public class Item
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int UnitPrice { get; set; }

        
    }
}
