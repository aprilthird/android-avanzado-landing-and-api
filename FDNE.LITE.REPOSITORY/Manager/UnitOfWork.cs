using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FDNE.LITE.DATA.Context;
using FDNE.LITE.ENTITIES.Models;
using FDNE.LITE.REPOSITORY.Repositories.Base;
using Microsoft.AspNetCore.Identity;

namespace FDNE.LITE.REPOSITORY.Manager
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FdneContext _context;
        private readonly IRepository<ApplicationUser> _userRepository;
        private readonly IRepository<Binomial> _binomialRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Club> _clubRepository;
        private readonly IRepository<Contest> _contestRepository;
        private readonly IRepository<Discipline> _disciplineRepository;
        private readonly IRepository<Horse> _horseRepository;
        private readonly IRepository<News> _newsRepository;
        private readonly IRepository<Ranking> _rankingRepository;
        private readonly IRepository<Result> _resultRepository;
        private readonly IRepository<IdentityRole> _roleRepository;
        private readonly IRepository<Season> _seasonRepository;

        public UnitOfWork(FdneContext context, IRepository<ApplicationUser> userRepository,
            IRepository<Binomial> binomialRepository, IRepository<Category> categoryRepository,
            IRepository<Club> clubRepository, IRepository<Contest> contestRepository,
            IRepository<Discipline> disciplineRepository, IRepository<Horse> horseRepository,
            IRepository<News> newsRepository, IRepository<Ranking> rankingRepository,
            IRepository<Result> resultRepository, IRepository<IdentityRole> roleRepository,
            IRepository<Season> seasonRepository)
        {
            _context = context;
            _userRepository = userRepository;
            _binomialRepository = binomialRepository;
            _categoryRepository = categoryRepository;
            _clubRepository = clubRepository;
            _disciplineRepository = disciplineRepository;
            _horseRepository = horseRepository;
            _newsRepository = newsRepository;
            _rankingRepository = rankingRepository;
            _resultRepository = resultRepository;
            _roleRepository = roleRepository;
            _seasonRepository = seasonRepository;
        }

        public IRepository<ApplicationUser> Users
        {
            get
            {
                if (_userRepository == null)
                    throw new ArgumentException("Missing repository");
                return _userRepository;
            }
        }

        public IRepository<Binomial> Binomials
        {
            get
            {
                if(_binomialRepository == null)
                    throw new ArgumentException("Missing repository");
                return _binomialRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if(_categoryRepository == null)
                    throw new ArgumentException("Missing repository");
                return _categoryRepository;
            }
        }
        
        public IRepository<Club> Clubs
        {
            get
            {
                if(_clubRepository == null)
                    throw new ArgumentException("Missing repository");
                return _clubRepository;
            }
        }

        public IRepository<Contest> Contests
        {
            get
            {
                if(_contestRepository == null)
                    throw new ArgumentException("Missing repository");
                return _contestRepository;
            }
        }

        public IRepository<Discipline> Disciplines
        {
            get
            {
                if(_disciplineRepository == null)
                    throw new ArgumentException("Missing repository");
                return _disciplineRepository;
            }
        }

        public IRepository<Horse> Horses
        {
            get
            {
                if(_horseRepository == null)
                    throw new ArgumentException("Missing repository");
                return _horseRepository;
            }
        }

        public IRepository<News> News
        {
            get
            {
                if(_newsRepository == null)
                    throw new ArgumentException("Missing repository");
                return _newsRepository;
            }
        }

        public IRepository<Ranking> Rankings
        {
            get
            {
                if(_rankingRepository == null)
                    throw new ArgumentException("Missing repository");
                return _rankingRepository;
            }
        }

        public IRepository<Result> Results
        {
            get
            {
                if(_resultRepository == null)
                    throw new ArgumentException("Missing repository");
                return _resultRepository;
            }
        }

        public IRepository<IdentityRole> Roles
        {
            get
            {
                if(_roleRepository == null)
                    throw new ArgumentException("Missing repository");
                return _roleRepository;
            }
        }

        public IRepository<Season> Seasons
        {
            get
            {
                if(_seasonRepository == null)
                    throw new ArgumentException("Missing repository");
                return _seasonRepository;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save() => _context.SaveChanges();

        public Task SaveAsync() => _context.SaveChangesAsync();
        
    }
}
