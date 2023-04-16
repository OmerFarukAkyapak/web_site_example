using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebSiteExample.DataTransferObject;
using WebSiteExample.Models;
using WebSiteExample.Models.Entity;

namespace WebSiteExample.Controllers
{
    public class HomeController : Controller
    {
        Context con = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (login.Email == "faruk@hotmail.com" && login.Password == "123456")
            {
                return RedirectToAction("Home", "Home");
            }
            TempData["error"] = " Your email address or password is wrong.";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Home()
        {

            List<Products> myProducts = new List<Products>();
            myProducts = con.ProductsTable.ToList();

            List<ShoppingCard> shoppingCard = new List<ShoppingCard>();
            shoppingCard = con.ProductsCard.ToList();

            HomeDto list = new HomeDto();
            list.ProductsTable = myProducts;
            list.ProductsCard = shoppingCard;
            

            return View(list);
        }

        [HttpPost]
        public IActionResult Submit(int id, int quantity)
        {
            Products product = con.ProductsTable.Where(x => x.id == id).FirstOrDefault();
            
            ShoppingCard card = new ShoppingCard();
            card.ProductName = product.ProductName;
            card.Quantity = quantity;
            card.UnitPrice = product.UnitPrice;
            card.TotalPrice = card.UnitPrice * card.Quantity;
            if (quantity != 0)
            {
                con.ProductsCard.Add(card);
                con.SaveChanges();

            }
            else
            {
                TempData["submit"] = "Quantity is empty!";
                
            }
            

            return RedirectToAction("Home", "Home");
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id) 
        {
            ShoppingCard product = con.ProductsCard.Where(x=> x.id == id).FirstOrDefault();
            con.Remove(product);
            con.SaveChanges();

            return RedirectToAction("Home", "Home");
        }

        [HttpPost]
        public IActionResult Payment()
        {
            var result = con.ProductsCard.ToList();
            foreach (var item in result)
            {
                con.Remove(item);
                con.SaveChanges();
            }

            TempData["payment"] = "Successfully!";

            return RedirectToAction("Home", "Home");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
