using System.Collections.Generic;
using Boiler.Roles.Dto;
using Boiler.Users.Dto;

namespace Boiler.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}