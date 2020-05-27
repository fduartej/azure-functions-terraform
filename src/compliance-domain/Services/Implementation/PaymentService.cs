using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Compliance.Domain.Models;
using Compliance.Domain.Data;

namespace Compliance.Domain.Services
{

    public class PaymentService : IPaymentService
    {

        private readonly DatabaseContext _dbContext;

        public PaymentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Payment> List()
        {
            return _dbContext.Payments.ToList();
        }


        public Payment Add(
            Payment payment)
        {
            _dbContext.Add(payment);
            _dbContext.SaveChanges();
            return payment;
        }

    }


}