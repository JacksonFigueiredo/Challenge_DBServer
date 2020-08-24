using BancoDoPovo.Application.DTO.DTO;
using BancoDoPovo.Application.Interfaces;
using BancoDoPovo.Domain.Core.Interfaces.Services;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace BancoDoPovo.Application.Service
{
    public class ApplicationServiceContaCorrente : IApplicationServiceContaCorrente
    {
        private readonly IServiceContaCorrente _serviceContaCorrente;
        private readonly IMapperContaCorrente _mapperContaCorrente;
     
        public ApplicationServiceContaCorrente(IServiceContaCorrente ServiceContaCorrente
                                                 , IMapperContaCorrente MapperContaCorrente)
                                              
        {
            _serviceContaCorrente = ServiceContaCorrente;
            _mapperContaCorrente = MapperContaCorrente;
        }


        public void Add(ContaCorrenteDTO obj)
        {
            var objContaCorrente = _mapperContaCorrente.MapperToEntity(obj);
            _serviceContaCorrente.Add(objContaCorrente);
        }

        public void Dispose()
        {
            _serviceContaCorrente.Dispose();
        }

        public IEnumerable<ContaCorrenteDTO> GetAll()
        {
            var objContaCorrente = _serviceContaCorrente.GetAll();
            return _mapperContaCorrente.MapperListarContasCorrentes(objContaCorrente);
        }

        public ContaCorrenteDTO GetById(int id)
        {
            var objContaCorrente = _serviceContaCorrente.GetById(id);
            return _mapperContaCorrente.MapperToDTO(objContaCorrente);
        }

        public void Remove(ContaCorrenteDTO obj)
        {
            var objContaCorrente = _mapperContaCorrente.MapperToEntity(obj);
            _serviceContaCorrente.Remove(objContaCorrente);
        }

        public void Update(ContaCorrenteDTO obj)
        {
            var objContaCorrente = _mapperContaCorrente.MapperToEntity(obj);
            _serviceContaCorrente.Update(objContaCorrente);
        }
    }
}
