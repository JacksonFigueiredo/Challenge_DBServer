using BancoDoPovo.Domain.Core.Interfaces.Repositorys;
using BancoDoPovo.Domain.Core.Interfaces.Services;
using BancoDoPovo.Domain.Models;

namespace BancoDoPovo.Domain.Services.Services
{
    public class ServiceContaCorrente : ServiceBase<ContaCorrente>, IServiceContaCorrente
    {
        public readonly IRepositoryContaCorrente _repositoryContaCorrente;

        public ServiceContaCorrente(IRepositoryContaCorrente RepositoryContaCorrente)
            : base(RepositoryContaCorrente)
        {
            _repositoryContaCorrente = RepositoryContaCorrente;
        }

    }
}
