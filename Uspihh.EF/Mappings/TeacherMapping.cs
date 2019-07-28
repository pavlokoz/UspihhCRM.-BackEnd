using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class TeacherMapping : EntityTypeConfiguration<TeacherEntity>
    {
        public TeacherMapping()
        {
            ToTable("dbo.Teacher");
            HasKey(X => X.TeacherId);

            Property(x => x.TeacherId).HasColumnName("TeacherId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CV).HasColumnName("CV").IsRequired();


            HasRequired(x => x.User).WithOptional(y => y.Teacher);

            HasMany(x => x.Groups)
                .WithMany(y => y.Teachers)
                .Map(z =>
                {
                    z.MapLeftKey("TeacherId");
                    z.MapRightKey("GroupId");
                    z.ToTable("dbo.GroupTeacher");
                });
        }
    }
}
