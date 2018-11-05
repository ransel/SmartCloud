using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class Dvirmaster
    {
        public Dvirmaster()
        {
            InspectionResultsDvirrel = new HashSet<InspectionResultsDvirrel>();
        }

        public Guid DvirmasterId { get; set; }
        public int DvirmasterNumber { get; set; }
        public int? VehicleTypeId { get; set; }
        public string ElementName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string CreateSystem { get; set; }

        public ICollection<InspectionResultsDvirrel> InspectionResultsDvirrel { get; set; }
    }
}
