namespace Dapper.Domain.Core.Commands
{
    public class CreateCustomerCommand
    {
        public CreateCustomerCommand() { }

        public CreateCustomerCommand(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; set; }
        public string Email { get; set; }
    }
}
