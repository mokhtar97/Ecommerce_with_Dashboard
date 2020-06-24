using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Dashboard.ViewModels
{
    public class productVM
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public int Quntaty { get; set; }

        public string Price { get; set; }



     

        public string description { get; set; }

        
        public int CatID { get; set; }



      
        [Display(Name = "Product Picture")]
        public IFormFile picture { get; set; }
    }
}
