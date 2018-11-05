﻿using System;
using System.Collections.Generic;

namespace SmartCloud.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            LineOfBusinessUserRel = new HashSet<LineOfBusinessUserRel>();
            Notification = new HashSet<Notification>();
            OperatorCertification = new HashSet<OperatorCertification>();
            UserBehavior = new HashSet<UserBehavior>();
        }

        public Guid UserId { get; set; }
        public int? UserTypeId { get; set; }
        public Guid? LineOfBusinessId { get; set; }
        public string EmployeeId { get; set; }
        public bool? AuthorisedUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string DeviceIdentifier { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserConfig { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? LastModDate { get; set; }
        public string LastModUser { get; set; }
        public string LastModSystem { get; set; }

        public UserType UserType { get; set; }
        public ICollection<LineOfBusinessUserRel> LineOfBusinessUserRel { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<OperatorCertification> OperatorCertification { get; set; }
        public ICollection<UserBehavior> UserBehavior { get; set; }
    }
}
