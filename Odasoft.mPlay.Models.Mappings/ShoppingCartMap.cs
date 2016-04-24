using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models.Mappings
{
    public class ShoppingCartMap : EntityTypeConfiguration<ShoppingCart>
    {
        public ShoppingCartMap()
        {
            HasKey(x => x.Id);
            Property(x => x.TotalPrice).IsRequired();
            Property(x => x.UserId).IsRequired();

            HasMany<Album>(x => x.AlbumList);
                

            HasMany<Movie>(x => x.MovieList);
            

            this.ToTable("ShoppingCarts");
        }
    }
}
