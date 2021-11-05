using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Server.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            //return base.GetCustomerInfo(request, context);
            CustomerModel output = new CustomerModel();
            if (request.UserId == 1)
            {
                output.FirstName = "Shoaib";
                output.LastName = "Sikander";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Muhammad";
                output.LastName = "Shoaib";
            }
            else            {
                output.FirstName = "Muhammad";
                output.LastName = "Sikander";
            }
            return Task.FromResult(output);
        }
        
    }
}
