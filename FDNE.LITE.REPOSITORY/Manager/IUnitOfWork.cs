using FDNE.LITE.ENTITIES.Models;
using FDNE.LITE.REPOSITORY.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FDNE.LITE.REPOSITORY.Manager
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ApplicationUser> UserRepository { get; }
        IRepository<Binomial> BinomialRepository { get; }
        IRepository<Category> CategoryRepository { get; }
        IRepository<Club> ClubRepository { get; }
        IRepository<Contest> ContestRepository { get; }
        IRepository<Discipline> DisciplineRepository { get; }
        IRepository<Horse> HorseRepository { get; }
        IRepository<News> NewsRepository { get; }
        IRepository<Ranking> RankingRepository { get; }
        IRepository<Result> ResultRepository { get; }
        IRepository<IdentityRole> RoleRepository { get; }
        IRepository<Season> SeasonRepository { get; }
        Task SaveAsync();
        void Save();
    }
}
