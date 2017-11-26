using System.Linq;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace TestLTM.Services
{
    public class ProdutoService : DataServiceBase<Produto>, IProdutoService
    {
        private readonly IUnitOfWorkService _uow;

        public ProdutoService(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
        }

        public List<Produto> ObterTodas()
        {
            return GetAll().ToList();
        }
    }
}
