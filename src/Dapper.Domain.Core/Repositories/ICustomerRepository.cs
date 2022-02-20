using Dapper.Domain.Entities.Customers;
using System;

namespace Dapper.Domain.Core.Repositories
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        //void Update(Customer customer);
        //void Delete(Customer customer);
        //Customer GetById(Guid id);
        Customer DataValidate(string email);
    }
}
