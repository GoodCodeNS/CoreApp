using System;
using FirstApp.Entities;
using Microsoft.EntityFrameworkCore;
using Unity.Attributes;

namespace FirstApp.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        [Dependency]
        public IGenericRepository<User> UsersRepository { get; set; }

        [Dependency]
        public IGenericRepository<Role> RolesRepository { get; set; }

        [Dependency]
        public IGenericRepository<Skill> SkillsRepository { get; set; }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}