using System.Collections.Generic;
using DependecyInjectionExample.Domain.Model;
using DependecyInjectionExample.Domain.Repository;

namespace DependecyInjectionExample.Domain.Services
{
    public class ManagerObligadoTributario
    {
        private IObligadoTributarioRepository _repo;
        
        public ManagerObligadoTributario(IObligadoTributarioRepository repo)
        {
            _repo=repo;
        }

     public IList<ObligadoTributario> getListaObligadoTributario()
        {
            return _repo.getListaObligadoTributario();
        }
      public bool CrearObligadoTributario(ObligadoTributario obligadoTributario)
       {
           return _repo.CrearObligadoTributario(obligadoTributario);
       }

       public bool DarDeBajaObligadoTributario(ObligadoTributario oobligadoTributario)
       {
           return _repo.DarDeBajaObligadoTributario(oobligadoTributario);
       }


    }
}