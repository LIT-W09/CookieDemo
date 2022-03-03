using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        private static int _number = 0;

        public IActionResult Index()
        {
            _number++;
            var vm = new CounterViewModel
            {
                Count = _number
            };
            return View(vm);
        }
    }
}
