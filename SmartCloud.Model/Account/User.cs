using System;

namespace SmartCloud.Model.Account
{
    public class User
    {
        public Guid UserId { get; set; }
        public int? UserTypeId { get; set; }
        public Guid? LineOfBusinessId { get; set; }
        public string EmployeeId { get; set; }
        public bool? AuthorisedUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string DeviceIdentifier { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserConfig { get; set; }

        public string UserType { get; set; }
    }
}