using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceImprovement.Models;

namespace EcommerceImprovement.Controllers
{
    public class AnviController : Controller
    {
        // GET: Anvi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllStockChart()
        {
            List<ProductDetail> productDetils = new List<ProductDetail>
            {
                new ProductDetail { PDID="1-1", Stock=4 },
                new ProductDetail { PDID="2-1", Stock=5 },
                new ProductDetail { PDID="3-1", Stock=8 },
                new ProductDetail { PDID="4-1", Stock=3 },
                new ProductDetail { PDID="5-1", Stock=6 },
                new ProductDetail { PDID="5-1", Stock=10 }
            };


            return View(productDetils);
        }

        public ActionResult AllStockChartClean()
        {
            List<ProductDetail> productDetils = new List<ProductDetail>
            {
                new ProductDetail { PDID="1-1", Stock=4 },
                new ProductDetail { PDID="2-1", Stock=5 },
                new ProductDetail { PDID="3-1", Stock=8 },
                new ProductDetail { PDID="4-1", Stock=3 },
                new ProductDetail { PDID="5-1", Stock=6 },
                new ProductDetail { PDID="5-1", Stock=10 }
            };


            return View(productDetils);
        }
    }
}