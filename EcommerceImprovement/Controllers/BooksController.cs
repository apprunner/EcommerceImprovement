using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EcommerceImprovement.Models;

namespace EcommerceImprovement.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {

            List<BookMix> booksCollection = new List<BookMix>{
                new BookMix { Id = 1, Name ="FirstBooks", Books = new List<Book> { new Book { BookId="A10259", BooksName="MVC" }, new Book { BookId = "A10259", BooksName = "SQL Server" } } },
                new BookMix { Id = 2, Name ="SecondBooks", Books = new List<Book> { new Book { BookId="B20482", BooksName="DevOps" }, new Book { BookId = "B20639", BooksName = "CI/CD" } } },
                new BookMix { Id = 3, Name ="ThirdBooks", Books = new List<Book> { new Book { BookId="C35963", BooksName="Testing" } , new Book { BookId = "C35951", BooksName = "Performance" } } },
            };

            return View(booksCollection);
        }
    }
}