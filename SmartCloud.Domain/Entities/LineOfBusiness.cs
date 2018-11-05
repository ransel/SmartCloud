using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class LineOfBusiness
    {
        public LineOfBusiness()
        {
            Asset = new HashSet<Asset>();
            Ctiotservice = new HashSet<Ctiotservice>();
            LineOfBusinessUserRel = new HashSet<LineOfBusinessUserRel>();
        }

        public Guid LineOfBusinessId { get; set; }
        public Guid? OrganizationId { get; set; }
        public Guid? SiteLocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public Organization Organization { get; set; }
        public SiteLocation SiteLocation { get; set; }
        public ICollection<Asset> Asset { get; set; }
        public ICollection<Ctiotservice> Ctiotservice { get; set; }
        public ICollection<LineOfBusinessUserRel> LineOfBusinessUserRel { get; set; }
    }
}
