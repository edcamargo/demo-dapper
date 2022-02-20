using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Domain.Core.Handlers.Customers.Requests.Contracts
{
    public class CreateCustomerRequestContract : Contract<CreateCustomerRequest>
    {
        public CreateCustomerRequestContract(CreateCustomerRequest request)
        {
            Requires()
                .IsNotNullOrEmpty(request.Name, "Name", "Custom error message")
                .IsEmail(request.Email, "Email");
        }
    }
}
