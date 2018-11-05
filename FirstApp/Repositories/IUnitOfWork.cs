using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.Entities;

namespace FirstApp.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> UsersRepository { get; }
        IGenericRepository<Role> RolesRepository { get; set; }
        IGenericRepository<Skill> SkillsRepository { get; set; }

        void Save();
    }
}
