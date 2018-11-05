using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class AssetInformationRel
    {
        public Guid AssetInformationRelId { get; set; }
        public Guid? AssetId { get; set; }
        public Guid? AssetInspectionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public Asset Asset { get; set; }
        public AssetInspection AssetInspection { get; set; }
    }
}
