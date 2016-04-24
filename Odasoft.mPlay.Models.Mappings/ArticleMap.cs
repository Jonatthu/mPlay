using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models.Mappings
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Image).IsRequired();
            Property(x => x.Length).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.Title).HasMaxLength(40);
            Property(x => x.Description).HasMaxLength(255);
            this.ToTable("Articles");
        }
    }
}
