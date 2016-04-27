using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Movie : Article
    {
        public Movie()
        {
            this.ShoppingCarts = new HashSet<ShoppingCart>();
        }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
