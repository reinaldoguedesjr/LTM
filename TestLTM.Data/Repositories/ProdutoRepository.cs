using TestLTM.Data.Context;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Repositories;

namespace TestLTM.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
