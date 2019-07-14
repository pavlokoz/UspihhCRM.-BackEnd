using System.Data.Entity;
using Uspihh.EF.Mappings;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Context
{
    public class UspihhContext: DbContext
    {
        public UspihhContext() : base("name=UspihhDBConnectionString")
        {

        }

        public DbSet<TestEntity> Examples;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder?.Configurations.Add(new TestMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
