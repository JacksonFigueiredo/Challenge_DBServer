using BancoDoPovo.Application.DTO.DTO;
using System.Collections.Generic;

namespace BancoDoPovo.Application.Interfaces
{
    public interface IApplicationServiceLancamentos
    {
        void Add(LancamentosDTO obj);

        LancamentosDTO GetById(int id);

        IEnumerable<LancamentosDTO> GetAll();

        void Update(LancamentosDTO obj);

        void Remove(LancamentosDTO obj);

        void Dispose();

    }
}
