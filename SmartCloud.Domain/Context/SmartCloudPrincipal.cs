using System;

namespace SmartCloud.Domain.Context
{
    public class SmartCloudPrincipal 
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DeviceIdentifier { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Name => FirstName + " " + LastName;
    }
}