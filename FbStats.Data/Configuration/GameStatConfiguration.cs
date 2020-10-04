using FbStats.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbStats.Data.Configuration
{
    class GameStatConfiguration : EntityTypeConfiguration<GameStat>
    {
        public GameStatConfiguration()
        {
            ToTable("tblGameStats");
            HasKey(c => c.Id);
            Property(c => c.Id).IsRequired().HasColumnName("Id").HasColumnType("bigint").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.AvgPerCompletion).IsRequired().HasColumnName("AvgPerCompletion").HasColumnType("float");
            Property(c => c.AvgPerRush).IsRequired().HasColumnName("AvgPerRush").HasColumnType("float");
            Property(c => c.ConversionRate).IsRequired().HasColumnName("ConversionRate").HasColumnType("float");
            Property(c => c.FieldGoals).IsRequired().HasColumnName("FieldGoals").HasColumnType("int");
            Property(c => c.ForcedFumbles).HasColumnName("ForcedFumbles").HasColumnType("int").IsRequired();
            Property(c=>c.OpponentId).HasColumnName("OpponentId").HasColumnType("int").IsRequired();
            Property(c=>c.PassAttempts).HasColumnName("PassAttempts").HasColumnType("int").IsRequired();
            Property(c=>c.PassCompleted).HasColumnName("PassCompleted").HasColumnType("int").IsRequired();
            Property(c=>c.PassOverFifteen).HasColumnName("PassOverFifteen").HasColumnType("int").IsRequired();
            Property(c=>c.PassYards).HasColumnName("PassYards").HasColumnType("int").IsRequired();
            Property(c=>c.Penalties).HasColumnName("Penalties").HasColumnType("int").IsRequired();
            Property(c=>c.PenaltyYards).HasColumnName("PenaltyYards").HasColumnType("int").IsRequired();
            Property(c=>c.PointsAllowed).HasColumnName("PointsAllowed").HasColumnType("int").IsRequired();
            Property(c=>c.PointsScored).HasColumnName("PointsScored").HasColumnType("int").IsRequired();
            Property(c=>c.Punts).HasColumnName("Punts").HasColumnType("int").IsRequired();
            Property(c=>c.ReturnYards).HasColumnName("ReturnYards").HasColumnType("int").IsRequired();
            Property(c=>c.RushAttempts).HasColumnName("RushAttempts").HasColumnType("int").IsRequired();
            Property(c=>c.RushOverTen).HasColumnName("RushOverTen").HasColumnType("int").IsRequired();
            Property(c=>c.RushYards).HasColumnName("RushYards").HasColumnType("int").IsRequired();
            Property(c=>c.TeamId).HasColumnName("TeamId").HasColumnType("int").IsRequired();
            Property(c=>c.TotalPlays).HasColumnName("TotalPlays").HasColumnType("int").IsRequired();
            Property(c=>c.Touchdowns).HasColumnName("Touchdowns").HasColumnType("int").IsRequired();
            Property(c=>c.Turnovers).HasColumnName("Turnovers").HasColumnType("int").IsRequired();
            Property(c=>c.WeekNumber).HasColumnName("WeekNumber").HasColumnType("int").IsRequired();
            
        }
    }
}
