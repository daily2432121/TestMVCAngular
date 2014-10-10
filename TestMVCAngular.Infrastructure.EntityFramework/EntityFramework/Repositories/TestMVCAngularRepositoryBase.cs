using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace TestMVCAngular.EntityFramework.Repositories
{
    public abstract class TestMVCAngularRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestMVCAngularDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class TestMVCAngularRepositoryBase<TEntity> : TestMVCAngularRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
