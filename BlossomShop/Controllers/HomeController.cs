using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlossomShop.Models;

namespace BlossomShop.Controllers
{
    public class HomeController : Controller
    {
        //контекст данных
        BlossomContext db = new BlossomContext();

        public ActionResult Index()
        {
            //получить из БД все объекты Blossom
            IEnumerable<Blossom> blossoms = db.Blossoms;
            //передаем все объекты в динамическое свойство Blossoms в ViewBag
            ViewBag.Blossoms = blossoms;
            //возвращаем вьюшку
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BlossomId = id;
            return View();
        }

         [HttpPost]
         public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            //инфа о покупке отправляется в БД
            db.Purchases.Add(purchase);
            //сохраняем изменения в бд
            db.SaveChanges();
            return purchase.Client + ", спасибо за покупку!";
        }


    }
}