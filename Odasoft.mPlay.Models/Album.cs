using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Album : Article
    {

        public Album()
        {
            Songs = new List<Song>();
            ShoppingCarts = new HashSet<ShoppingCart>();
            //to let the mapping know it is a one to many relationship
        }
        
        public virtual ICollection<Song> Songs { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
