using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Compliance.Domain.Services;
using Compliance.Domain.Models;


namespace Compliance.Functions
{
    public class WordCheckHttpTrigger
    {

        private readonly IWorldcheckService _worldcheckService;

        public WordCheckHttpTrigger(IWorldcheckService worldcheckService)
        {
              _worldcheckService = worldcheckService;
        }


        [FunctionName("GetWordChecks")]
        public IActionResult GetWordChecks(
            [HttpTrigger(AuthorizationLevel.Function, "get",  Route = "wordcheks/{nombre}/{apellido}")] 
            HttpRequest req,
            string nombre,
            string apellido,
            ILogger log
        )
        {
            if ( String.IsNullOrEmpty(nombre) ||
                String.IsNullOrEmpty(apellido)
            )
            {
                return new NotFoundResult();
            }
            var worldcheckList = _worldcheckService.ListNombreApellido(nombre,apellido);
            return new OkObjectResult(worldcheckList);
        }

    }
}
