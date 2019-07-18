using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class GroupTeacherMapping : EntityTypeConfiguration<GroupTeacherEntity>
    {
        public GroupTeacherMapping()
        {
            ToTable("dbo.GroupTeacher");
            HasKey(x => new { x.GroupId, x.TeacherId });

            Property(x => x.GroupId).HasColumnName("GroupId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TeacherId).HasColumnName("TeacherId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(x => x.Group).WithMany(y => y.GroupTeachers).HasForeignKey(z => z.GroupId);
            HasRequired(x => x.Teacher).WithMany(y => y.GroupTeachers).HasForeignKey(z => z.TeacherId);
        }
    }
}
