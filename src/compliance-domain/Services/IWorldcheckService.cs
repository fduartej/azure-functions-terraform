using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Compliance.Domain.Models;

namespace Compliance.Domain.Services
{
    public interface IWorldcheckService
    { 
        Worldcheck Add(
            Worldcheck worldcheck);

        IEnumerable<Worldcheck> List();
        IEnumerable<Worldcheck> ListNombreApellido(string nombre,string apellido);
    }
}