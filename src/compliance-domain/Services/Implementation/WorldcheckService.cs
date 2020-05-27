using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Compliance.Domain.Models;
using Compliance.Domain.Data;

namespace Compliance.Domain.Services
{

    public class WorldcheckService : IWorldcheckService
    {

        private readonly DatabaseContext _dbContext;

        public WorldcheckService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Worldcheck> List()
        {
            return _dbContext.Worldchecks.ToList();
        }

        public IEnumerable<Worldcheck> ListNombreApellido(string nombre, string apellido)
        {
           var dbResults = _dbContext.Worldchecks.FromSqlRaw("EXEC dbo.Usp_BusquedaPersona_WordlCheck @Nombre={0}, @Apellido={1}",nombre,apellido).ToList();
           return dbResults.ToList();
        }

        public Worldcheck Add(
            Worldcheck worldcheck)
        {
            _dbContext.Add(worldcheck);
            _dbContext.SaveChanges();
            return worldcheck;
        }

    }


}