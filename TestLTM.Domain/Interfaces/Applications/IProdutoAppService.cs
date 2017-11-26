using TestLTM.Domain.Entities;
using System;
using System.Collections.Generic;

namespace TestLTM.Domain.Interfaces.Applications
{
    public interface IProdutoAppService : IAppServiceBase, IAppDataServiceBase<Produto>
    {
        List<Produto> ObterTodas();
        void Criar(Produto produto);
        void Alterar(Produto produto);
        void Excluir(Guid IdProduto);
    }
}
