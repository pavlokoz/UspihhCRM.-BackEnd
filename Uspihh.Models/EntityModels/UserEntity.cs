using System;

namespace Uspihh.Models.EntityModels
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
