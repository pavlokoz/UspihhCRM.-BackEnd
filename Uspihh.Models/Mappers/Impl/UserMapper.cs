using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers
{
    public class UserMapper : IMapper<UserEntity, UserDTO>
    {
        public UserEntity Map(UserDTO source)
        {
            return new UserEntity
            {
                UserId = source.UserId,
                FirstName = source.FirstName,
                LastName = source.LastName,
                DateOfBirth = source.DateOfBirth,
                Email = source.Email,
                EmailConfirmed = true,
                Role = source.Role
            };
        }

        public UserDTO Map(UserEntity source)
        {
            return new UserDTO
            {
                UserId = source.UserId,
                FirstName = source.FirstName,
                LastName = source.LastName,
                DateOfBirth = source.DateOfBirth,
                Email = source.Email,
                EmailConfirmed = true,
                Role = source.Role
            };
        }
    }
}
