using Abp.Authorization;
using MYDEMOPROJ.Authorization.Roles;
using MYDEMOPROJ.Authorization.Users;

namespace MYDEMOPROJ.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
