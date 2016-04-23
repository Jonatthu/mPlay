using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models.Mappings
{
    public class SongMap : EntityTypeConfiguration<Song>
    {
        public SongMap()
        {
            HasKey(x => x.Id);
            Property(x => x.SongName).IsRequired();
            Property(x => x.SongLength).IsRequired();
            this.ToTable("Songs");
        }
    }
}
