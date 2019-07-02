﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Uspihh.Models.EntityModels;

namespace Uspihh.EF.Mappings
{
    public class TestMapping : EntityTypeConfiguration<TestEntity>
    {
        public TestMapping()
        {
            ToTable("dbo.Test");
            HasKey(X => X.TestId);

            Property(x => x.TestId).HasColumnName("TestId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.TestName).HasColumnName("TestName").IsRequired().HasMaxLength(50);
        }
    }
}
