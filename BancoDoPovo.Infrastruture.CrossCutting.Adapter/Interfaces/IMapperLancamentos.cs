using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Domain.Models;
using System.Collections.Generic;

namespace BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IMapperLancamentos
    {
        #region Interfaces Mappers
        Lancamentos MapperToEntity(LancamentosDTO lancamentosDTO);

        IEnumerable<LancamentosDTO> MapperListLancamentos(IEnumerable<Lancamentos> lancamentos);

        LancamentosDTO MapperToDTO(Lancamentos lancamento);

        #endregion

    }
}
