using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Domain.Models;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace BancoDoPovo.Infrastruture.CrossCutting.Adapter.Map
{
    public class MapperContaCorrente : IMapperContaCorrente
    {

        #region properties

        List<ContaCorrenteDTO> contacorrenteDTOs = new List<ContaCorrenteDTO>();

        #endregion


        #region methods

        public ContaCorrente MapperToEntity(ContaCorrenteDTO contacorrenteDTO)
        {
            ContaCorrente contacorrente = new ContaCorrente
            {
                Id = contacorrenteDTO.Id,
                NomeCorrentista = contacorrenteDTO.NomeCorrentista,
                Agencia = contacorrenteDTO.Agencia,
                NumeroContaCorrente = contacorrenteDTO.NumeroContaCorrente,
                Digito = contacorrenteDTO.Digito,
                Saldo = contacorrenteDTO.Saldo
            };
            return contacorrente;
        }


        public IEnumerable<ContaCorrenteDTO> MapperListarContasCorrentes(IEnumerable<ContaCorrente> contascorrentes)
        {
            foreach (var item in contascorrentes)
            {
                ContaCorrenteDTO contacorrente = new ContaCorrenteDTO
                {
                    Id = item.Id,
                    NomeCorrentista = item.NomeCorrentista,
                    Agencia = item.Agencia,
                    NumeroContaCorrente = item.NumeroContaCorrente,
                    Digito = item.Digito,
                    Saldo = item.Saldo
                };
                contacorrenteDTOs.Add(contacorrente);
            }
            return contacorrenteDTOs;
        }

        public ContaCorrenteDTO MapperToDTO(ContaCorrente contacorrente)
        {
            ContaCorrenteDTO contacorrenteDTO = new ContaCorrenteDTO
            {
                Id = contacorrente.Id,
                NomeCorrentista = contacorrente.NomeCorrentista,
                Agencia = contacorrente.Agencia,
                NumeroContaCorrente = contacorrente.NumeroContaCorrente,
                Digito = contacorrente.Digito,
                Saldo = contacorrente.Saldo
            };
            return contacorrenteDTO;
        }

        #endregion

    }
}
