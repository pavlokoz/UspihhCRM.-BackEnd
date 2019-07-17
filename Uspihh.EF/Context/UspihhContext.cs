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

        public DbSet<GroupEntity> Groups;
        public DbSet<TestEntity> Tests;
        public DbSet<StudentEntity> Students;
        public DbSet<SubjectEntity> Subjects;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder?.Configurations.Add(new TestMapping());
            modelBuilder?.Configurations.Add(new GroupMapping());
            modelBuilder?.Configurations.Add(new StudentMapping());
            modelBuilder?.Configurations.Add(new SubjectMapping());
            modelBuilder?.Configurations.Add(new GroupStudentMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
