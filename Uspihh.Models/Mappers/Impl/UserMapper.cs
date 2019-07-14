using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uspihh.Models.DTOModels;
using Uspihh.Models.IdentityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class UserMapper : IMapper<ApplicationUser, UserDTO>
    {
        public ApplicationUser Map(UserDTO source)
        {
            return new ApplicationUser
            {
                Id = source.UserId,
                Email = source.Email,
                LastName = source.LastName,
                DateOfBirth = source.DateOfBirth,
                FirstName = source.FirstName,
                EmailConfirmed = source.EmailConfirmed
            };
        }

        public UserDTO Map(ApplicationUser source)
        {
            return new UserDTO
            {
                UserId = source.Id,
                Email = source.Email,
                LastName = source.LastName,
                DateOfBirth = source.DateOfBirth,
                FirstName = source.FirstName,
                EmailConfirmed = source.EmailConfirmed
            };
        }
    }
}
