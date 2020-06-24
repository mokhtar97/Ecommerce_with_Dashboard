using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Dashboard.ViewModels
{
    public class RoleVM
    {
        public int ID { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
