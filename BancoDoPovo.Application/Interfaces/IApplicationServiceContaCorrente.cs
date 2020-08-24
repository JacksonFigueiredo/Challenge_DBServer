using BancoDoPovo.Application.DTO.DTO;
using System.Collections.Generic;

namespace BancoDoPovo.Application.Interfaces
{
    public interface IApplicationServiceContaCorrente
    {
        void Add(ContaCorrenteDTO obj);

        ContaCorrenteDTO GetById(int id);

        IEnumerable<ContaCorrenteDTO> GetAll();

        void Update(ContaCorrenteDTO obj);

        void Remove(ContaCorrenteDTO obj);

        void Dispose();

    }
}
