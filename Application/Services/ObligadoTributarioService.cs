using System.Collections.Generic;
using DependecyInjectionExample.Domain.Model;
using DependecyInjectionExample.Domain.Services;
using DependecyInjectionExample.Infrastructure;

namespace DependecyInjectionExample.Application.Services
{
    public class ObligadoTributarioService
    {
        private ManagerObligadoTributario _manager;

        /*
          Mostramos que la Clase ObligadoTributarioService funciona como la clase que inyectara las dependencias de
          la clase ManagerObligadoTributario (Servicio)
        */

        public ObligadoTributarioService()
        {
            _manager=new ManagerObligadoTributario(new ImplObligadoTributarioRepository());
        }

        public IList<ObligadoTributario> getListaObligadoTributario()
        {
            return _manager.getListaObligadoTributario();
        }
      public bool CrearObligadoTributario(ObligadoTributario obligadoTributario)
       {
           return _manager.CrearObligadoTributario(obligadoTributario);
       }

      public bool DarDeBajaObligadoTributario(ObligadoTributario oobligadoTributario)
       {
           return _manager.DarDeBajaObligadoTributario(oobligadoTributario);
       }

    }
}