using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public ICollection<Album> AlbumList { get; set;}
        public ICollection<Movie> MovieList { get; set; }
        public float TotalPrice { get; set; }

        #region  ForeignKeys
        public int UserId { get; set; }
        #endregion
    }
}
