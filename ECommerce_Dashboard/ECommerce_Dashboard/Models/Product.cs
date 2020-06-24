using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
       
        public int ID { get; set; }
     
        public string Name { get; set; }
        
        public int Quntaty { get; set; }
       
        public string Price { get; set; }

       

        public string picture { get; set; }

      
       
        public string description { get; set; }
       
        [ForeignKey("Category")]
        
        public int CatID { get; set; }
      
        public virtual Category Category { get; set; }
    }
}