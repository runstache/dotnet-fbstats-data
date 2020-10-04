using FbStats.Data.Contexts;
using FbStats.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FbStats.Data.Repositories
{
    public class SqlRepository : IRepository
    {

        private readonly SqlContext ctx;

        public SqlRepository(string connString)
        {
            this.ctx = new SqlContext(connString);
        }

        public SqlRepository(SqlContext ctx)
        {
            this.ctx = ctx;
        }

        public void Delete(Team team)
        {
            ctx.Teams.Remove(team);
            ctx.SaveChanges();            
        }

        public void Delete(GameStat stat)
        {
            ctx.Stats.Remove(stat);
            ctx.SaveChanges();
        }

        public GameStat GetStat(long id)
        {
            return ctx.Stats.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<GameStat> GetStats()
        {
            return ctx.Stats;
        }

        public IQueryable<GameStat> GetStats(int teamId)
        {
            return ctx.Stats.Where(c => c.TeamId == teamId);
        }

        public Team GetTeam(int id)
        {
            return ctx.Teams.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<Team> GetTeams()
        {
            return ctx.Teams;
        }

        public Team Insert(Team team)
        {
            Team result = ctx.Teams.Add(team);
            ctx.SaveChanges();
            return result;
        }

        public GameStat Insert(GameStat stat)
        {
            GameStat result = ctx.Stats.Add(stat);
            ctx.SaveChanges();
            return result;
        }

        public Team Update(Team team)
        {
            if (team.Id > 0)
            {
                Team orig = GetTeam(team.Id);
                if (!orig.Equals(team))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(team);
                    ctx.SaveChanges();
                }
                return GetTeam(team.Id);
            }
            else
            {
                return Insert(team);
            }
        }

        public GameStat Update(GameStat stat)
        {
            if (stat.Id > 0)
            {
                GameStat orig = GetStat(stat.Id);
                if (!orig.Equals(stat))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(stat);
                    ctx.SaveChanges();
                }
                return GetStat(stat.Id);
            }
            else
            {
                return Insert(stat);
            }
        }
    }
}
