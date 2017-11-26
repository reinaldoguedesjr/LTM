using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Services;

namespace TestLTM.Services
{
    public class UsuarioService : DataServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUnitOfWorkService _uow;

        public UsuarioService(UnitOfWorkService uow)
            : base(uow)
        {
            _uow = uow;
        }
    }
}
