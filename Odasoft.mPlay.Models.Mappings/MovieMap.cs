using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models.Mappings
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Title).IsRequired();
            Property(x => x.Author).IsRequired();
            Property(x => x.ReleaseDate).IsRequired();
            Property(x => x.Genre).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.Description).IsRequired();
            Property(x => x.Length).IsRequired();
            Property(x => x.Image).IsRequired();
            this.ToTable("Movie");
        }
    }
}
