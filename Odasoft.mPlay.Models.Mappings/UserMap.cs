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

            //Multiple relationships like one-one one-many many-many 
            //ONE TO ONE http://www.entityframeworktutorial.net/code-first/configure-one-to-one-relationship-in-code-first.aspx
            //ONE TO MANY http://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx
            //MANY TO MANY http://www.entityframeworktutorial.net/code-first/configure-many-to-many-relationship-in-code-first.aspx
            //This case targets to ONE TO MANY 
            //Greetings....
            //A user has many shopping carts
            HasMany<ShoppingCart>(s => s.ShoppingCarts) // User has many Shopping carts
            .WithRequired(s => s.User) // Shooping Cart require one User
            .HasForeignKey(s => s.UserId); //Shopping includes specified foreignkey property name for User

            this.ToTable("Users");
        }
    }
}
