using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntv_database.Models
{
    public class Employee
    {
        //Þetta gefur obj gildi.
        public Employee()
        {
            Sales = new List<Sale>();
        }
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        //
        public List<Sale>Sales { get; set; }

    }
}
