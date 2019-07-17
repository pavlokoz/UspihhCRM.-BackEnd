using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class SubjectMapping : EntityTypeConfiguration<SubjectEntity>
    {
        public SubjectMapping()
        {
            ToTable("dbo.Subject");
            HasKey(X => X.SubjectId);

            Property(x => x.SubjectId).HasColumnName("SubjectId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SubjectName).HasColumnName("SubjectName").IsRequired().HasMaxLength(50);
        }
    }
}
