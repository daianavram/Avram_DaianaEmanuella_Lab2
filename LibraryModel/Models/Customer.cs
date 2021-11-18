using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avram_DaianaEmanuella_Lab2.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        
        public ICollection<Order> Orders { get; set; }
    }
}
