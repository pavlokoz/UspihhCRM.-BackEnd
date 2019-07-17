using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class GroupMapping : EntityTypeConfiguration<GroupEntity>
    {
        public GroupMapping()
        {
            ToTable("dbo.Group");
            HasKey(x => x.GroupId);

            Property(x => x.GroupId).HasColumnName("GroupId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.GroupName).HasColumnName("GroupName").IsRequired().HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndDate).HasColumnName("EndDate").IsRequired();
            Property(x => x.MaxCountOfStudents).HasColumnName("MaxCountOfStudents").IsRequired();
            Property(x => x.MonthPrice).HasColumnName("MonthPrice").IsRequired();
            Property(x => x.SubjectId).HasColumnName("SubjectId").IsRequired();

            HasRequired<SubjectEntity>(g => g.Subject)
                .WithMany(s => s.Groups)
                .HasForeignKey<long>(g => g.SubjectId);

            HasMany(x => x.Students)
                .WithMany(y => y.Groups)
                .Map(z =>
                    {
                        z.MapLeftKey("GroupId");
                        z.MapRightKey("StudentId");
                        z.ToTable("dbo.GroupStudent");
                    });
        }
    }
}
