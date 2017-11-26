using TestLTM.Domain.Entities;
using System.Collections.Generic;

namespace TestLTM.Domain.Interfaces.Services
{
    public interface IProdutoService : IDataServiceBase<Produto>
    {
        List<Produto> ObterTodas();
    }
}
