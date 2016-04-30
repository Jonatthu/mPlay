using Odasoft.mPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ICollection<Album> Albums { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
