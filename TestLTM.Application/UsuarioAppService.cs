using System;
using System.Linq;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Applications;
using TestLTM.Domain.Interfaces.Services;

namespace TestLTM.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IUnitOfWorkService _uow;

        public UsuarioAppService(IUnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
            _usuarioService = uow.Service<IUsuarioService>();
        }

        public void Registrar(Usuario usuario)
        {
            if (Get(el => el.Login == usuario.Login) != null)
                throw new Exception("Usuário já existe!");
            Add(usuario);
            _uow.Commit();
        }
        public Usuario Autenticar(string login, string senha)
        {
            return Get(el => el.Login == login && el.Senha == senha);
        }
    }
}
