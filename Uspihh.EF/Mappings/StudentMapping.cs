using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<StudentEntity>
    {
        public StudentMapping()
        {
            ToTable("dbo.Student");
            HasKey(X => X.StudentId);

            Property(x => x.StudentId).HasColumnName("StudentId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);
            Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").IsRequired().HasMaxLength(13);

            HasMany(x => x.Groups)
                .WithMany(y => y.Students)
                .Map(z =>
                    {
                        z.MapLeftKey("StudentId");
                        z.MapRightKey("GroupId");
                        z.ToTable("dbo.GroupStudent");
                    });
        }
    }
}
