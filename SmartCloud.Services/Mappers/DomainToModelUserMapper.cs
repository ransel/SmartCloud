using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmartCloud.Model.Account;

namespace SmartCloud.Services.Mappers
{
    public class DomainToModelUserMapper : IRequest<List<User>>
    {
        public List<Domain.Entities.User> Users { get; set; }
    }

    public class DomainToModelUserMapperHandler : IRequestHandler<DomainToModelUserMapper, List<User>>
    {
        public Task<List<User>> Handle(DomainToModelUserMapper request, CancellationToken cancellationToken)
        {
            var results = request.Users.Select(user => new User
                {
                    AuthorisedUser = user.AuthorisedUser,
                    DeviceIdentifier = user.DeviceIdentifier,
                    EmailAddress = user.EmailAddress,
                    EmployeeId = user.EmployeeId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    LineOfBusinessId = user.LineOfBusinessId,
                    MobileNumber = user.MobileNumber,
                    Password = user.Password,
                    UserConfig = user.UserConfig,
                    UserId = user.UserId,
                    UserName = user.UserName,
                    UserType = user.UserType?.Description,
                    UserTypeId = user.UserTypeId
                })
                .OrderBy(user => user.FirstName)
                .ThenBy(user => user.LastName)
                .ToList();

            return Task.FromResult(results);
        }
    }
}