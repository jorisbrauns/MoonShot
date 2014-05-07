using System.Collections.Generic;
using System.Data.Entity;
using Entities;

namespace DataAccess
{
    public class EntityContext : DbContext, IEntityContext
    {
        public EntityContext() : base("name=EntityContext")
        {
        }

        //Overload gebruikt voor in memory db.
        public EntityContext(System.Data.Common.DbConnection connection) : base(connection, true)
        {
        }

        public EntityContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // default cascading deletes afzetten voor de veiligheid
            modelBuilder.Conventions
                .Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions
                .Remove<System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions
                .Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            /*
              modelBuilder.Entity<Bank>().ToTable("Bank");
             */
        }

        public virtual IDbSet<Bank> Banken { get; set; }
    }
}
