using Avram_DaianaEmanuella_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Avram_DaianaEmanuella_Lab2.Data;
using Avram_DaianaEmanuella_Lab2.Models.LibraryViewModels;

namespace Avram_DaianaEmanuella_Lab2.Controllers
{
    public class HomeController : Controller
    {

        private readonly LibraryContext _context;
        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Statistics()
        {
            IQueryable<OrderGroup> data =
            from order in _context.Orders
            group order by order.OrderDate into dateGroup
            select new OrderGroup()
            {
                OrderDate = dateGroup.Key,
                BookCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }

        public async Task<ActionResult> StatisticsCustomers()
        {
            IQueryable<CustomersGroup> data =
            from order in _context.Orders
            group order by order.Customer.Name into customerGroup
            select new CustomersGroup()
            {
                CustomerName = customerGroup.Key,
                BookCount = customerGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }
        /*
        public async Task<ActionResult> StatisticsNameCustomers()
        {
            IQueryable<CustomersGroup> data =
            from order in _context.Orders
            group order by order.CustomerID into customerGroup

            IQueryable<CustomersGroup> dataName =
            from customer in _context.Customers
            group customer by customer.Name into customerNameGroup
            select new CustomersGroup()
            {
                CustomerID = customerGroup.Key,
                CustomerName = customerNameGroup.Key
                BookCount = customerGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }
        */

        private readonly ILogger<HomeController> _logger;

        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
