using Autofac;
using BancoDoPovo.Application.Interfaces;
using BancoDoPovo.Application.Service;
using BancoDoPovo.Domain.Core.Interfaces.Repositorys;
using BancoDoPovo.Domain.Core.Interfaces.Services;
using BancoDoPovo.Domain.Services.Services;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Interfaces;
using BancoDoPovo.Infrastruture.CrossCutting.Adapter.Map;
using BancoDoPovo.Infrastruture.Repository.Repositorys;

namespace BancoDoPovo.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceContaCorrente>().As<IApplicationServiceContaCorrente>();
            builder.RegisterType<ApplicationServiceLancamentos>().As<IApplicationServiceLancamentos>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceContaCorrente>().As<IServiceContaCorrente>();
            builder.RegisterType<IServiceLancamentos>().As<IServiceLancamentos>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryContaCorrente>().As<IRepositoryContaCorrente>();
            builder.RegisterType<RepositoryLancamentos>().As<IRepositoryLancamentos>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperContaCorrente>().As<IMapperContaCorrente>();
            builder.RegisterType<MapperLancamentos>().As<IMapperLancamentos>();
            #endregion

            #endregion

        }
    }
}
