using FbStats.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbStats.Data.Configuration
{
    class TeamConfiguration : EntityTypeConfiguration<Team>
    {
        public TeamConfiguration()
        {
            ToTable("tblTeams");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.TeamCode).IsRequired().HasColumnName("TeamCode").HasColumnType("varchar").HasMaxLength(5);
            Property(c => c.TeamName).IsRequired().HasColumnName("TeamName").HasColumnType("varchar").HasMaxLength(150);

        }
    }
}
