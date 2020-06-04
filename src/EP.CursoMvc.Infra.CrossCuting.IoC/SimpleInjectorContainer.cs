using EP.CursoMvc.Application.Interfaces;
using EP.CursoMvc.Application.Services;
using EP.CursoMvc.Domain.Interfaces;
using EP.CursoMvc.Domain.Interfaces.Services;
using EP.CursoMvc.Domain.Services;
using EP.CursoMvc.Infra.Data.Context;
using EP.CursoMvc.Infra.Data.Repository;
using EP.CursoMvc.Infra.Data.UoW;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Infra.CrossCuting.IoC
{
    //IoC => Inversion of Control
   public class SimpleInjectorContainer
    {
        public static void Register(Container container)
        {
            //Lifestyle.Transient => Uma instância para cada solicitação
            //Lifestyle.Singleton => Uma instância única para a classe
            //Lifestyle.Scoped => Uma instância única para o request 


            //APP
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);

            //Domain
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

            //Infra.Data
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            container.Register<CursoMvcContext>(Lifestyle.Scoped);
        }
    }
}
