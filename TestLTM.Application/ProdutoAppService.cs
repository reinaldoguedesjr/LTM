using System;
using System.Linq;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Applications;
using TestLTM.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace TestLTM.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        private readonly IUnitOfWorkService _uow;

        public ProdutoAppService(IUnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
            _produtoService = uow.Service<IProdutoService>();
        }

        public List<Produto> ObterTodas()
        {
            return _produtoService.ObterTodas();
        }


        public void Criar(Produto produto)
        {
            Add(produto);
            _uow.Commit();
        }


        public void Alterar(Produto produto)
        {
            Update(produto);
            _uow.Commit();
        }

        public void Excluir(Guid IdProduto)
        {
            Remove(Get(el => el.IdProduto == IdProduto));
            _uow.Commit();
        }
    }
}
