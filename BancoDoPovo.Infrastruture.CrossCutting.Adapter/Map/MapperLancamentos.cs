using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Domain.Models;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace BancoDoPovo.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperLancamentos : IMapperLancamentos
    {

        #region Properties

        List<LancamentosDTO> produtoDTOs = new List<LancamentosDTO>();

        #endregion

        #region methods

        public Lancamentos MapperToEntity(LancamentosDTO lancamentosDTO)
        {
            Lancamentos produto = new Lancamentos
            {

                Id = lancamentosDTO.Id,
                ContaOrigem = lancamentosDTO.ContaOrigem,
                ContaDestino = lancamentosDTO.ContaDestino,
                Operacao = lancamentosDTO.Operacao,
                Valor = lancamentosDTO.Valor
            };

            return produto;

        }

        public IEnumerable<LancamentosDTO> MapperListLancamentos(IEnumerable<Lancamentos> lancamentos)
        {
            foreach (var item in lancamentos)
            {
                LancamentosDTO produtoDTO = new LancamentosDTO
                {
                    Id = item.Id,
                    ContaOrigem = item.ContaOrigem,
                    ContaDestino = item.ContaDestino,
                    Operacao = item.Operacao,
                    Valor = item.Valor,
                };

                produtoDTOs.Add(produtoDTO);
            }
            return produtoDTOs;
        }

        public LancamentosDTO MapperToDTO(Lancamentos lancamento)
        {
            LancamentosDTO lancamentoDTO = new LancamentosDTO
            {
                Id = lancamento.Id,
                ContaOrigem = lancamento.ContaOrigem,
                ContaDestino = lancamento.ContaDestino,
                Valor = lancamento.Valor,
                Operacao = lancamento.Operacao
            };
            return lancamentoDTO;
        }

        #endregion
    }
}
