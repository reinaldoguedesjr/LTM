using TestLTM.Domain.Interfaces.Services;

namespace TestLTM.Services
{
    public class ServiceBase : IServiceBase
    {
        private IUnitOfWorkService _uow;
        public ServiceBase(IUnitOfWorkService uow)
        {
            _uow = uow;
        }
    }
}
