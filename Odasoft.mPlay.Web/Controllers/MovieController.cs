using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Odasoft.mPlay.Business;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Odasoft.mPlay.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieBusiness _MovieBusiness;

        public MovieController(MovieBusiness MovieBusiness)
        {
            this._MovieBusiness = MovieBusiness;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = this._MovieBusiness.GetMovies();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = this._MovieBusiness.GetMovieById(id);
            return View(model);
        }
    }
}
