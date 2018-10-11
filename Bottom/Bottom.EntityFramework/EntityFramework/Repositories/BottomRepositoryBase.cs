using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Bottom.EntityFramework.Repositories
{
    public abstract class BottomRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BottomDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BottomRepositoryBase(IDbContextProvider<BottomDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BottomRepositoryBase<TEntity> : BottomRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BottomRepositoryBase(IDbContextProvider<BottomDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
