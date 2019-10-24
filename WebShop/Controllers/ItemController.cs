using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index(int id)
        {
            var itemManager = new ItemManager();
            itemManager.Seed();
            var items = itemManager.GetByCategory(id);
            var categoryManager = new CategoryManager();
            categoryManager.Seed();
            var categories = categoryManager.GetAll();
            var model = new CatalogModel()
            {
                Items = items,
                Categories=categories
            };

            return View(model);            
        }
        //1.pievieno jaunu darbību Buy ar vienu parametru Id;
        //2.Atlasa lietotaju grozu no sesijas;
        //2.1.Ja grozs nav definēts, definē jaunu sarakstu (new List<int>(););
        //3.pievieno izveleto preces id lietotaju grozam
        //4.saglaba lietotaju grozu sesija
        public IActionResult Buy(int Id)
        {
            var basket = HttpContext.Session.GetUserBasket();
            if (basket==null)
            {
                basket = new List<int>();
            }
            basket.Add(Id);

            HttpContext.Session.SetUserBasket(basket);
            return RedirectToAction("Index", "Item");
        }
        public IActionResult Basket()
        {
            //1.define jaunu sarakstu precem
            //2. par katru preci, kas ir lietotaja sesija atlasa tas
            //datus un pievieno sarakstam
            //3. atgriez precu sarakstu uz view
        }

    }
}