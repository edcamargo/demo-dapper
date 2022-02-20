using Dapper.Domain.Core.Handlers.Customers.Requests.Contracts;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Domain.Core.Handlers.Customers.Requests
{
    public class CreateCustomerRequest : Notifiable<Notification>
    {
        public CreateCustomerRequest(string name, string email)
        {
            Name = name;
            Email = email;

            AddNotifications(new CreateCustomerRequestContract(this));
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}
