using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class UserMapping : EntityTypeConfiguration<UserEntity>
    {
        public UserMapping()
        {
            ToTable("dbo.User");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(50);
            Property(x => x.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);

            HasOptional(x => x.Teacher).WithRequired(y => y.User);
        }
    }
}
