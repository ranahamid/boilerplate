using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Boiler.EntityFramework.Repositories
{
    public abstract class BoilerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BoilerRepositoryBase(IDbContextProvider<BoilerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BoilerRepositoryBase<TEntity> : BoilerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BoilerRepositoryBase(IDbContextProvider<BoilerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
