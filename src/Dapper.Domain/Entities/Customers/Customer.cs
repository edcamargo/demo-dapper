using Flunt.Notifications;

namespace Dapper.Domain.Entities.Customers
{
    public class Customer : Notifiable<Notification>
    {
        //public int Id { get; private set; }
        public string NameCustomer { get; private set; }
        public string Email { get; private set; }

        public Customer(string nameCustomer, string email)
        {
            //Id = id;
            NameCustomer = nameCustomer;
            Email = email;
        }
    }
}
