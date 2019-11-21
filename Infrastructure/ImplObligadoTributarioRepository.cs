using System.Collections.Generic;
using DependecyInjectionExample.Domain.Model;
using DependecyInjectionExample.Domain.Repository;

namespace DependecyInjectionExample.Infrastructure
{
    public class ImplObligadoTributarioRepository : IObligadoTributarioRepository
    {
        public bool CrearObligadoTributario(ObligadoTributario obligadoTributario)
        {
            //ingresarlo a la base de datos
            return true;
        }

        public bool DarDeBajaObligadoTributario(ObligadoTributario oobligadoTributario)
        {
            //aqui va lógica para dar de baja 
            return true;
        }

        public IList<ObligadoTributario> getListaObligadoTributario()
        {
            var lista= new List<ObligadoTributario>()
            {
                new ObligadoTributario()
                {
                    Rtn="0601199500018",
                    Nombre="Javier Mayorga chavalo"
                    
                },
                new ObligadoTributario()
                {
                    Rtn="0501199400014",
                    Nombre="Juan Baquedano Tiger"
                    
                },
                new ObligadoTributario()
                {
                    Rtn="0801199800029",
                    Nombre="Jimy el crack"
                    
                }
            };

            return lista;
        }
    }
}