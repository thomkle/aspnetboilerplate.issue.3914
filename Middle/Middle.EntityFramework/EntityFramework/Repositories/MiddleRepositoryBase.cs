using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Middle.EntityFramework.Repositories
{
    public abstract class MiddleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MiddleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MiddleRepositoryBase(IDbContextProvider<MiddleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MiddleRepositoryBase<TEntity> : MiddleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MiddleRepositoryBase(IDbContextProvider<MiddleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
