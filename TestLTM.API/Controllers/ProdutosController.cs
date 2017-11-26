using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Applications;

namespace TestLTM.API.Controllers
{
    [RoutePrefix("api/produtos")]
    public class ProdutosController : ApiController
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [Authorize(Roles = "User")]
        public List<Produto> GetProdutos()
        {
            return _produtoAppService.ObterTodas();
        }


        [HttpPost]
        [Authorize(Roles = "User")]
        public HttpResponseMessage Criar(Produto produto)
        {
            try
            {
                produto.IdProduto = Guid.NewGuid();
                produto.DataInclusao = DateTime.Now;
                _produtoAppService.Criar(produto);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }


        [HttpPatch]
        [Authorize(Roles = "User")]
        public HttpResponseMessage Alterar(Produto produto)
        {
            try
            {
                _produtoAppService.Alterar(produto);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }


        [HttpDelete]
        [Authorize(Roles = "User")]
        public HttpResponseMessage Excluir(Guid id)
        {
            try
            {
                _produtoAppService.Excluir(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
