using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Quntaty { get; set; }

        public string Price { get; set; }

        public string picture { get; set; }

        public string description { get; set; }
        public int CatID { get; set; }

    }
}