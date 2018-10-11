using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Top.EntityFramework.Repositories
{
    public abstract class TopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TopRepositoryBase(IDbContextProvider<TopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TopRepositoryBase<TEntity> : TopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TopRepositoryBase(IDbContextProvider<TopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
