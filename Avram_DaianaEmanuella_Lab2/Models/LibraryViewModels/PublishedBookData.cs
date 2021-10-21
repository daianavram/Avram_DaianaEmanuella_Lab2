using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avram_DaianaEmanuella_Lab2.Models.LibraryViewModels
{
    public class PublishedBookData
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
    }
}
