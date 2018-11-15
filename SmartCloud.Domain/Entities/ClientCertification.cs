using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class ClientCertification
    {
        public Guid ClientCertificationId { get; set; }
        public Guid? UserId { get; set; }
        public string DeviceIdentifier { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public User User { get; set; }
    }
}
