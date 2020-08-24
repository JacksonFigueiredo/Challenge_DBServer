using BancoDoPovo.Domain.Core.Interfaces.Repositorys;
using BancoDoPovo.Domain.Core.Interfaces.Services;
using BancoDoPovo.Domain.Models;

namespace BancoDoPovo.Domain.Services.Services
{
    public class ServiceLancamentos : ServiceBase<Lancamentos>, IServiceLancamentos
    {
        private readonly IRepositoryLancamentos _repositoryLancamentos;

        public ServiceLancamentos(IRepositoryLancamentos RepositoryLancamentos)
            : base(RepositoryLancamentos)
        {
            _repositoryLancamentos = RepositoryLancamentos;
        }
    }
}
