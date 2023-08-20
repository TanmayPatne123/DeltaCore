using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaCore.Models
{
    public class ProductsService
    {
        [Display(Name = "Product Id")]
        public int intProductId { get; set; }

        [Display(Name = "Product Name")]
        public string strName { get; set; }
        
        [Display(Name = "Product Description")]
        public string strDescription { get; set; }


    }
}
