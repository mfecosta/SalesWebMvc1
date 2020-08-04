using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvc1.Controllers
{
    public class SallesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
            
        public IActionResult SimpleSearch()
        {
            return View();
        }

        public IActionResult GroupSearch()
        {
            return View();
        }
    }
}
