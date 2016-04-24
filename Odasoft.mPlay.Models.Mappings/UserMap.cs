using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Models.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
       public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.UserName).IsRequired();
            Property(x => x.Name).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.Password).IsRequired();

            #region  ForeignKeys
            public int CartId { get; set; }
            #endregion

    }
}
}
