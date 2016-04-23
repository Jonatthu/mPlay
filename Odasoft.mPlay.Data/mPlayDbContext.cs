using Odasoft.mPlay.Models;
using Odasoft.mPlay.Models.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace Odasoft.mPlay.Data
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class mPlayDbContext : DbContext
    {
        public mPlayDbContext() : base("mPlayDbContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        #region DbSet
        //Must create a DbSet for each class that will have a table in the DB
        public DbSet<Article> Article { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties<DateTime>()
                .Configure(c => c.HasColumnType("datetime2"));

            //Add always the mappings that you created
            modelBuilder.Configurations.Add(new ArticleMapping());

        }
}
}