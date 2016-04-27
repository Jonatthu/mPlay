using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Odasoft.mPlay.Business;

namespace Odasoft.mPlay.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShoppingCartBusiness _ShoppingCartBusiness;
        private readonly AlbumBusiness _AlbumBusiness;

        public HomeController(ShoppingCartBusiness ShoppingCartBusiness, AlbumBusiness AlbumBusiness)
        {
            this._ShoppingCartBusiness = ShoppingCartBusiness;
            this._AlbumBusiness = AlbumBusiness;
        }

        [HttpGet]
        public JsonResult GetJson()
        {
            var result = _ShoppingCartBusiness.GetShoppingCartAlbumsById(1);
            
            return Json(result);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
