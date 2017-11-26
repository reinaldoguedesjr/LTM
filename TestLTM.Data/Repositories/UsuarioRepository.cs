using TestLTM.Data.Context;
using TestLTM.Domain.Entities;
using TestLTM.Domain.Interfaces.Repositories;

namespace TestLTM.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AngularContext Db)
            : base(Db)
        {
        }
    }
}
