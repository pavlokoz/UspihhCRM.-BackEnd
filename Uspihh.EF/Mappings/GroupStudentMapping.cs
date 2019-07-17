using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class GroupStudentMapping: EntityTypeConfiguration<GroupStudentEntity>
    {
        public GroupStudentMapping()
        {
            ToTable("dbo.GroupStudent");
            HasKey(x => new { x.GroupId, x.StudentId });

            Property(x => x.GroupId).HasColumnName("GroupId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StudentId).HasColumnName("StudentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(x => x.Group).WithMany(y => y.GroupStudents).HasForeignKey(z => z.GroupId);
            HasRequired(x => x.Student).WithMany(y => y.GroupStudents).HasForeignKey(z => z.StudentId);
        }
    }
}
