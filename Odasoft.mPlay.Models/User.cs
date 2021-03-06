﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class User
    {
        public User()
        {
            ShoppingCarts = new List<ShoppingCart>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //A User has multiple Carts
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

    }
}
