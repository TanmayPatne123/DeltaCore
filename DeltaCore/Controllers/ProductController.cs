using DeltaCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DeltaCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult DisplayProductDetails()
        {
            List<ProductsService> product = new List<ProductsService>();
            
            ProductsService PS = new ProductsService();

            PS.intProductId = 1001;
            PS.strName = "Tools Gears";
            PS.strDescription = "Gear toolds production description";
            product.Add(PS);

            ProductsService PS1 = new ProductsService();

            PS1.intProductId = 2001;
            PS1.strName = "Panels";
            PS1.strDescription = "Switch Gear Panels";
            product.Add(PS1);

            ProductsService PS2 = new ProductsService();
            PS2.intProductId = 2008;
            PS2.strName = "DocTonar";
            PS2.strDescription = "Document Solar Objects";
            product.Add(PS2);


            return View(product);


        }
    }
}
