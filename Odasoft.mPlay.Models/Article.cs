using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public string Image { get; set; }
    }
}
