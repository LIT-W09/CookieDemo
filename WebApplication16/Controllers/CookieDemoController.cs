using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication16.Models;
using System.Threading.Tasks;

namespace WebApplication16.Controllers
{
    public class CookieDemoController : Controller
    {
        public IActionResult Index()
        {
            var cookieValue = Request.Cookies["last-visit"];
            bool hasBeenHere = cookieValue != null;

            Response.Cookies.Append("last-visit", DateTime.Now.ToString());

            var vm = new CookieDemoViewModel
            {
                HasBeenHere = hasBeenHere
            };

            if(hasBeenHere)
            {
                vm.LastVisit = DateTime.Parse(cookieValue);
            }

            return View(vm);
        }

        public IActionResult Counter()
        {
            /*
             * substring demo
            string s = "asdkjfghaskuyf gaksudfg asukdfg akshdgf kjahsdfg ajkshdfg alshdf ";
            string firstTen = s.Substring(0, 10);
            */
            string cookieValue = Request.Cookies["number"];
            int number = 1;
            if(cookieValue != null)
            {
                number = int.Parse(cookieValue);
            }

            Response.Cookies.Append("number", $"{number + 1}");
            return View(new CounterViewModel
            {
                Count = number
            });
        }
    }
}
