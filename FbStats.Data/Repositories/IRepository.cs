using FbStats.Data.DataObjects;
using System.Linq;

namespace FbStats.Data.Repositories
{
    public interface IRepository
    {

        #region Insert Methods

        Team Insert(Team team);
        GameStat Insert(GameStat stat);

        #endregion

        #region Update Methods

        Team Update(Team team);
        GameStat Update(GameStat stat);

        #endregion

        #region Retrieval Methods

        IQueryable<Team> GetTeams();
        IQueryable<GameStat> GetStats();
        IQueryable<GameStat> GetStats(int teamId);
        Team GetTeam(int id);
        GameStat GetStat(long id);

        #endregion

        #region Delete Methods

        void Delete(Team team);

        void Delete(GameStat stat);

        #endregion




    }
}
