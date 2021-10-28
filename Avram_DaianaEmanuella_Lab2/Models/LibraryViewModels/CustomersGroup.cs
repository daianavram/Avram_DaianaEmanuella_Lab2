using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Avram_DaianaEmanuella_Lab2.Models.LibraryViewModels
{
    public class CustomersGroup
    {
        [DataType(DataType.Text)]
        public int CustomerID { get; set; }
        public String? CustomerName { get; set; }
        public int BookCount { get; set; }
    }
}
