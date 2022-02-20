using Dapper.Domain.Core.Repositories;
using Dapper.Domain.Entities.Customers;
using System;

namespace Dapper.InfraStructure.Data.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer DataValidate(string email)
        {
            throw new NotImplementedException();
        }
    }
}
