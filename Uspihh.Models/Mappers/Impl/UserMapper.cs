using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uspihh.Models.DTOModels;
using Uspihh.Models.Enums;
using Uspihh.Models.IdentityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class UserMapper : IMapper<ApplicationUser, RegisterOfUserBindingModel>
    {
        public ApplicationUser Map(RegisterOfUserBindingModel source)
        {
            return new ApplicationUser()
            {
                Id = 0,
                Email = source.Email,
                LastName = source.LastName,
                DateOfBirth = source.DateOfBirth,
                FirstName = source.FirstName,
                UserName = source.Email,
                Roles = { new UserRole { RoleId = (int)source.Role } },
                EmailConfirmed = true
            };
        }

        public RegisterOfUserBindingModel Map(ApplicationUser source)
        {
            throw new NotImplementedException();            
        }
    }
}
