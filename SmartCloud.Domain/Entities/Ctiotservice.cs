using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Ctiotservice
    {
        public Ctiotservice()
        {
            CustomerInspection = new HashSet<CustomerInspection>();
            FunctionType = new HashSet<FunctionType>();
        }

        public int ServiceId { get; set; }
        public Guid? LineOfBusinessId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? NumberOfLicenses { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public LineOfBusiness LineOfBusiness { get; set; }
        public ICollection<CustomerInspection> CustomerInspection { get; set; }
        public ICollection<FunctionType> FunctionType { get; set; }
    }
}
