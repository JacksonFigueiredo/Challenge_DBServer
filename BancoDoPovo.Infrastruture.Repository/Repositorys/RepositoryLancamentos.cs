using BancoDoPovo.Domain.Core.Interfaces.Repositorys;
using BancoDoPovo.Domain.Models;
using BancoDoPovo.Infrastructure.Data;

namespace BancoDoPovo.Infrastruture.Repository.Repositorys
{
    public class RepositoryLancamentos : RepositoryBase<Lancamentos>, IRepositoryLancamentos
    {

        private readonly SqlContext _context;
        public RepositoryLancamentos(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
