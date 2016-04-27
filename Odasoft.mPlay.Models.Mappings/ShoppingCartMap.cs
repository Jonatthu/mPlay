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

            HasRequired(s => s.User)
                .WithMany(s => s.ShoppingCarts);

            HasMany<Movie>(s => s.MovieList)
                .WithMany(c => c.ShoppingCarts)
                .Map(s =>
                {
                    s.MapLeftKey("ShoppingCartRefId");
                    s.MapRightKey("MovieRefId");
                    s.ToTable("ShoppingCartMovie");
                });

            HasMany<Album>(s => s.AlbumList)
                .WithMany(c => c.ShoppingCarts)
                .Map(s =>
                {
                    s.MapLeftKey("ShoppingCartRefId");
                    s.MapRightKey("AlbumRefId");
                    s.ToTable("ShoppingCartAlbum");
                });

            this.ToTable("ShoppingCarts");
        }
    }
}
