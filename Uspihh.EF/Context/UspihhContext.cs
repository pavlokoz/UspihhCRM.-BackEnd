using System.Data.Entity;

namespace Uspihh.EF.Context
{
    public class UspihhContext: DbContext
    {
        public UspihhContext() : base("name=UspihhDBConnectionString")
        {

        }

        //public DbSet<Example> Examples;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder?.Configurations.Add(new Mapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
