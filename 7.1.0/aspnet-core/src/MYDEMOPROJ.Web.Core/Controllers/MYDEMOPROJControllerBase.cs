using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MYDEMOPROJ.Controllers
{
    public abstract class MYDEMOPROJControllerBase: AbpController
    {
        protected MYDEMOPROJControllerBase()
        {
            LocalizationSourceName = MYDEMOPROJConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
