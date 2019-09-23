using Abp.Authorization;
using Boiler.Authorization.Roles;
using Boiler.Authorization.Users;

namespace Boiler.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
