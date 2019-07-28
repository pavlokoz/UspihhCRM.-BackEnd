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
        public DbSet<TeacherEntity> Teachers;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder?.Configurations.Add(new TestMapping());
            modelBuilder?.Configurations.Add(new GroupMapping());
            modelBuilder?.Configurations.Add(new StudentMapping());
            modelBuilder?.Configurations.Add(new SubjectMapping());
            modelBuilder?.Configurations.Add(new GroupStudentMapping());
            modelBuilder?.Configurations.Add(new GroupTeacherMapping());
            modelBuilder?.Configurations.Add(new TeacherMapping());
            modelBuilder?.Configurations.Add(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
