using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EcommerceImprovement.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public string BooksName { get; set; }
        public string AuthorName { get; set; }
        public string CategoryEngName { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]

        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int InStock { get; set; }
        public decimal Discount { get; set; }
        public string BookImage { get; set; }
        public string Description { get; set; }
        public string PressName { get; set; }
        public string ISBN { get; set; }
    }
}