using Dapper.Domain.Core.Handlers.Customers.Requests;
using Dapper.Domain.Entities.Customers;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Domain.Core.Handlers.Customers
{
    public class CustomerHandler : Notifiable<Notification>
    {
        public bool Handle(CreateCustomerRequest request)
        {
            if (request.IsValid == false)
            {
                AddNotifications(request.Notifications);
                return false;
            }

            //var email = new Email(request.Email);
            var customer = new Customer(request.Name, 
                                        request.Email);

            //AddNotifications(email.Notifications);
            AddNotifications(customer.Notifications);

            return IsValid;

        }
    }
}
