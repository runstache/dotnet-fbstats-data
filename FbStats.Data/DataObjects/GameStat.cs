using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbStats.Data.DataObjects
{
    public class GameStat
    {
        public long Id { get; set; }
        public int TeamId { get; set; }

        public int WeekNumber { get; set; }
        public int OpponentId { get; set; }
        public int PassAttempts { get; set; }
        public int PassCompleted { get; set; }

        public double AvgPerCompletion { get; set; }

        public int PassYards { get; set; }
        public int RushAttempts { get; set; }
        public int RushYards { get; set; }
        public double AvgPerRush { get; set; }

        public double ConversionRate { get; set; }
        public int PointsScored { get; set; }
        public int PointsAllowed { get; set; }
        public int Touchdowns { get; set; }
        public int FieldGoals { get; set; }
        public int TotalPlays { get; set; }
        public int RushOverTen { get; set; }
        public int PassOverFifteen { get; set; }
        public int ReturnYards { get; set; }
        public int Turnovers { get; set; }
        public int ForcedFumbles { get; set; }
        public int Punts { get; set; }
        public int Penalties { get; set; }
        public int PenaltyYards { get; set; }
    }
}
