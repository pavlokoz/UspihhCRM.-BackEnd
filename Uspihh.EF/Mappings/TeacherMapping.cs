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

            Property(x => x.TeacherId).HasColumnName("TeacherId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CV).HasColumnName("CV").IsRequired();

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
