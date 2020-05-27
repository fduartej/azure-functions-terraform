using System;
using System.Collections.Generic;
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
    public class PaymentHttpTrigger
    {

        private readonly IPaymentService _paymentService;

        public PaymentHttpTrigger(
            IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [FunctionName("GetPayments")]
        public IActionResult GetPayments(
            [HttpTrigger(AuthorizationLevel.Function, "get",  Route = "payments")] 
            HttpRequest req,
            ILogger log)
        {
            //var paymentList = new List<Payment>();
            //paymentList.Add(new Payment() { Id = 1, Description = "product 1", Ammount =10.2M, Due = new DateTime(), Message ="Message 1" });
            //paymentList.Add(new Payment() { Id = 1, Description = "product 2", Ammount =20.2M, Due = new DateTime(), Message ="Message 2" });
            var paymentList = _paymentService.List();
            return new OkObjectResult( paymentList);
        }

        [FunctionName("CreatePayments")]
        public async Task<IActionResult> CreatePayments(
            [HttpTrigger(AuthorizationLevel.Function, "post",  Route = "payments")] 
            HttpRequest req,
            ILogger log
        )
        {
            var payment = 
                JsonConvert.DeserializeObject<Payment>(
                    await new StreamReader(req.Body).ReadToEndAsync());
            payment.Message = "internal message";
            _paymentService.Add(payment);
            return new CreatedResult("Payment", payment);
        }

        
    }
}
