using System.Threading.Tasks;
using Abp.Application.Services;
using MYDEMOPROJ.Authorization.Accounts.Dto;

namespace MYDEMOPROJ.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
