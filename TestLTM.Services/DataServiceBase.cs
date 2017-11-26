using System;
using System.Collections.Generic;
using System.Linq;
using TestLTM.Domain.Interfaces.Repositories;
using TestLTM.Domain.Interfaces.Services;

namespace TestLTM.Services
{
    public class DataServiceBase<TEntity> : ServiceBase, IDataServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly IUnitOfWorkService _uow;

        public DataServiceBase(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
            _repository = uow.Repository<IRepositoryBase<TEntity>>();
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> expr)
        {
            return _repository.Find(expr);
        }

        public TEntity Get(Func<TEntity, bool> expr)
        {
            return _repository.Get(expr);
        }
    }
}
