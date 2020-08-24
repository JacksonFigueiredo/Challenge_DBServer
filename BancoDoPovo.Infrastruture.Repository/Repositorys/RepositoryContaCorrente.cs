using BancoDoPovo.Domain.Core.Interfaces.Repositorys;
using BancoDoPovo.Domain.Models;
using BancoDoPovo.Infrastructure.Data;

namespace BancoDoPovo.Infrastruture.Repository.Repositorys
{
    public class RepositoryContaCorrente : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        private readonly SqlContext _context;
        public RepositoryContaCorrente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
