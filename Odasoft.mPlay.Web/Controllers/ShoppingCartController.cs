using Odasoft.mPlay.Business;
using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Odasoft.mPlay.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCartBusiness _ShoppingCartBusiness;
        public ShoppingCartController(ShoppingCartBusiness ShoppingCartBusiness)
        {
            this._ShoppingCartBusiness = ShoppingCartBusiness;
        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            ICollection<Movie> moviesInCart = _ShoppingCartBusiness.GetShoppingCartMoviesById(1);

            return View(moviesInCart);
        }

        public IActionResult CheckOut()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult remove(int MovieId)
        {
            this._ShoppingCartBusiness.removeMovieById(MovieId);
            return View();
        }

    }
}
