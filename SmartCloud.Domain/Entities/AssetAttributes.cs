using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class AssetAttributes
    {
        public Guid AssetAttributesId { get; set; }
        public Guid? AssetId { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string Description { get; set; }
        public string IdentificationNumber { get; set; }
        public string Barcode { get; set; }
        public string LicensePlate { get; set; }
        public string Age { get; set; }
        public string Color { get; set; }
        public int? BeaconsAttached { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public Asset Asset { get; set; }
    }
}
