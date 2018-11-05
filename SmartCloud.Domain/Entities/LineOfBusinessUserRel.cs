using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class LineOfBusinessUserRel
    {
        public byte[] LineOfBusinessUserRelId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? LineOfBusinessId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }

        public LineOfBusiness LineOfBusiness { get; set; }
        public User User { get; set; }
    }
}
