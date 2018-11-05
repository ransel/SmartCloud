using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class FunctionType
    {
        public int FunctionTypeId { get; set; }
        public int? ServiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public Ctiotservice Service { get; set; }
    }
}
