using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Compliance.Domain.Models;

namespace Compliance.Domain.Services
{
    public interface IPaymentService
    { 
        Payment Add(
            Payment payment);

        IEnumerable<Payment> List();
    }
}