using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Application.Interfaces;
using BancoDoPovo.Domain.Core.Interfaces.Services;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace BancoDoPovo.Application.Service
{
    public class ApplicationServiceLancamentos : IDisposable, IApplicationServiceLancamentos
    {
        private readonly IServiceLancamentos _serviceLancamentos;
        private readonly IMapperLancamentos _mapperLancamentos;

        public ApplicationServiceLancamentos(IServiceLancamentos ServiceLancamentos
                                         , IMapperLancamentos MapperLancamento)
        {
            _serviceLancamentos = ServiceLancamentos;
            _mapperLancamentos = MapperLancamento;
        }

        public void Add(LancamentosDTO obj)
        {
            var objProduto = _mapperLancamentos.MapperToEntity(obj);
            _serviceLancamentos.Add(objProduto);
        }

        public void Dispose()
        {
            _serviceLancamentos.Dispose();
        }

        public IEnumerable<LancamentosDTO> GetAll()
        {
            var objLancamentos = _serviceLancamentos.GetAll();
            return _mapperLancamentos.MapperListLancamentos(objLancamentos);
        }

        public LancamentosDTO GetById(int id)
        {
            var objLancamento = _serviceLancamentos.GetById(id);
            return _mapperLancamentos.MapperToDTO(objLancamento);
        }

        public void Remove(LancamentosDTO obj)
        {
            var objLancamento = _mapperLancamentos.MapperToEntity(obj);
            _serviceLancamentos.Remove(objLancamento);
        }

        public void Update(LancamentosDTO obj)
        {
            var objLancamento = _mapperLancamentos.MapperToEntity(obj);
            _serviceLancamentos.Update(objLancamento);
        }

    }
}
