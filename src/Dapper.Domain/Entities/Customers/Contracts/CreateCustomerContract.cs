using Flunt.Validations;

namespace Dapper.Domain.Entities.Customers.Contracts
{
    public class CreateCustomerContract : Contract<Customer>
    {
        public CreateCustomerContract(Customer customer)
        {
            Requires()
                .IsNotNullOrEmpty(customer.NameCustomer, "Nome", "Nome Inválido")
                .IsEmailOrEmpty(customer.Email, "Email", "Nome Inválido");
        }
    }
}
