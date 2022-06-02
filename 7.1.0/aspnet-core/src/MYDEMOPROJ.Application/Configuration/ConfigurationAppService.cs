using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MYDEMOPROJ.Configuration.Dto;

namespace MYDEMOPROJ.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MYDEMOPROJAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
