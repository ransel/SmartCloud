using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class InspectionResultsDvirrel
    {
        public Guid InspectionResultsDvirrelId { get; set; }
        public Guid? InspectionResultsId { get; set; }
        public Guid? DvirmasterId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string CreateSystem { get; set; }
        public string LastModSystem { get; set; }

        public Dvirmaster Dvirmaster { get; set; }
    }
}
