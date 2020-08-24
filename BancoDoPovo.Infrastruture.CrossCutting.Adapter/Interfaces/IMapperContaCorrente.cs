using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Domain.Models;
using System.Collections.Generic;

namespace BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperContaCorrente
    {
        #region Mappers

        ContaCorrente MapperToEntity(ContaCorrenteDTO contacorrenteDTO);

        IEnumerable<ContaCorrenteDTO> MapperListarContasCorrentes(IEnumerable<ContaCorrente> contacorrente);

        ContaCorrenteDTO MapperToDTO(ContaCorrente ContaCorrente);

        #endregion

    }
}
