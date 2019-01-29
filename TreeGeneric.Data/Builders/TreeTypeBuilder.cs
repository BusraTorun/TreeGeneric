﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.Data.Builders
{
    public class TreeTypeBuilder
    {
        public TreeTypeBuilder(EntityTypeConfiguration<TreeType> entity)
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Photo).IsRequired().HasMaxLength(200);
            entity.HasRequired(p => p.Region).WithMany(m => m.TreeTypes).HasForeignKey(p => p.RegionId).WillCascadeOnDelete(false);
        }
    }
}
