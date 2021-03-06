﻿using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class UserBehavior
    {
        public Guid UserBehaviorId { get; set; }
        public Guid? UserId { get; set; }
        public int? InspectionsPerformed { get; set; }
        public int? TotalFailedInspections { get; set; }
        public int? AverageIssuesDiscovered { get; set; }
        public DateTime? FirstInspectionDate { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public decimal? AverageInspectionScore { get; set; }
        public decimal? AverageInspectionTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModSystem { get; set; }

        public User User { get; set; }
    }
}
