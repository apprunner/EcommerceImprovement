using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceImprovement.Models;

namespace EcommerceImprovement.Controllers
{
    public class GuruController : Controller
    {
        // GET: Guru
        public ActionResult Index()
        {
            List<ProductGuru> products = new List<ProductGuru>
            {
                new ProductGuru { Id = 1, ProductName="Mouse", Sum=221 },
                new ProductGuru { Id = 1, ProductName="Keyboard", Sum=81 },
                new ProductGuru { Id = 1, ProductName="Headset", Sum=24 }
            };

            int total = products.Sum(p => p.Sum);


            return View();
        }
    }
}