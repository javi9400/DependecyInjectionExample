using System.Collections.Generic;
using DependecyInjectionExample.Domain.Model;

namespace DependecyInjectionExample.Domain.Repository
{
    public interface IObligadoTributarioRepository
    {
      
       IList<ObligadoTributario> getListaObligadoTributario();
       bool CrearObligadoTributario(ObligadoTributario obligadoTributario);

       bool DarDeBajaObligadoTributario(ObligadoTributario oobligadoTributario);

    }
}