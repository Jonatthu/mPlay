using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;


namespace Odasoft.mPlay.Models.Mappings
{
    public class AlbumMap: EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(40);
            Property(x => x.Author).IsOptional();
            Property(x => x.ReleaseDate).IsRequired();
            Property(x => x.Genre).IsOptional();
            Property(x => x.Price).IsRequired();
            Property(x => x.Description).IsOptional();
            Property(x => x.Length).IsRequired();
            Property(x => x.Image).IsRequired();
            //Aqui faltaria poner la lista de las canciones
            //Pero aun necesito investigar como
            this.ToTable("Albums");
        }
    }
}
