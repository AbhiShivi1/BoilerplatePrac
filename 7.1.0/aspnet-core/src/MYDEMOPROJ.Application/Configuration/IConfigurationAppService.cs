using System.Threading.Tasks;
using MYDEMOPROJ.Configuration.Dto;

namespace MYDEMOPROJ.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
