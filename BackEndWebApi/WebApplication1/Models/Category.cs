using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        
        public int ID { get; set; }

       
        public string Name { get; set; }
        
        public virtual IEnumerable<Product> Products { get; set; }

    }
}