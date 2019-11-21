using System;
using DependecyInjectionExample.Application.Services;

namespace DependecyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ObligadoTributarioService service= new ObligadoTributarioService();
            
            System.Console.WriteLine("Get Obligados Tributarios");

            var lista= service.getListaObligadoTributario();

            foreach (var item in lista)
            {
                  System.Console.WriteLine("RTN {0} ",item.Rtn);
                  System.Console.WriteLine("Nombre {0} ",item.Nombre);
            }

        }
    }
}
