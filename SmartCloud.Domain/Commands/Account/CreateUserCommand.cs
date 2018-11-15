namespace SmartCloud.Domain.Commands.Account
{
    public class CreateUserCommand
    {
        public int UserTypeId { get; set; }
        public string LineOfBusinessId { get; set; }
        public string EmployeeIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
    }
}